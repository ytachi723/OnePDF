
namespace 全てのファイルをPDF変換後_1ファイルに_
{
    partial class Form
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.Label();
            this.extension = new System.Windows.Forms.Label();
            this.memo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(148, 16);
            this.label.TabIndex = 0;
            this.label.Text = "完成後のファイル名：";
            // 
            // textbox
            // 
            this.textbox.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textbox.Location = new System.Drawing.Point(159, 6);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(386, 23);
            this.textbox.TabIndex = 1;
            this.textbox.TextChanged += new System.EventHandler(this.textbox_TextChanged);
            // 
            // button
            // 
            this.button.Enabled = false;
            this.button.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button.Location = new System.Drawing.Point(75, 44);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(75, 23);
            this.button.TabIndex = 2;
            this.button.Text = "開始";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // progress
            // 
            this.progress.AutoSize = true;
            this.progress.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.progress.Location = new System.Drawing.Point(156, 47);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(65, 16);
            this.progress.TabIndex = 3;
            this.progress.Text = "progress";
            // 
            // extension
            // 
            this.extension.AutoSize = true;
            this.extension.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.extension.Location = new System.Drawing.Point(541, 13);
            this.extension.Name = "extension";
            this.extension.Size = new System.Drawing.Size(36, 16);
            this.extension.TabIndex = 4;
            this.extension.Text = ".pdf";
            // 
            // memo
            // 
            this.memo.AutoSize = true;
            this.memo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.memo.Location = new System.Drawing.Point(72, 70);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(31, 16);
            this.memo.TabIndex = 5;
            this.memo.Text = "メモ";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 93);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.extension);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label);
            this.Name = "Form";
            this.Text = "全てのファイルをPDF変換後、1つのファイルに！";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label progress;
        private System.Windows.Forms.Label extension;
        private System.Windows.Forms.Label memo;
    }
}

