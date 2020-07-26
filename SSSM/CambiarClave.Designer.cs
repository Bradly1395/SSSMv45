namespace SSSM
{
    partial class CambiarClave
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
            this.iduser = new System.Windows.Forms.TextBox();
            this.EntrarB = new System.Windows.Forms.Button();
            this.conftxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clavetxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iduser
            // 
            this.iduser.BackColor = System.Drawing.SystemColors.InfoText;
            this.iduser.ForeColor = System.Drawing.Color.Lime;
            this.iduser.Location = new System.Drawing.Point(265, 39);
            this.iduser.Name = "iduser";
            this.iduser.Size = new System.Drawing.Size(10, 20);
            this.iduser.TabIndex = 29;
            this.iduser.Visible = false;
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
            this.EntrarB.Location = new System.Drawing.Point(72, 198);
            this.EntrarB.Name = "EntrarB";
            this.EntrarB.Size = new System.Drawing.Size(140, 28);
            this.EntrarB.TabIndex = 28;
            this.EntrarB.Text = "INGRESAR";
            this.EntrarB.UseVisualStyleBackColor = false;
            this.EntrarB.Click += new System.EventHandler(this.EntrarB_Click);
            // 
            // conftxt
            // 
            this.conftxt.BackColor = System.Drawing.SystemColors.InfoText;
            this.conftxt.ForeColor = System.Drawing.Color.Lime;
            this.conftxt.Location = new System.Drawing.Point(72, 137);
            this.conftxt.MaxLength = 50;
            this.conftxt.Name = "conftxt";
            this.conftxt.PasswordChar = '*';
            this.conftxt.Size = new System.Drawing.Size(140, 20);
            this.conftxt.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Confirmar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Clave";
            // 
            // clavetxt
            // 
            this.clavetxt.BackColor = System.Drawing.SystemColors.MenuText;
            this.clavetxt.ForeColor = System.Drawing.SystemColors.Info;
            this.clavetxt.Location = new System.Drawing.Point(72, 101);
            this.clavetxt.MaxLength = 50;
            this.clavetxt.Name = "clavetxt";
            this.clavetxt.PasswordChar = '*';
            this.clavetxt.Size = new System.Drawing.Size(140, 20);
            this.clavetxt.TabIndex = 24;
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
            this.button1.Location = new System.Drawing.Point(72, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 28);
            this.button1.TabIndex = 30;
            this.button1.Text = "CANCELAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(32, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Cambiar Contraseña";
            // 
            // CambiarClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(287, 308);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.iduser);
            this.Controls.Add(this.EntrarB);
            this.Controls.Add(this.conftxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clavetxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarClave";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox iduser;
        private System.Windows.Forms.Button EntrarB;
        private System.Windows.Forms.TextBox conftxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox clavetxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}