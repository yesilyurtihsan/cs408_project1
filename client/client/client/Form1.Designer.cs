﻿namespace client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.button_connect = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.RichTextBox();
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(72, 12);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(172, 31);
            this.textBox_ip.TabIndex = 2;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(72, 67);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(172, 31);
            this.textBox_port.TabIndex = 3;
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(72, 175);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(139, 43);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.button_connect_Click);
            // 
            // logs
            // 
            this.logs.Location = new System.Drawing.Point(293, 15);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(595, 478);
            this.logs.TabIndex = 5;
            this.logs.Text = "";
            // 
            // textBox_message
            // 
            this.textBox_message.Enabled = false;
            this.textBox_message.Location = new System.Drawing.Point(293, 531);
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(395, 31);
            this.textBox_message.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Answer:";
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(758, 518);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(130, 50);
            this.button_send.TabIndex = 8;
            this.button_send.Text = "send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(72, 117);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(172, 31);
            this.textBox_name.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 689);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_message);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.RichTextBox logs;
        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_name;
    }
}

