namespace Victoriano_Smartphone
{
    partial class Resetear_Facturas
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
            this.reset = new System.Windows.Forms.Button();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reset
            // 
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Location = new System.Drawing.Point(26, 38);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 0;
            this.reset.Text = "Resetear";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(12, 12);
            this.tbpass.Name = "tbpass";
            this.tbpass.PasswordChar = '*';
            this.tbpass.Size = new System.Drawing.Size(100, 20);
            this.tbpass.TabIndex = 1;
            this.tbpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Resetear_Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(119, 73);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.reset);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(135, 111);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(135, 111);
            this.Name = "Resetear_Facturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resetear_Facturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox tbpass;
    }
}