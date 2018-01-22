namespace dytt
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
            this.text_url = new System.Windows.Forms.TextBox();
            this.url = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_url
            // 
            this.text_url.Location = new System.Drawing.Point(66, 42);
            this.text_url.Name = "text_url";
            this.text_url.Size = new System.Drawing.Size(167, 21);
            this.text_url.TabIndex = 0;
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(24, 46);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(29, 12);
            this.url.TabIndex = 2;
            this.url.Text = "地址";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(244, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "获取";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(26, 92);
            this.show.Multiline = true;
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(277, 168);
            this.show.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 294);
            this.Controls.Add(this.show);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.url);
            this.Controls.Add(this.text_url);
            this.Name = "Form1";
            this.Text = "迅雷下载小工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_url;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox show;
    }
}

