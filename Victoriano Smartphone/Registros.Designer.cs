namespace Victoriano_Smartphone
{
    partial class Registros
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
            this.btnmostrartodo = new System.Windows.Forms.Button();
            this.btmodificar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modeo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fechallegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.rdenproceso = new System.Windows.Forms.RadioButton();
            this.rdentregados = new System.Windows.Forms.RadioButton();
            this.btnfacturar = new System.Windows.Forms.Button();
            this.rdterminados = new System.Windows.Forms.RadioButton();
            this.ptbflecha = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btbuscar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbflecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnmostrartodo
            // 
            this.btnmostrartodo.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrartodo.Location = new System.Drawing.Point(236, 341);
            this.btnmostrartodo.Name = "btnmostrartodo";
            this.btnmostrartodo.Size = new System.Drawing.Size(157, 57);
            this.btnmostrartodo.TabIndex = 52;
            this.btnmostrartodo.Text = "Mostrar Todo";
            this.btnmostrartodo.UseVisualStyleBackColor = true;
            this.btnmostrartodo.Click += new System.EventHandler(this.btnmostrartodo_Click);
            // 
            // btmodificar
            // 
            this.btmodificar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmodificar.Location = new System.Drawing.Point(12, 334);
            this.btmodificar.Name = "btmodificar";
            this.btmodificar.Size = new System.Drawing.Size(214, 64);
            this.btmodificar.TabIndex = 49;
            this.btmodificar.Text = "Modificar/Registrar";
            this.btmodificar.UseVisualStyleBackColor = true;
            this.btmodificar.Click += new System.EventHandler(this.btmodificar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registro,
            this.Cliente,
            this.Modeo,
            this.Fechallegada,
            this.monto});
            this.dataGridView1.Location = new System.Drawing.Point(2, 75);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(644, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(475, 253);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // registro
            // 
            this.registro.HeaderText = "No.:";
            this.registro.Name = "registro";
            this.registro.ReadOnly = true;
            this.registro.Width = 60;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 121;
            // 
            // Modeo
            // 
            this.Modeo.HeaderText = "Modelo";
            this.Modeo.Name = "Modeo";
            this.Modeo.ReadOnly = true;
            // 
            // Fechallegada
            // 
            this.Fechallegada.HeaderText = "Fecha";
            this.Fechallegada.Name = "Fechallegada";
            this.Fechallegada.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.HeaderText = "Monto (RD$)";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            this.monto.Width = 91;
            // 
            // tbnombre
            // 
            this.tbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnombre.Location = new System.Drawing.Point(236, 9);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(187, 22);
            this.tbnombre.TabIndex = 46;
            this.tbnombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbnombre_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 18.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(67, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 45;
            this.label1.Text = "Buscar por Nombre";
            // 
            // tbcodigo
            // 
            this.tbcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcodigo.Location = new System.Drawing.Point(339, 45);
            this.tbcodigo.MaxLength = 7;
            this.tbcodigo.Name = "tbcodigo";
            this.tbcodigo.Size = new System.Drawing.Size(83, 22);
            this.tbcodigo.TabIndex = 54;
            this.tbcodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbcodigo_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 18.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(241, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 31);
            this.label2.TabIndex = 53;
            this.label2.Text = "Por Código";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(10, 237);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(398, 81);
            this.dataGridView2.TabIndex = 110;
            this.dataGridView2.Visible = false;
            // 
            // rdenproceso
            // 
            this.rdenproceso.AutoSize = true;
            this.rdenproceso.BackColor = System.Drawing.Color.Transparent;
            this.rdenproceso.Checked = true;
            this.rdenproceso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdenproceso.Location = new System.Drawing.Point(483, 73);
            this.rdenproceso.Name = "rdenproceso";
            this.rdenproceso.Size = new System.Drawing.Size(102, 23);
            this.rdenproceso.TabIndex = 111;
            this.rdenproceso.TabStop = true;
            this.rdenproceso.Text = "En Proceso";
            this.rdenproceso.UseVisualStyleBackColor = false;
            this.rdenproceso.CheckedChanged += new System.EventHandler(this.rdenproceso_CheckedChanged);
            // 
            // rdentregados
            // 
            this.rdentregados.AutoSize = true;
            this.rdentregados.BackColor = System.Drawing.Color.Transparent;
            this.rdentregados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdentregados.Location = new System.Drawing.Point(483, 122);
            this.rdentregados.Name = "rdentregados";
            this.rdentregados.Size = new System.Drawing.Size(103, 23);
            this.rdentregados.TabIndex = 112;
            this.rdentregados.Text = "Entregados";
            this.rdentregados.UseVisualStyleBackColor = false;
            this.rdentregados.CheckedChanged += new System.EventHandler(this.rdterminados_CheckedChanged);
            // 
            // btnfacturar
            // 
            this.btnfacturar.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfacturar.Location = new System.Drawing.Point(481, 147);
            this.btnfacturar.Name = "btnfacturar";
            this.btnfacturar.Size = new System.Drawing.Size(133, 37);
            this.btnfacturar.TabIndex = 113;
            this.btnfacturar.Text = "Terminar";
            this.btnfacturar.UseVisualStyleBackColor = true;
            this.btnfacturar.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdterminados
            // 
            this.rdterminados.AutoSize = true;
            this.rdterminados.BackColor = System.Drawing.Color.Transparent;
            this.rdterminados.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdterminados.Location = new System.Drawing.Point(483, 98);
            this.rdterminados.Name = "rdterminados";
            this.rdterminados.Size = new System.Drawing.Size(105, 23);
            this.rdterminados.TabIndex = 114;
            this.rdterminados.Text = "Terminados";
            this.rdterminados.UseVisualStyleBackColor = false;
            this.rdterminados.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // ptbflecha
            // 
            this.ptbflecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbflecha.Image = global::Victoriano_Smartphone.Properties.Resources.red_arrow_2718071_640;
            this.ptbflecha.Location = new System.Drawing.Point(501, 190);
            this.ptbflecha.Name = "ptbflecha";
            this.ptbflecha.Size = new System.Drawing.Size(84, 42);
            this.ptbflecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbflecha.TabIndex = 115;
            this.ptbflecha.TabStop = false;
            this.ptbflecha.Click += new System.EventHandler(this.ptbflecha_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Victoriano_Smartphone.Properties.Resources.siteaudit_green;
            this.pictureBox2.Location = new System.Drawing.Point(6, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 59;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Victoriano_Smartphone.Properties.Resources.lupa_psd_468x468;
            this.pictureBox1.Location = new System.Drawing.Point(425, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btbuscar
            // 
            this.btbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbuscar.Image = global::Victoriano_Smartphone.Properties.Resources.lupa_psd_468x468;
            this.btbuscar.Location = new System.Drawing.Point(421, 4);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(44, 31);
            this.btbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btbuscar.TabIndex = 48;
            this.btbuscar.TabStop = false;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox4.Image = global::Victoriano_Smartphone.Properties.Resources._082421_green_jelly_icon_business_tools1;
            this.pictureBox4.Location = new System.Drawing.Point(485, -3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(86, 83);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 60;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Victoriano_Smartphone.Properties.Resources._082673_green_metallic_orb_icon_business_toolset_sc44;
            this.pictureBox6.Location = new System.Drawing.Point(434, 220);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(189, 221);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 61;
            this.pictureBox6.TabStop = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(10, 170);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.Size = new System.Drawing.Size(449, 148);
            this.dataGridView3.TabIndex = 116;
            this.dataGridView3.Visible = false;
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 409);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.ptbflecha);
            this.Controls.Add(this.rdterminados);
            this.Controls.Add(this.btnfacturar);
            this.Controls.Add(this.rdentregados);
            this.Controls.Add(this.rdenproceso);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbcodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnmostrartodo);
            this.Controls.Add(this.btmodificar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(636, 447);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(636, 447);
            this.Name = "Registros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Registros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbflecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnmostrartodo;
        private System.Windows.Forms.Button btmodificar;
        private System.Windows.Forms.PictureBox btbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbcodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RadioButton rdenproceso;
        private System.Windows.Forms.RadioButton rdentregados;
        private System.Windows.Forms.Button btnfacturar;
        private System.Windows.Forms.RadioButton rdterminados;
        private System.Windows.Forms.PictureBox ptbflecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fechallegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}