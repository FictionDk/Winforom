namespace WinFormDemo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.readOnceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startReadBtn = new System.Windows.Forms.Button();
            this.endReadBtn = new System.Windows.Forms.Button();
            this.flushTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readOnceBtn
            // 
            this.readOnceBtn.Location = new System.Drawing.Point(105, 67);
            this.readOnceBtn.Name = "readOnceBtn";
            this.readOnceBtn.Size = new System.Drawing.Size(116, 30);
            this.readOnceBtn.TabIndex = 0;
            this.readOnceBtn.Text = "读一次";
            this.readOnceBtn.UseVisualStyleBackColor = true;
            this.readOnceBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            // 
            // startReadBtn
            // 
            this.startReadBtn.Location = new System.Drawing.Point(244, 67);
            this.startReadBtn.Name = "startReadBtn";
            this.startReadBtn.Size = new System.Drawing.Size(116, 30);
            this.startReadBtn.TabIndex = 2;
            this.startReadBtn.Text = "开始读";
            this.startReadBtn.UseVisualStyleBackColor = true;
            this.startReadBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // endReadBtn
            // 
            this.endReadBtn.Location = new System.Drawing.Point(380, 67);
            this.endReadBtn.Name = "endReadBtn";
            this.endReadBtn.Size = new System.Drawing.Size(116, 30);
            this.endReadBtn.TabIndex = 3;
            this.endReadBtn.Text = "结束读";
            this.endReadBtn.UseVisualStyleBackColor = true;
            this.endReadBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // flushTxt
            // 
            this.flushTxt.Location = new System.Drawing.Point(318, 154);
            this.flushTxt.Name = "flushTxt";
            this.flushTxt.Size = new System.Drawing.Size(100, 25);
            this.flushTxt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flushTxt);
            this.Controls.Add(this.endReadBtn);
            this.Controls.Add(this.startReadBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readOnceBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readOnceBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startReadBtn;
        private System.Windows.Forms.Button endReadBtn;
        private System.Windows.Forms.TextBox flushTxt;
    }
}

