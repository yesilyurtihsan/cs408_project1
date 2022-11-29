namespace project_server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logs_richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // logs_richTextBox
            // 
            this.logs_richTextBox.Location = new System.Drawing.Point(466, 12);
            this.logs_richTextBox.Name = "logs_richTextBox";
            this.logs_richTextBox.ReadOnly = true;
            this.logs_richTextBox.Size = new System.Drawing.Size(419, 734);
            this.logs_richTextBox.TabIndex = 0;
            this.logs_richTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 758);
            this.Controls.Add(this.logs_richTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox logs_richTextBox;
    }
}