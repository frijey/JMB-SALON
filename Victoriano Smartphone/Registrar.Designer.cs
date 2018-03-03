namespace Victoriano_Smartphone
{
    partial class Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btcnew = new System.Windows.Forms.Button();
            this.btimprimir = new System.Windows.Forms.Button();
            this.btcsave = new System.Windows.Forms.Button();
            this.tbdetalle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbmodelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbequipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbproceso = new System.Windows.Forms.ComboBox();
            this.lbfecha = new System.Windows.Forms.Label();
            this.lbnumregistro = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbmemoria = new System.Windows.Forms.ComboBox();
            this.tbchip = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(506, 259);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 150);
            this.dataGridView1.TabIndex = 57;
            this.dataGridView1.Visible = false;
            // 
            // btcnew
            // 
            this.btcnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcnew.Location = new System.Drawing.Point(364, 339);
            this.btcnew.Name = "btcnew";
            this.btcnew.Size = new System.Drawing.Size(114, 34);
            this.btcnew.TabIndex = 9;
            this.btcnew.Text = "Nuevo";
            this.btcnew.UseVisualStyleBackColor = true;
            this.btcnew.Click += new System.EventHandler(this.btcnew_Click);
            // 
            // btimprimir
            // 
            this.btimprimir.Enabled = false;
            this.btimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btimprimir.Location = new System.Drawing.Point(356, 295);
            this.btimprimir.Name = "btimprimir";
            this.btimprimir.Size = new System.Drawing.Size(93, 38);
            this.btimprimir.TabIndex = 8;
            this.btimprimir.Text = "Imprimir";
            this.btimprimir.UseVisualStyleBackColor = true;
            this.btimprimir.Click += new System.EventHandler(this.btimprimir_Click);
            // 
            // btcsave
            // 
            this.btcsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btcsave.Location = new System.Drawing.Point(257, 295);
            this.btcsave.Name = "btcsave";
            this.btcsave.Size = new System.Drawing.Size(93, 38);
            this.btcsave.TabIndex = 7;
            this.btcsave.Text = "Guardar";
            this.btcsave.UseVisualStyleBackColor = true;
            this.btcsave.Click += new System.EventHandler(this.btcsave_Click);
            // 
            // tbdetalle
            // 
            this.tbdetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbdetalle.Location = new System.Drawing.Point(234, 217);
            this.tbdetalle.MaxLength = 175;
            this.tbdetalle.Multiline = true;
            this.tbdetalle.Name = "tbdetalle";
            this.tbdetalle.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbdetalle.Size = new System.Drawing.Size(257, 70);
            this.tbdetalle.TabIndex = 4;
            this.tbdetalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbdetalle_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(147, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 53;
            this.label7.Text = "Detalle";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(146, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 51;
            this.label5.Text = "Proceso";
            // 
            // tbmodelo
            // 
            this.tbmodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbmodelo.Location = new System.Drawing.Point(234, 149);
            this.tbmodelo.Name = "tbmodelo";
            this.tbmodelo.Size = new System.Drawing.Size(169, 23);
            this.tbmodelo.TabIndex = 2;
            this.tbmodelo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbmodelo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(146, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Modelo";
            // 
            // tbequipo
            // 
            this.tbequipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbequipo.Location = new System.Drawing.Point(234, 113);
            this.tbequipo.Name = "tbequipo";
            this.tbequipo.Size = new System.Drawing.Size(141, 23);
            this.tbequipo.TabIndex = 1;
            this.tbequipo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbequipo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(146, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 49;
            this.label2.Text = "Equipo";
            // 
            // tbnombre
            // 
            this.tbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbnombre.Location = new System.Drawing.Point(354, 77);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(304, 23);
            this.tbnombre.TabIndex = 0;
            this.tbnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbnombre_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(147, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 24);
            this.label1.TabIndex = 48;
            this.label1.Text = "Nombre del Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 30.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(149, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 48);
            this.label3.TabIndex = 44;
            this.label3.Text = "Agregar Registro";
            // 
            // tbproceso
            // 
            this.tbproceso.FormattingEnabled = true;
            this.tbproceso.Items.AddRange(new object[] {
            "Reparación",
            "Desbloqueo",
            "Desbloqueo y Reparación"});
            this.tbproceso.Location = new System.Drawing.Point(234, 184);
            this.tbproceso.Name = "tbproceso";
            this.tbproceso.Size = new System.Drawing.Size(169, 21);
            this.tbproceso.TabIndex = 3;
            this.tbproceso.Text = "Reparación";
            this.tbproceso.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbproceso_KeyDown);
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Goudy Old Style", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbfecha.Location = new System.Drawing.Point(599, 9);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(96, 21);
            this.lbfecha.TabIndex = 60;
            this.lbfecha.Text = "00/00/0000";
            // 
            // lbnumregistro
            // 
            this.lbnumregistro.AutoSize = true;
            this.lbnumregistro.Font = new System.Drawing.Font("Goudy Old Style", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbnumregistro.Location = new System.Drawing.Point(497, 36);
            this.lbnumregistro.Name = "lbnumregistro";
            this.lbnumregistro.Size = new System.Drawing.Size(108, 21);
            this.lbnumregistro.TabIndex = 61;
            this.lbnumregistro.Text = "No. Registro: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(423, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 24);
            this.label6.TabIndex = 63;
            this.label6.Text = "Memoria";
            // 
            // tbmemoria
            // 
            this.tbmemoria.FormattingEnabled = true;
            this.tbmemoria.Items.AddRange(new object[] {
            "No",
            "1 GB",
            "2 GB",
            "4 GB",
            "8 GB",
            "16 GB",
            "32 GB",
            "64 GB",
            "128 GB",
            "256 GB",
            "512 GB",
            "Otra"});
            this.tbmemoria.Location = new System.Drawing.Point(525, 130);
            this.tbmemoria.Name = "tbmemoria";
            this.tbmemoria.Size = new System.Drawing.Size(78, 21);
            this.tbmemoria.TabIndex = 5;
            this.tbmemoria.Text = "No";
            this.tbmemoria.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbmemoria_KeyDown);
            // 
            // tbchip
            // 
            this.tbchip.FormattingEnabled = true;
            this.tbchip.Items.AddRange(new object[] {
            "No",
            "Orange",
            "Claro",
            "Tricon",
            "Viva",
            "TurboSim",
            "AT&T",
            "Movistar",
            "Wind",
            "Otro"});
            this.tbchip.Location = new System.Drawing.Point(495, 172);
            this.tbchip.Name = "tbchip";
            this.tbchip.Size = new System.Drawing.Size(82, 21);
            this.tbchip.TabIndex = 6;
            this.tbchip.Text = "No";
            this.tbchip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbchip_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(423, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 24);
            this.label8.TabIndex = 66;
            this.label8.Text = "Chip";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(223, 339);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(114, 34);
            this.btnbuscar.TabIndex = 67;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Victoriano_Smartphone.Properties.Resources.siteaudit_green;
            this.pictureBox2.Location = new System.Drawing.Point(-2, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox3.Image = global::Victoriano_Smartphone.Properties.Resources._082421_green_jelly_icon_business_tools1;
            this.pictureBox3.Location = new System.Drawing.Point(12, 200);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 199);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 56;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Victoriano_Smartphone.Properties.Resources._082673_green_metallic_orb_icon_business_toolset_sc44;
            this.pictureBox1.Location = new System.Drawing.Point(480, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 247);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Victoriano_Smartphone.Properties.Resources.microsd_micro_3901;
            this.pictureBox4.Location = new System.Drawing.Point(596, 94);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(85, 111);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 65;
            this.pictureBox4.TabStop = false;
            // 
            // Registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 400);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.tbchip);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbmemoria);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbnumregistro);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.tbproceso);
            this.Controls.Add(this.btcnew);
            this.Controls.Add(this.btimprimir);
            this.Controls.Add(this.btcsave);
            this.Controls.Add(this.tbdetalle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbmodelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbequipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(710, 438);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(710, 438);
            this.Name = "Registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.Registrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btcnew;
        private System.Windows.Forms.Button btimprimir;
        private System.Windows.Forms.Button btcsave;
        private System.Windows.Forms.TextBox tbdetalle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbmodelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbequipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox tbproceso;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Label lbnumregistro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox tbmemoria;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ComboBox tbchip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnbuscar;
    }
}