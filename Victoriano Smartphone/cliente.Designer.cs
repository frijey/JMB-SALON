namespace Victoriano_Smartphone
{
    partial class cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cliente));
            this.tbcsearchcode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbccodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbcnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbcapellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbccedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbctelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btcsave = new System.Windows.Forms.Button();
            this.btcdelete = new System.Windows.Forms.Button();
            this.tbcdireccion = new System.Windows.Forms.TextBox();
            this.btcnew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btcsearch = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcsearchcode
            // 
            this.tbcsearchcode.Font = new System.Drawing.Font("Modern No. 20", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbcsearchcode.Location = new System.Drawing.Point(394, 34);
            this.tbcsearchcode.Name = "tbcsearchcode";
            this.tbcsearchcode.Size = new System.Drawing.Size(172, 32);
            this.tbcsearchcode.TabIndex = 0;
            this.tbcsearchcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbcsearchcode_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(78, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Buscar Cliente por Código";
            // 
            // tbccodigo
            // 
            this.tbccodigo.Enabled = false;
            this.tbccodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbccodigo.Location = new System.Drawing.Point(193, 90);
            this.tbccodigo.Name = "tbccodigo";
            this.tbccodigo.Size = new System.Drawing.Size(90, 23);
            this.tbccodigo.TabIndex = 1;
            this.tbccodigo.Text = "1";
            this.tbccodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbccodigo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(111, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Código";
            // 
            // tbcnombre
            // 
            this.tbcnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbcnombre.Location = new System.Drawing.Point(193, 133);
            this.tbcnombre.Name = "tbcnombre";
            this.tbcnombre.Size = new System.Drawing.Size(141, 23);
            this.tbcnombre.TabIndex = 2;
            this.tbcnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbccodigo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(98, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            // 
            // tbcapellidos
            // 
            this.tbcapellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbcapellidos.Location = new System.Drawing.Point(193, 178);
            this.tbcapellidos.Name = "tbcapellidos";
            this.tbcapellidos.Size = new System.Drawing.Size(169, 23);
            this.tbcapellidos.TabIndex = 3;
            this.tbcapellidos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbccodigo_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(86, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Apellidos";
            // 
            // tbccedula
            // 
            this.tbccedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbccedula.Location = new System.Drawing.Point(193, 220);
            this.tbccedula.Name = "tbccedula";
            this.tbccedula.Size = new System.Drawing.Size(139, 23);
            this.tbccedula.TabIndex = 4;
            this.tbccedula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbccodigo_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(56, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Cédula/RNC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(85, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Dirección";
            // 
            // tbctelefono
            // 
            this.tbctelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbctelefono.Location = new System.Drawing.Point(193, 261);
            this.tbctelefono.Name = "tbctelefono";
            this.tbctelefono.Size = new System.Drawing.Size(141, 23);
            this.tbctelefono.TabIndex = 5;
            this.tbctelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbccodigo_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(93, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "Teléfono";
            // 
            // btcsave
            // 
            this.btcsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btcsave.Location = new System.Drawing.Point(117, 339);
            this.btcsave.Name = "btcsave";
            this.btcsave.Size = new System.Drawing.Size(93, 38);
            this.btcsave.TabIndex = 7;
            this.btcsave.Text = "Guardar";
            this.btcsave.UseVisualStyleBackColor = true;
            this.btcsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btcdelete
            // 
            this.btcdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btcdelete.Location = new System.Drawing.Point(242, 339);
            this.btcdelete.Name = "btcdelete";
            this.btcdelete.Size = new System.Drawing.Size(93, 38);
            this.btcdelete.TabIndex = 8;
            this.btcdelete.Text = "Eliminar";
            this.btcdelete.UseVisualStyleBackColor = true;
            this.btcdelete.Click += new System.EventHandler(this.btcdelete_Click);
            // 
            // tbcdireccion
            // 
            this.tbcdireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.tbcdireccion.Location = new System.Drawing.Point(193, 300);
            this.tbcdireccion.Name = "tbcdireccion";
            this.tbcdireccion.Size = new System.Drawing.Size(242, 23);
            this.tbcdireccion.TabIndex = 6;
            this.tbcdireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbccodigo_KeyDown);
            // 
            // btcnew
            // 
            this.btcnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcnew.Location = new System.Drawing.Point(172, 383);
            this.btcnew.Name = "btcnew";
            this.btcnew.Size = new System.Drawing.Size(114, 34);
            this.btcnew.TabIndex = 9;
            this.btcnew.Text = "Nuevo";
            this.btcnew.UseVisualStyleBackColor = true;
            this.btcnew.Click += new System.EventHandler(this.btcnew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(358, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 150);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.Visible = false;
            // 
            // btcsearch
            // 
            this.btcsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btcsearch.Image = global::Victoriano_Smartphone.Properties.Resources.lupa_psd_468x468;
            this.btcsearch.Location = new System.Drawing.Point(572, 23);
            this.btcsearch.Name = "btcsearch";
            this.btcsearch.Size = new System.Drawing.Size(62, 62);
            this.btcsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btcsearch.TabIndex = 9;
            this.btcsearch.TabStop = false;
            this.btcsearch.Click += new System.EventHandler(this.btcsearch_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Victoriano_Smartphone.Properties.Resources.ED_1_Trans;
            this.pictureBox2.Location = new System.Drawing.Point(373, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(346, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Victoriano_Smartphone.Properties.Resources._2bck_trans2;
            this.pictureBox5.Location = new System.Drawing.Point(257, 344);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(462, 199);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::Victoriano_Smartphone.Properties.Resources.Women;
            this.pictureBox3.Location = new System.Drawing.Point(22, 353);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(129, 172);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 537);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btcnew);
            this.Controls.Add(this.tbcdireccion);
            this.Controls.Add(this.btcdelete);
            this.Controls.Add(this.btcsave);
            this.Controls.Add(this.tbctelefono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbccedula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbcapellidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbcnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbccodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btcsearch);
            this.Controls.Add(this.tbcsearchcode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(732, 575);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(732, 575);
            this.Name = "cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btcsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbcsearchcode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbccodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btcsearch;
        private System.Windows.Forms.TextBox tbcnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbcapellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbccedula;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbctelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btcsave;
        private System.Windows.Forms.Button btcdelete;
        private System.Windows.Forms.TextBox tbcdireccion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btcnew;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}