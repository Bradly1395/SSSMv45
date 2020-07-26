namespace SSSM
{
    partial class EditarTrabajo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarTrabajo));
            this.descripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.valor = new System.Windows.Forms.TextBox();
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
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cliente = new System.Windows.Forms.Label();
            this.atencion = new System.Windows.Forms.Label();
            this.txtlink = new System.Windows.Forms.TextBox();
            this.link = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // descripcion
            // 
            this.descripcion.BackColor = System.Drawing.SystemColors.MenuText;
            this.descripcion.ForeColor = System.Drawing.SystemColors.Info;
            this.descripcion.Location = new System.Drawing.Point(191, 200);
            this.descripcion.MaxLength = 50;
            this.descripcion.Multiline = true;
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(192, 53);
            this.descripcion.TabIndex = 206;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(89, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 205;
            this.label6.Text = "DESCRIPCION";
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.MenuText;
            this.id.ForeColor = System.Drawing.SystemColors.Info;
            this.id.Location = new System.Drawing.Point(299, 77);
            this.id.MaxLength = 50;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(32, 20);
            this.id.TabIndex = 203;
            this.id.Visible = false;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Black;
            this.user.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.user.Location = new System.Drawing.Point(188, 355);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(43, 13);
            this.user.TabIndex = 202;
            this.user.Text = "Usuario";
            // 
            // valor
            // 
            this.valor.BackColor = System.Drawing.SystemColors.MenuText;
            this.valor.ForeColor = System.Drawing.SystemColors.Info;
            this.valor.Location = new System.Drawing.Point(191, 262);
            this.valor.MaxLength = 50;
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(192, 20);
            this.valor.TabIndex = 201;
            this.valor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.valor_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(77, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 199;
            this.label5.Text = "ATENDIDO POR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(117, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 198;
            this.label4.Text = "CLIENTE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(126, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 197;
            this.label3.Text = "VALOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(107, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 196;
            this.label1.Text = "ATENCION";
            // 
            // fechaL
            // 
            this.fechaL.AutoSize = true;
            this.fechaL.BackColor = System.Drawing.Color.Black;
            this.fechaL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fechaL.Location = new System.Drawing.Point(188, 84);
            this.fechaL.Name = "fechaL";
            this.fechaL.Size = new System.Drawing.Size(42, 13);
            this.fechaL.TabIndex = 195;
            this.fechaL.Text = "FECHA";
            // 
            // horaL
            // 
            this.horaL.AutoSize = true;
            this.horaL.BackColor = System.Drawing.Color.Black;
            this.horaL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.horaL.Location = new System.Drawing.Point(188, 123);
            this.horaL.Name = "horaL";
            this.horaL.Size = new System.Drawing.Size(38, 13);
            this.horaL.TabIndex = 194;
            this.horaL.Text = "HORA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(131, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 193;
            this.label2.Text = "HORA";
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.text.Location = new System.Drawing.Point(87, 9);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(296, 25);
            this.text.TabIndex = 192;
            this.text.Text = "Terminar Orden de Trabajo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 191;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(127, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 190;
            this.label8.Text = "FECHA";
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.YellowGreen;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(120, 398);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 42);
            this.button8.TabIndex = 189;
            this.button8.Text = "GUARDAR";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(256, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 188;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.BackColor = System.Drawing.Color.Black;
            this.cliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cliente.Location = new System.Drawing.Point(188, 329);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(39, 13);
            this.cliente.TabIndex = 207;
            this.cliente.Text = "Cliente";
            // 
            // atencion
            // 
            this.atencion.AutoSize = true;
            this.atencion.BackColor = System.Drawing.Color.Black;
            this.atencion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.atencion.Location = new System.Drawing.Point(188, 162);
            this.atencion.Name = "atencion";
            this.atencion.Size = new System.Drawing.Size(49, 13);
            this.atencion.TabIndex = 208;
            this.atencion.Text = "Atencion";
            // 
            // txtlink
            // 
            this.txtlink.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtlink.ForeColor = System.Drawing.SystemColors.Info;
            this.txtlink.Location = new System.Drawing.Point(191, 293);
            this.txtlink.MaxLength = 50;
            this.txtlink.Name = "txtlink";
            this.txtlink.Size = new System.Drawing.Size(192, 20);
            this.txtlink.TabIndex = 210;
            this.txtlink.Text = "-";
            // 
            // link
            // 
            this.link.AutoSize = true;
            this.link.BackColor = System.Drawing.Color.Black;
            this.link.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.link.Location = new System.Drawing.Point(126, 300);
            this.link.Name = "link";
            this.link.Size = new System.Drawing.Size(31, 13);
            this.link.TabIndex = 209;
            this.link.Text = "LINK";
            // 
            // EditarTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(402, 452);
            this.ControlBox = false;
            this.Controls.Add(this.txtlink);
            this.Controls.Add(this.link);
            this.Controls.Add(this.atencion);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.id);
            this.Controls.Add(this.user);
            this.Controls.Add(this.valor);
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
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button3);
            this.Name = "EditarTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarTrabajo";
            this.Load += new System.EventHandler(this.EditarTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox descripcion;
        public System.Windows.Forms.Label user;
        public System.Windows.Forms.TextBox valor;
        public System.Windows.Forms.Label fechaL;
        public System.Windows.Forms.Label horaL;
        public System.Windows.Forms.Label cliente;
        public System.Windows.Forms.Label atencion;
        public System.Windows.Forms.TextBox txtlink;
        private System.Windows.Forms.Label link;
    }
}