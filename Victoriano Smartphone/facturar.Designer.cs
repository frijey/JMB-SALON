namespace Victoriano_Smartphone
{
    partial class facturar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(facturar));
            this.btnguardar = new System.Windows.Forms.Button();
            this.dataGridView1detalle = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbnumfactura = new System.Windows.Forms.Label();
            this.lbfecha = new System.Windows.Forms.Label();
            this.btnimprimir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbidcliente = new System.Windows.Forms.TextBox();
            this.lbidcliente = new System.Windows.Forms.Label();
            this.tbcliente = new System.Windows.Forms.TextBox();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkbcontado = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.printfactura = new System.Drawing.Printing.PrintDocument();
            this.chkbcredito = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btneliminiar = new System.Windows.Forms.Button();
            this.logoinf = new System.Windows.Forms.PictureBox();
            this.logo = new System.Windows.Forms.PictureBox();
            this.ptbcliente = new System.Windows.Forms.PictureBox();
            this.btnsearch = new System.Windows.Forms.PictureBox();
            this.btbuscar = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.ptbcanasto = new System.Windows.Forms.PictureBox();
            this.ptbcarro = new System.Windows.Forms.PictureBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoinf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcanasto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcarro)).BeginInit();
            this.SuspendLayout();
            // 
            // btnguardar
            // 
            this.btnguardar.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnguardar.Location = new System.Drawing.Point(8, 384);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(158, 72);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "GUARDAR";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btmodificar_Click);
            // 
            // dataGridView1detalle
            // 
            this.dataGridView1detalle.AllowUserToAddRows = false;
            this.dataGridView1detalle.AllowUserToDeleteRows = false;
            this.dataGridView1detalle.AllowUserToResizeColumns = false;
            this.dataGridView1detalle.AllowUserToResizeRows = false;
            this.dataGridView1detalle.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1detalle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1detalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombre,
            this.cantidad,
            this.precio,
            this.total});
            this.dataGridView1detalle.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1detalle.Name = "dataGridView1detalle";
            this.dataGridView1detalle.RowHeadersVisible = false;
            this.dataGridView1detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1detalle.Size = new System.Drawing.Size(455, 317);
            this.dataGridView1detalle.TabIndex = 1;
            this.dataGridView1detalle.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1detalle_CellValueChanged);
            this.dataGridView1detalle.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1detalle_DataError);
            this.dataGridView1detalle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1detalle_KeyDown);
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
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 180;
            // 
            // cantidad
            // 
            this.cantidad.Frozen = true;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.MaxInputLength = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 60;
            // 
            // precio
            // 
            this.precio.Frozen = true;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.Width = 70;
            // 
            // total
            // 
            this.total.Frozen = true;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // tbproducto
            // 
            this.tbproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbproducto.Location = new System.Drawing.Point(292, 22);
            this.tbproducto.Name = "tbproducto";
            this.tbproducto.Size = new System.Drawing.Size(187, 22);
            this.tbproducto.TabIndex = 0;
            this.tbproducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbproducto_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 49;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(486, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 51;
            this.label2.Text = "Cliente";
            // 
            // lbnumfactura
            // 
            this.lbnumfactura.AutoSize = true;
            this.lbnumfactura.Font = new System.Drawing.Font("Goudy Old Style", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbnumfactura.Location = new System.Drawing.Point(601, 20);
            this.lbnumfactura.Name = "lbnumfactura";
            this.lbnumfactura.Size = new System.Drawing.Size(101, 21);
            this.lbnumfactura.TabIndex = 63;
            this.lbnumfactura.Text = "No. Factura: ";
            // 
            // lbfecha
            // 
            this.lbfecha.AutoSize = true;
            this.lbfecha.Font = new System.Drawing.Font("Goudy Old Style", 12.75F, System.Drawing.FontStyle.Bold);
            this.lbfecha.Location = new System.Drawing.Point(688, 0);
            this.lbfecha.Name = "lbfecha";
            this.lbfecha.Size = new System.Drawing.Size(96, 21);
            this.lbfecha.TabIndex = 62;
            this.lbfecha.Text = "00/00/0000";
            // 
            // btnimprimir
            // 
            this.btnimprimir.Enabled = false;
            this.btnimprimir.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.Blue;
            this.btnimprimir.Location = new System.Drawing.Point(172, 384);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Size = new System.Drawing.Size(137, 29);
            this.btnimprimir.TabIndex = 6;
            this.btnimprimir.Text = "IMPRIMIR";
            this.btnimprimir.UseVisualStyleBackColor = true;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(455, 150);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.Visible = false;
            // 
            // tbidcliente
            // 
            this.tbidcliente.Enabled = false;
            this.tbidcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbidcliente.Location = new System.Drawing.Point(560, 124);
            this.tbidcliente.Name = "tbidcliente";
            this.tbidcliente.Size = new System.Drawing.Size(83, 22);
            this.tbidcliente.TabIndex = 67;
            this.tbidcliente.Visible = false;
            // 
            // lbidcliente
            // 
            this.lbidcliente.AutoSize = true;
            this.lbidcliente.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbidcliente.Location = new System.Drawing.Point(530, 123);
            this.lbidcliente.Name = "lbidcliente";
            this.lbidcliente.Size = new System.Drawing.Size(27, 23);
            this.lbidcliente.TabIndex = 68;
            this.lbidcliente.Text = "Id";
            this.lbidcliente.Visible = false;
            // 
            // tbcliente
            // 
            this.tbcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcliente.Location = new System.Drawing.Point(560, 96);
            this.tbcliente.Name = "tbcliente";
            this.tbcliente.Size = new System.Drawing.Size(167, 22);
            this.tbcliente.TabIndex = 69;
            // 
            // tbtotal
            // 
            this.tbtotal.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotal.ForeColor = System.Drawing.Color.Blue;
            this.tbtotal.Location = new System.Drawing.Point(593, 284);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.ReadOnly = true;
            this.tbtotal.Size = new System.Drawing.Size(167, 26);
            this.tbtotal.TabIndex = 73;
            this.tbtotal.Text = "RD$ 0.00";
            this.tbtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbtotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbtotal_KeyDown);
            this.tbtotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbtotal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(527, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 72;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 74;
            this.label5.Text = "Contado";
            // 
            // chkbcontado
            // 
            this.chkbcontado.AutoSize = true;
            this.chkbcontado.Checked = true;
            this.chkbcontado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbcontado.Location = new System.Drawing.Point(572, 62);
            this.chkbcontado.Name = "chkbcontado";
            this.chkbcontado.Size = new System.Drawing.Size(15, 14);
            this.chkbcontado.TabIndex = 4;
            this.chkbcontado.UseVisualStyleBackColor = true;
            this.chkbcontado.CheckedChanged += new System.EventHandler(this.chkbcontado_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(609, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 19);
            this.label6.TabIndex = 76;
            this.label6.Text = "Crédito";
            // 
            // printfactura
            // 
            this.printfactura.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtmain_PrintPage);
            // 
            // chkbcredito
            // 
            this.chkbcredito.AutoSize = true;
            this.chkbcredito.Location = new System.Drawing.Point(679, 62);
            this.chkbcredito.Name = "chkbcredito";
            this.chkbcredito.Size = new System.Drawing.Size(15, 14);
            this.chkbcredito.TabIndex = 5;
            this.chkbcredito.UseVisualStyleBackColor = true;
            this.chkbcredito.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(172, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Nueva Factura";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btneliminiar
            // 
            this.btneliminiar.Font = new System.Drawing.Font("Impact", 18.25F);
            this.btneliminiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btneliminiar.Location = new System.Drawing.Point(315, 384);
            this.btneliminiar.Name = "btneliminiar";
            this.btneliminiar.Size = new System.Drawing.Size(158, 72);
            this.btneliminiar.TabIndex = 3;
            this.btneliminiar.Text = "ELIMINAR PRODUCTO";
            this.btneliminiar.UseVisualStyleBackColor = true;
            this.btneliminiar.Click += new System.EventHandler(this.button2_Click);
            // 
            // logoinf
            // 
            this.logoinf.Image = global::Victoriano_Smartphone.Properties.Resources.New_info_Bar_2;
            this.logoinf.Location = new System.Drawing.Point(560, 403);
            this.logoinf.Name = "logoinf";
            this.logoinf.Size = new System.Drawing.Size(167, 50);
            this.logoinf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoinf.TabIndex = 81;
            this.logoinf.TabStop = false;
            this.logoinf.Visible = false;
            // 
            // logo
            // 
            this.logo.Image = global::Victoriano_Smartphone.Properties.Resources.new_VIC;
            this.logo.Location = new System.Drawing.Point(560, 347);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(167, 50);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 80;
            this.logo.TabStop = false;
            this.logo.Visible = false;
            // 
            // ptbcliente
            // 
            this.ptbcliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbcliente.Image = global::Victoriano_Smartphone.Properties.Resources.person_user_customer_man_male_man_boy_people_1687;
            this.ptbcliente.Location = new System.Drawing.Point(730, 88);
            this.ptbcliente.Name = "ptbcliente";
            this.ptbcliente.Size = new System.Drawing.Size(46, 51);
            this.ptbcliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbcliente.TabIndex = 71;
            this.ptbcliente.TabStop = false;
            this.ptbcliente.Click += new System.EventHandler(this.ptbcliente_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsearch.Image = global::Victoriano_Smartphone.Properties.Resources.lupa_psd_468x468;
            this.btnsearch.Location = new System.Drawing.Point(730, 88);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(43, 38);
            this.btnsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnsearch.TabIndex = 70;
            this.btnsearch.TabStop = false;
            this.btnsearch.Visible = false;
            this.btnsearch.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btbuscar
            // 
            this.btbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbuscar.Image = global::Victoriano_Smartphone.Properties.Resources.lupa_psd_468x468;
            this.btbuscar.Location = new System.Drawing.Point(475, 14);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(55, 36);
            this.btbuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btbuscar.TabIndex = 39;
            this.btbuscar.TabStop = false;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Victoriano_Smartphone.Properties.Resources._2bck_trans2;
            this.pictureBox5.Location = new System.Drawing.Point(319, 274);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(462, 199);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            // 
            // ptbcanasto
            // 
            this.ptbcanasto.Image = global::Victoriano_Smartphone.Properties.Resources.shopping_cart_green;
            this.ptbcanasto.Location = new System.Drawing.Point(514, 137);
            this.ptbcanasto.Name = "ptbcanasto";
            this.ptbcanasto.Size = new System.Drawing.Size(107, 99);
            this.ptbcanasto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbcanasto.TabIndex = 78;
            this.ptbcanasto.TabStop = false;
            // 
            // ptbcarro
            // 
            this.ptbcarro.Image = global::Victoriano_Smartphone.Properties.Resources.shopping_cart_md__1_;
            this.ptbcarro.Location = new System.Drawing.Point(656, 158);
            this.ptbcarro.Name = "ptbcarro";
            this.ptbcarro.Size = new System.Drawing.Size(104, 76);
            this.ptbcarro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbcarro.TabIndex = 79;
            this.ptbcarro.TabStop = false;
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printfactura;
            this.printDialog1.UseEXDialog = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Script MT Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(18, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 44);
            this.label11.TabIndex = 117;
            this.label11.Text = "Facturar";
            // 
            // facturar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 466);
            this.Controls.Add(this.logoinf);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btneliminiar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkbcredito);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkbcontado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbcliente);
            this.Controls.Add(this.ptbcliente);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.lbidcliente);
            this.Controls.Add(this.tbidcliente);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.lbnumfactura);
            this.Controls.Add(this.lbfecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.tbproducto);
            this.Controls.Add(this.dataGridView1detalle);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.ptbcanasto);
            this.Controls.Add(this.ptbcarro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.label11);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(795, 504);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(795, 504);
            this.Name = "facturar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "facturar";
            this.Load += new System.EventHandler(this.facturar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoinf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcanasto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbcarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.PictureBox btbuscar;
        private System.Windows.Forms.DataGridView dataGridView1detalle;
        private System.Windows.Forms.TextBox tbproducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbnumfactura;
        private System.Windows.Forms.Label lbfecha;
        private System.Windows.Forms.Button btnimprimir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbidcliente;
        private System.Windows.Forms.Label lbidcliente;
        private System.Windows.Forms.TextBox tbcliente;
        private System.Windows.Forms.PictureBox btnsearch;
        private System.Windows.Forms.PictureBox ptbcliente;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkbcontado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox ptbcanasto;
        private System.Windows.Forms.PictureBox ptbcarro;
        private System.Windows.Forms.PictureBox logoinfo;
        private System.Windows.Forms.PrintPreviewControl vista;
        private System.Drawing.Printing.PrintDocument printfactura;
        private System.Windows.Forms.CheckBox chkbcredito;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btneliminiar;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.PictureBox logoinf;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label11;
    }
}