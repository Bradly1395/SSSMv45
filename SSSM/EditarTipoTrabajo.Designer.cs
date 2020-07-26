namespace SSSM
{
    partial class EditarTipoTrabajo
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
            this.precio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // precio
            // 
            this.precio.BackColor = System.Drawing.SystemColors.MenuText;
            this.precio.ForeColor = System.Drawing.SystemColors.Info;
            this.precio.Location = new System.Drawing.Point(119, 78);
            this.precio.MaxLength = 50;
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(140, 20);
            this.precio.TabIndex = 188;
            this.precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precio_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(40, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 187;
            this.label5.Text = "PRECIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 186;
            this.label2.Text = "DESCRIPCION";
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.SystemColors.MenuText;
            this.nom.ForeColor = System.Drawing.SystemColors.Info;
            this.nom.Location = new System.Drawing.Point(119, 32);
            this.nom.MaxLength = 50;
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(140, 20);
            this.nom.TabIndex = 185;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(184, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 184;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.YellowGreen;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guardar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guardar.Location = new System.Drawing.Point(24, 124);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 42);
            this.guardar.TabIndex = 183;
            this.guardar.Text = "GUARDAR";
            this.guardar.UseVisualStyleBackColor = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.MenuText;
            this.id.ForeColor = System.Drawing.SystemColors.Info;
            this.id.Location = new System.Drawing.Point(133, 124);
            this.id.MaxLength = 50;
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(27, 20);
            this.id.TabIndex = 189;
            this.id.Visible = false;
            // 
            // EditarTipoTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 198);
            this.ControlBox = false;
            this.Controls.Add(this.id);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.guardar);
            this.Name = "EditarTipoTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarTipoTrabajo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button guardar;
        public System.Windows.Forms.TextBox id;
        public System.Windows.Forms.TextBox precio;
        public System.Windows.Forms.TextBox nom;
    }
}