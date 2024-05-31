namespace lab19
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button buttonFetchInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.buttonFetchInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 12);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutput.Size = new System.Drawing.Size(776, 396);
            this.textBoxOutput.TabIndex = 0;
            // 
            // buttonFetchInfo
            // 
            this.buttonFetchInfo.Location = new System.Drawing.Point(713, 414);
            this.buttonFetchInfo.Name = "buttonFetchInfo";
            this.buttonFetchInfo.Size = new System.Drawing.Size(75, 23);
            this.buttonFetchInfo.TabIndex = 1;
            this.buttonFetchInfo.Text = "Отримати";
            this.buttonFetchInfo.UseVisualStyleBackColor = true;
            this.buttonFetchInfo.Click += new System.EventHandler(this.buttonFetchInfo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonFetchInfo);
            this.Controls.Add(this.textBoxOutput);
            this.Name = "Form1";
            this.Text = "Lab 19";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

