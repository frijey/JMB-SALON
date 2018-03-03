namespace Victoriano_Smartphone
{
    partial class TerminarTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminarTrabajo));
            this.lbconcepto = new System.Windows.Forms.Label();
            this.tbmonto = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbregistro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbconcepto
            // 
            this.lbconcepto.AutoSize = true;
            this.lbconcepto.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconcepto.Location = new System.Drawing.Point(19, 16);
            this.lbconcepto.Name = "lbconcepto";
            this.lbconcepto.Size = new System.Drawing.Size(215, 31);
            this.lbconcepto.TabIndex = 63;
            this.lbconcepto.Text = "Monto a Cobrar:";
            // 
            // tbmonto
            // 
            this.tbmonto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmonto.Location = new System.Drawing.Point(235, 22);
            this.tbmonto.Name = "tbmonto";
            this.tbmonto.Size = new System.Drawing.Size(141, 26);
            this.tbmonto.TabIndex = 62;
            this.tbmonto.Text = "RD$ 0.00";
            this.tbmonto.Enter += new System.EventHandler(this.tbmonto_Enter);
            this.tbmonto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbmonto_KeyDown);
            this.tbmonto.Leave += new System.EventHandler(this.tbmonto_Leave);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(235, 55);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(141, 38);
            this.btnbuscar.TabIndex = 68;
            this.btnbuscar.Text = "Facturar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(132, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 38);
            this.button1.TabIndex = 69;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbregistro
            // 
            this.lbregistro.AutoSize = true;
            this.lbregistro.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbregistro.Location = new System.Drawing.Point(31, 58);
            this.lbregistro.Name = "lbregistro";
            this.lbregistro.Size = new System.Drawing.Size(44, 28);
            this.lbregistro.TabIndex = 70;
            this.lbregistro.Text = "No.: ";
            // 
            // TerminarTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 103);
            this.Controls.Add(this.lbregistro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.lbconcepto);
            this.Controls.Add(this.tbmonto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(423, 141);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(423, 141);
            this.Name = "TerminarTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesar Registro";
            this.Load += new System.EventHandler(this.FacturarRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbconcepto;
        private System.Windows.Forms.TextBox tbmonto;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbregistro;
    }
}