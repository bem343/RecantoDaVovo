
namespace prjRecantoDaVovo.Forms
{
    partial class IP
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
            this.btnIP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIP
            // 
            this.btnIP.Location = new System.Drawing.Point(113, 36);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(97, 23);
            this.btnIP.TabIndex = 0;
            this.btnIP.Text = "Salvar";
            this.btnIP.UseVisualStyleBackColor = true;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP da máquina: ";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(114, 13);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(95, 20);
            this.txtIP.TabIndex = 2;
            // 
            // IP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 63);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnIP);
            this.Name = "IP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP";
            this.Load += new System.EventHandler(this.IP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIP;
    }
}