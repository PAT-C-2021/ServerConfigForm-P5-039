
namespace ServerConfigForm_P5_20190140039
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
            this.ON = new System.Windows.Forms.Button();
            this.OFF = new System.Windows.Forms.Button();
            this.Server = new System.Windows.Forms.Label();
            this.labelKeterangan = new System.Windows.Forms.Label();
            this.LabelOnOff = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ON
            // 
            this.ON.Location = new System.Drawing.Point(149, 146);
            this.ON.Name = "ON";
            this.ON.Size = new System.Drawing.Size(75, 23);
            this.ON.TabIndex = 0;
            this.ON.Text = "ON";
            this.ON.UseVisualStyleBackColor = true;
            this.ON.Click += new System.EventHandler(this.ON_Click);
            // 
            // OFF
            // 
            this.OFF.Location = new System.Drawing.Point(301, 146);
            this.OFF.Name = "OFF";
            this.OFF.Size = new System.Drawing.Size(75, 23);
            this.OFF.TabIndex = 1;
            this.OFF.Text = "OFF";
            this.OFF.UseVisualStyleBackColor = true;
            this.OFF.Click += new System.EventHandler(this.OFF_Click);
            // 
            // Server
            // 
            this.Server.AutoSize = true;
            this.Server.Location = new System.Drawing.Point(244, 60);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(38, 13);
            this.Server.TabIndex = 2;
            this.Server.Text = "Server";
            this.Server.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelKeterangan
            // 
            this.labelKeterangan.AutoSize = true;
            this.labelKeterangan.Location = new System.Drawing.Point(221, 89);
            this.labelKeterangan.Name = "labelKeterangan";
            this.labelKeterangan.Size = new System.Drawing.Size(0, 13);
            this.labelKeterangan.TabIndex = 3;
            this.labelKeterangan.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // LabelOnOff
            // 
            this.LabelOnOff.AutoSize = true;
            this.LabelOnOff.Location = new System.Drawing.Point(221, 118);
            this.LabelOnOff.Name = "LabelOnOff";
            this.LabelOnOff.Size = new System.Drawing.Size(0, 13);
            this.LabelOnOff.TabIndex = 4;
            this.LabelOnOff.Click += new System.EventHandler(this.LabelOnOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 282);
            this.Controls.Add(this.LabelOnOff);
            this.Controls.Add(this.labelKeterangan);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.OFF);
            this.Controls.Add(this.ON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ON;
        private System.Windows.Forms.Button OFF;
        private System.Windows.Forms.Label Server;
        private System.Windows.Forms.Label labelKeterangan;
        private System.Windows.Forms.Label LabelOnOff;
    }
}

