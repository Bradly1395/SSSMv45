namespace SSSM
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.id = new System.Windows.Forms.TextBox();
            this.estado = new System.Windows.Forms.TextBox();
            this.puesto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.EntrarB = new System.Windows.Forms.Button();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.usuariotxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.InfoText;
            this.id.ForeColor = System.Drawing.Color.Lime;
            this.id.Location = new System.Drawing.Point(12, 221);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(10, 20);
            this.id.TabIndex = 152;
            this.id.Visible = false;
            // 
            // estado
            // 
            this.estado.BackColor = System.Drawing.SystemColors.InfoText;
            this.estado.ForeColor = System.Drawing.Color.Lime;
            this.estado.Location = new System.Drawing.Point(12, 247);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(10, 20);
            this.estado.TabIndex = 151;
            this.estado.Visible = false;
            // 
            // puesto
            // 
            this.puesto.BackColor = System.Drawing.SystemColors.InfoText;
            this.puesto.ForeColor = System.Drawing.Color.Lime;
            this.puesto.Location = new System.Drawing.Point(12, 273);
            this.puesto.Name = "puesto";
            this.puesto.Size = new System.Drawing.Size(10, 20);
            this.puesto.TabIndex = 150;
            this.puesto.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(74, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 148;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EntrarB
            // 
            this.EntrarB.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.EntrarB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EntrarB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EntrarB.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EntrarB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EntrarB.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntrarB.ForeColor = System.Drawing.Color.White;
            this.EntrarB.Location = new System.Drawing.Point(74, 213);
            this.EntrarB.Name = "EntrarB";
            this.EntrarB.Size = new System.Drawing.Size(140, 28);
            this.EntrarB.TabIndex = 147;
            this.EntrarB.Text = "INGRESAR";
            this.EntrarB.UseVisualStyleBackColor = false;
            this.EntrarB.Click += new System.EventHandler(this.EntrarB_Click);
            // 
            // passwordtxt
            // 
            this.passwordtxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.passwordtxt.ForeColor = System.Drawing.Color.Lime;
            this.passwordtxt.Location = new System.Drawing.Point(74, 158);
            this.passwordtxt.MaxLength = 50;
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.ShortcutsEnabled = false;
            this.passwordtxt.Size = new System.Drawing.Size(140, 20);
            this.passwordtxt.TabIndex = 146;
            this.passwordtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordtxt_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(25, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 145;
            this.label2.Text = "Clave";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(25, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 144;
            this.label1.Text = "Usuario";
            // 
            // usuariotxt
            // 
            this.usuariotxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.usuariotxt.ForeColor = System.Drawing.SystemColors.Info;
            this.usuariotxt.Location = new System.Drawing.Point(74, 110);
            this.usuariotxt.MaxLength = 50;
            this.usuariotxt.Name = "usuariotxt";
            this.usuariotxt.ShortcutsEnabled = false;
            this.usuariotxt.Size = new System.Drawing.Size(140, 20);
            this.usuariotxt.TabIndex = 143;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 154;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(285, 310);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.estado);
            this.Controls.Add(this.puesto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EntrarB);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usuariotxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox estado;
        private System.Windows.Forms.TextBox puesto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button EntrarB;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usuariotxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}