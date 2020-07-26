namespace SSSM
{
    partial class EditarCliente
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
            this.telefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.idcliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // telefono
            // 
            this.telefono.BackColor = System.Drawing.SystemColors.MenuText;
            this.telefono.ForeColor = System.Drawing.SystemColors.Info;
            this.telefono.Location = new System.Drawing.Point(172, 114);
            this.telefono.MaxLength = 50;
            this.telefono.Name = "telefono";
            this.telefono.Size = new System.Drawing.Size(140, 20);
            this.telefono.TabIndex = 182;
            this.telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.telefono_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(62, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 181;
            this.label5.Text = "TELEFONO";
            // 
            // idcliente
            // 
            this.idcliente.BackColor = System.Drawing.SystemColors.MenuText;
            this.idcliente.ForeColor = System.Drawing.SystemColors.Info;
            this.idcliente.Location = new System.Drawing.Point(172, 66);
            this.idcliente.MaxLength = 50;
            this.idcliente.Name = "idcliente";
            this.idcliente.Size = new System.Drawing.Size(140, 20);
            this.idcliente.TabIndex = 180;
            this.idcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idcliente_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 179;
            this.label4.Text = "NUMERO IDENTIDAD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(72, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 178;
            this.label2.Text = "NOMBRE";
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.SystemColors.MenuText;
            this.nom.ForeColor = System.Drawing.SystemColors.Info;
            this.nom.Location = new System.Drawing.Point(172, 21);
            this.nom.MaxLength = 50;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(140, 20);
            this.nom.TabIndex = 177;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(225, 165);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 176;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.YellowGreen;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(65, 165);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 42);
            this.button8.TabIndex = 175;
            this.button8.Text = "GUARDAR";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.MenuText;
            this.id.ForeColor = System.Drawing.SystemColors.Info;
            this.id.Location = new System.Drawing.Point(12, 94);
            this.id.MaxLength = 50;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(27, 20);
            this.id.TabIndex = 183;
            this.id.Visible = false;
            // 
            // EditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(330, 226);
            this.ControlBox = false;
            this.Controls.Add(this.id);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button8);
            this.Name = "EditarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button8;
        public System.Windows.Forms.TextBox telefono;
        public System.Windows.Forms.TextBox idcliente;
        public System.Windows.Forms.TextBox nom;
        public System.Windows.Forms.TextBox id;
    }
}