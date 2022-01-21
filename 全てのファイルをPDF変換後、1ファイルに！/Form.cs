using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;



namespace 全てのファイルをPDF変換後_1ファイルに_
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            progress.Text = "";
            memo.Text = "";
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            if (textbox.Text.Length > 0)
            {
                button.Enabled = true;
            }
            else
            {
                button.Enabled = false;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (!button.Enabled)
            {
                return;
            }

            System.IO.DirectoryInfo nowFolder = new System.IO.DirectoryInfo(@".");
            System.IO.SearchOption searchOption = System.IO.SearchOption.TopDirectoryOnly;

            // WordファイルをPDFファイルに変換
            Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
            Microsoft.Office.Interop.Word.Document document = null;
            IEnumerable<System.IO.FileInfo> now = nowFolder.EnumerateFiles("*.docx", searchOption);

            foreach (var item in now)
            {
                progress.Text = item + " を変換中";
                try
                {
                    document = word.Documents.Open(item.DirectoryName + "\\" + item);
                    document.ExportAsFixedFormat(item.DirectoryName + "\\" + item + ".pdf", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);
                    document.Close();
                }
                catch (System.Exception exception)
                {
                    System.Console.WriteLine(exception.Message);
                }
            }

            // PowerPointファイルをPDFファイルに変換
            // PowerPointがどうしても開いたままになる by tachi 2021/07/10
            // open関数の引数指定でPowerPointが開いたままになることを解消 by tachi 2021/08/19
            Microsoft.Office.Interop.PowerPoint.Application powerpoint = new Microsoft.Office.Interop.PowerPoint.Application();
            Microsoft.Office.Interop.PowerPoint.Presentation presentation = null;

            now = nowFolder.EnumerateFiles("*.pptx", searchOption);
            // PowerPointが開いたままにならなくなったため、削除 by tachi 2021/08/19
            //            var pptFlag = (now.Count() > 0);
            //            if (pptFlag)
            //            {
            //                memo.Text = "PowerPointが開いたままになるので、必要に応じて閉じてください。";
            //            }
            foreach (var item in now)
            {
                progress.Text = item + " を変換中";
                try
                {
                    presentation = powerpoint.Presentations.Open(item.DirectoryName + "\\" + item, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoTrue, Microsoft.Office.Core.MsoTriState.msoFalse);
                    presentation.ExportAsFixedFormat(item.DirectoryName + "\\" + item + ".pdf", Microsoft.Office.Interop.PowerPoint.PpFixedFormatType.ppFixedFormatTypePDF);
                    presentation.Close();
                }
                catch (System.Exception exception)
                {
                    System.Console.WriteLine(exception.Message);
                }
            }

            // PDFファイルを統合
            progress.Text = textbox.Text + ".pdf を作成中";
            now = nowFolder.EnumerateFiles("*.pdf", searchOption);
            PdfDocument pdfDocument = new PdfDocument();
            PdfDocument inputDocument;
            foreach (var item in now)
            {
                inputDocument = PdfReader.Open(item.DirectoryName + "\\" + item.ToString(), PdfDocumentOpenMode.Import);
                foreach (PdfPage page in inputDocument.Pages)
                {
                    // PDF頁を追加
                    pdfDocument.AddPage(page);
                }
                inputDocument.Close();
            }
            pdfDocument.Save(now.First().DirectoryName + "\\" + textbox.Text + ".pdf");
            // PDFを閉じる
            pdfDocument.Close();

            progress.Text = "完了";
            // PowerPointが開いたままにならなくなったため、削除 by tachi 2021/08/19
            //            if (pptFlag)
            //            {
            //                MessageBox.Show("PowerPointが開いたままになるので、必要に応じて閉じてください。");
            //            }
            Application.Exit();
        }
    }
}
