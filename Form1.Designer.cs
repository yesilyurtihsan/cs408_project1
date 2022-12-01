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
            this.port_textBox = new System.Windows.Forms.TextBox();
            this.port_label = new System.Windows.Forms.Label();
            this.listen_button = new System.Windows.Forms.Button();
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
            // port_textBox
            // 
            this.port_textBox.Location = new System.Drawing.Point(115, 48);
            this.port_textBox.Name = "port_textBox";
            this.port_textBox.Size = new System.Drawing.Size(134, 27);
            this.port_textBox.TabIndex = 1;
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(63, 51);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(35, 20);
            this.port_label.TabIndex = 2;
            this.port_label.Text = "Port";
            // 
            // listen_button
            // 
            this.listen_button.Location = new System.Drawing.Point(269, 47);
            this.listen_button.Name = "listen_button";
            this.listen_button.Size = new System.Drawing.Size(94, 29);
            this.listen_button.TabIndex = 3;
            this.listen_button.Text = "Listen";
            this.listen_button.UseVisualStyleBackColor = true;
            this.listen_button.Click += new System.EventHandler(this.listen_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 758);
            this.Controls.Add(this.listen_button);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.port_textBox);
            this.Controls.Add(this.logs_richTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox logs_richTextBox;
        private TextBox port_textBox;
        private Label port_label;
        private Button listen_button;
    }
}