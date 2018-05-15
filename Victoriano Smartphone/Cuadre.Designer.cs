namespace Victoriano_Smartphone
{
    partial class Cuadre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cuadre));
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1update = new System.Windows.Forms.DataGridView();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtfechafrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btbuscar1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(260, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 63);
            this.button2.TabIndex = 85;
            this.button2.Text = "Cuadre de Hoy";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1update
            // 
            this.dataGridView1update.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1update.Enabled = false;
            this.dataGridView1update.Location = new System.Drawing.Point(23, 212);
            this.dataGridView1update.Name = "dataGridView1update";
            this.dataGridView1update.Size = new System.Drawing.Size(455, 150);
            this.dataGridView1update.TabIndex = 80;
            this.dataGridView1update.Visible = false;
            // 
            // total
            // 
            this.total.Frozen = true;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.Frozen = true;
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 150;
            // 
            // cliente
            // 
            this.cliente.Frozen = true;
            this.cliente.HeaderText = "Cliente";
            this.cliente.Name = "cliente";
            this.cliente.ReadOnly = true;
            // 
            // codigoc
            // 
            this.codigoc.Frozen = true;
            this.codigoc.HeaderText = "Codigo C";
            this.codigoc.Name = "codigoc";
            this.codigoc.ReadOnly = true;
            this.codigoc.Width = 75;
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
            // dtfechafrom
            // 
            this.dtfechafrom.CustomFormat = "";
            this.dtfechafrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtfechafrom.Location = new System.Drawing.Point(260, 22);
            this.dtfechafrom.Name = "dtfechafrom";
            this.dtfechafrom.Size = new System.Drawing.Size(95, 20);
            this.dtfechafrom.TabIndex = 78;
            this.dtfechafrom.Value = new System.DateTime(2018, 5, 15, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(119, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 74;
            this.label1.Text = "Cuadre del día:";
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(478, 317);
            this.dataGridView1.TabIndex = 79;
            // 
            // tbtotal
            // 
            this.tbtotal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tbtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbtotal.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtotal.ForeColor = System.Drawing.Color.Blue;
            this.tbtotal.Location = new System.Drawing.Point(134, 452);
            this.tbtotal.Name = "tbtotal";
            this.tbtotal.ReadOnly = true;
            this.tbtotal.Size = new System.Drawing.Size(167, 26);
            this.tbtotal.TabIndex = 87;
            this.tbtotal.Text = "RD$ 0.00";
            this.tbtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(51, 452);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 86;
            this.label4.Text = "Total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button1.BackgroundImage = global::Victoriano_Smartphone.Properties.Resources.banknotes_159085_640;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(35, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 63);
            this.button1.TabIndex = 81;
            this.button1.Text = "Contar Monedas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Victoriano_Smartphone.Properties.Resources.logo;
            this.pictureBox3.Location = new System.Drawing.Point(372, 182);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(278, 306);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            // 
            // btbuscar1
            // 
            this.btbuscar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btbuscar1.Image = global::Victoriano_Smartphone.Properties.Resources.lupa_psd_468x468;
            this.btbuscar1.Location = new System.Drawing.Point(362, 13);
            this.btbuscar1.Name = "btbuscar1";
            this.btbuscar1.Size = new System.Drawing.Size(53, 30);
            this.btbuscar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btbuscar1.TabIndex = 84;
            this.btbuscar1.TabStop = false;
            this.btbuscar1.Click += new System.EventHandler(this.btbuscar1_Click);
            // 
            // Cuadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 495);
            this.Controls.Add(this.tbtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1update);
            this.Controls.Add(this.dtfechafrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btbuscar1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(660, 533);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(660, 533);
            this.Name = "Cuadre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuadre";
            this.Load += new System.EventHandler(this.Cuadre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btbuscar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1update;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DateTimePicker dtfechafrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btbuscar1;
        private System.Windows.Forms.TextBox tbtotal;
        private System.Windows.Forms.Label label4;
    }
}