namespace Victoriano_Smartphone
{
    partial class ConsultarFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarFacturas));
            this.btbuscar = new System.Windows.Forms.PictureBox();
            this.tbcodigof = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtfechafrom = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1update = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.dtfechato = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btbuscar1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btbuscar
            // 
            this.btbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbuscar.Image = global::Victoriano_Smartphone.Properties.Resources.lupa_psd_468x468;
            this.btbuscar.Location = new System.Drawing.Point(376, 48);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(53, 30);
            this.btbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btbuscar.TabIndex = 41;
            this.btbuscar.TabStop = false;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // tbcodigof
            // 
            this.tbcodigof.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcodigof.Location = new System.Drawing.Point(274, 51);
            this.tbcodigof.Name = "tbcodigof";
            this.tbcodigof.Size = new System.Drawing.Size(107, 22);
            this.tbcodigof.TabIndex = 0;
            this.tbcodigof.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbcodigof_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 22);
            this.label1.TabIndex = 40;
            this.label1.Text = "Facturas Generadas por Fecha";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Victoriano_Smartphone.Properties.Resources.ED_1_Trans;
            this.pictureBox3.Location = new System.Drawing.Point(289, 90);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(346, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Victoriano_Smartphone.Properties.Resources._2bck_trans2;
            this.pictureBox5.Location = new System.Drawing.Point(173, 296);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(462, 199);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(172, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 22);
            this.label2.TabIndex = 45;
            this.label2.Text = "Por Código";
            // 
            // dtfechafrom
            // 
            this.dtfechafrom.CustomFormat = "";
            this.dtfechafrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfechafrom.Location = new System.Drawing.Point(274, 21);
            this.dtfechafrom.Name = "dtfechafrom";
            this.dtfechafrom.Size = new System.Drawing.Size(95, 20);
            this.dtfechafrom.TabIndex = 46;
            this.dtfechafrom.Value = new System.DateTime(2017, 6, 27, 0, 0, 0, 0);
            this.dtfechafrom.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtfechafrom_KeyUp);
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
            this.id,
            this.codigoc,
            this.cliente,
            this.fecha,
            this.total});
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(478, 317);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "Código";
            this.id.MaxInputLength = 25;
            this.id.MinimumWidth = 3;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.Width = 50;
            // 
            // codigoc
            // 
            this.codigoc.Frozen = true;
            this.codigoc.HeaderText = "Codigo C";
            this.codigoc.Name = "codigoc";
            this.codigoc.ReadOnly = true;
            this.codigoc.Width = 75;
            // 
            // cliente
            // 
            this.cliente.Frozen = true;
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.Frozen = true;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 150;
            // 
            // total
            // 
            this.total.Frozen = true;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // dataGridView1update
            // 
            this.dataGridView1update.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1update.Enabled = false;
            this.dataGridView1update.Location = new System.Drawing.Point(23, 220);
            this.dataGridView1update.Name = "dataGridView1update";
            this.dataGridView1update.Size = new System.Drawing.Size(455, 150);
            this.dataGridView1update.TabIndex = 67;
            this.dataGridView1update.Visible = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(23, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 63);
            this.button1.TabIndex = 68;
            this.button1.Text = "Mostrar Todo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtfechato
            // 
            this.dtfechato.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfechato.Location = new System.Drawing.Point(382, 21);
            this.dtfechato.Name = "dtfechato";
            this.dtfechato.Size = new System.Drawing.Size(95, 20);
            this.dtfechato.TabIndex = 69;
            this.dtfechato.Value = new System.DateTime(2017, 6, 27, 0, 0, 0, 0);
            this.dtfechato.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtfechato_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 29);
            this.label3.TabIndex = 70;
            this.label3.Text = "-";
            // 
            // btbuscar1
            // 
            this.btbuscar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbuscar1.Image = global::Victoriano_Smartphone.Properties.Resources.lupa_psd_468x468;
            this.btbuscar1.Location = new System.Drawing.Point(471, 16);
            this.btbuscar1.Name = "btbuscar1";
            this.btbuscar1.Size = new System.Drawing.Size(53, 30);
            this.btbuscar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btbuscar1.TabIndex = 71;
            this.btbuscar1.TabStop = false;
            this.btbuscar1.Click += new System.EventHandler(this.btbuscar1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(248, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 63);
            this.button2.TabIndex = 72;
            this.button2.Text = "Generadas Hoy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ConsultarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 488);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtfechato);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1update);
            this.Controls.Add(this.dtfechafrom);
            this.Controls.Add(this.tbcodigof);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btbuscar1);
            this.Controls.Add(this.btbuscar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(646, 526);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(646, 526);
            this.Name = "ConsultarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Facturas";
            this.Load += new System.EventHandler(this.ConsultarFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btbuscar;
        private System.Windows.Forms.TextBox tbcodigof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtfechafrom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridView dataGridView1update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtfechato;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btbuscar1;
        private System.Windows.Forms.Button button2;
    }
}