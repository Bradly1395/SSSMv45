namespace SSSM
{
    partial class CrearPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearPedido));
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.idUser = new System.Windows.Forms.TextBox();
            this.observacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.costo = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fechaL = new System.Windows.Forms.Label();
            this.horaL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.abono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saldo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.YellowGreen;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(138, 459);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 42);
            this.button8.TabIndex = 169;
            this.button8.Text = "GUARDAR";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(278, 459);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 168;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idUser
            // 
            this.idUser.BackColor = System.Drawing.SystemColors.MenuText;
            this.idUser.ForeColor = System.Drawing.SystemColors.Info;
            this.idUser.Location = new System.Drawing.Point(393, 12);
            this.idUser.MaxLength = 50;
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(10, 20);
            this.idUser.TabIndex = 185;
            this.idUser.Visible = false;
            // 
            // observacion
            // 
            this.observacion.BackColor = System.Drawing.SystemColors.MenuText;
            this.observacion.ForeColor = System.Drawing.SystemColors.Info;
            this.observacion.Location = new System.Drawing.Point(188, 380);
            this.observacion.MaxLength = 50;
            this.observacion.Multiline = true;
            this.observacion.Name = "observacion";
            this.observacion.Size = new System.Drawing.Size(192, 53);
            this.observacion.TabIndex = 204;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(86, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 203;
            this.label6.Text = "OBSERVACION";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Black;
            this.user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user.Location = new System.Drawing.Point(188, 304);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(43, 13);
            this.user.TabIndex = 200;
            this.user.Text = "Usuario";
            // 
            // costo
            // 
            this.costo.BackColor = System.Drawing.SystemColors.MenuText;
            this.costo.ForeColor = System.Drawing.SystemColors.Info;
            this.costo.Location = new System.Drawing.Point(188, 187);
            this.costo.MaxLength = 50;
            this.costo.Name = "costo";
            this.costo.Size = new System.Drawing.Size(192, 20);
            this.costo.TabIndex = 199;
            this.costo.TextChanged += new System.EventHandler(this.costo_TextChanged);
            this.costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.costo_KeyPress);
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.SystemColors.MenuText;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.ForeColor = System.Drawing.SystemColors.Info;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(188, 339);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(192, 21);
            this.cmbTipo.TabIndex = 198;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(50, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 197;
            this.label5.Text = "PERSONA ENCARGADA:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(56, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 196;
            this.label4.Text = "NOMBRE DEL CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(59, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 195;
            this.label3.Text = "COSTO DEL TRABAJO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(104, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 194;
            this.label1.Text = "ATENCION";
            // 
            // fechaL
            // 
            this.fechaL.AutoSize = true;
            this.fechaL.BackColor = System.Drawing.Color.Black;
            this.fechaL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fechaL.Location = new System.Drawing.Point(185, 71);
            this.fechaL.Name = "fechaL";
            this.fechaL.Size = new System.Drawing.Size(42, 13);
            this.fechaL.TabIndex = 193;
            this.fechaL.Text = "FECHA";
            // 
            // horaL
            // 
            this.horaL.AutoSize = true;
            this.horaL.BackColor = System.Drawing.Color.Black;
            this.horaL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.horaL.Location = new System.Drawing.Point(315, 71);
            this.horaL.Name = "horaL";
            this.horaL.Size = new System.Drawing.Size(38, 13);
            this.horaL.TabIndex = 192;
            this.horaL.Text = "HORA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(271, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 191;
            this.label2.Text = "HORA";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.text.Location = new System.Drawing.Point(121, 21);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(266, 25);
            this.text.TabIndex = 190;
            this.text.Text = "TRABAJO ENCARGADO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 189;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(124, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 188;
            this.label8.Text = "FECHA";
            // 
            // abono
            // 
            this.abono.BackColor = System.Drawing.SystemColors.MenuText;
            this.abono.ForeColor = System.Drawing.SystemColors.Info;
            this.abono.Location = new System.Drawing.Point(188, 225);
            this.abono.MaxLength = 50;
            this.abono.Name = "abono";
            this.abono.Size = new System.Drawing.Size(192, 20);
            this.abono.TabIndex = 206;
            this.abono.TextChanged += new System.EventHandler(this.abono_TextChanged);
            this.abono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.abono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(134, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 205;
            this.label7.Text = "ABONO:";
            // 
            // nombre
            // 
            this.nombre.BackColor = System.Drawing.SystemColors.MenuText;
            this.nombre.ForeColor = System.Drawing.SystemColors.Info;
            this.nombre.Location = new System.Drawing.Point(188, 111);
            this.nombre.MaxLength = 50;
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(192, 20);
            this.nombre.TabIndex = 207;
            // 
            // telefono
            // 
            this.telefono.BackColor = System.Drawing.SystemColors.MenuText;
            this.telefono.ForeColor = System.Drawing.SystemColors.Info;
            this.telefono.Location = new System.Drawing.Point(188, 149);
            this.telefono.MaxLength = 50;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(192, 20);
            this.telefono.TabIndex = 209;
            this.telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(86, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 208;
            this.label9.Text = "NUMERO DE TEL:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(134, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 210;
            this.label10.Text = "SALDO:";
            // 
            // saldo
            // 
            this.saldo.AutoSize = true;
            this.saldo.BackColor = System.Drawing.Color.Black;
            this.saldo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.saldo.Location = new System.Drawing.Point(188, 266);
            this.saldo.Name = "saldo";
            this.saldo.Size = new System.Drawing.Size(28, 13);
            this.saldo.TabIndex = 211;
            this.saldo.Text = "0.00";
            // 
            // CrearPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(419, 513);
            this.ControlBox = false;
            this.Controls.Add(this.saldo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.abono);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.observacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.user);
            this.Controls.Add(this.costo);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaL);
            this.Controls.Add(this.horaL);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.idUser);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CrearPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrearEncargo";
            this.Load += new System.EventHandler(this.CrearPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox idUser;
        private System.Windows.Forms.TextBox observacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.TextBox costo;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fechaL;
        private System.Windows.Forms.Label horaL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox abono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label saldo;
    }
}