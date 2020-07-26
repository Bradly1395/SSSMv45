namespace SSSM
{
    partial class Trabajos
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
            this.gridTrabajos = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.idUser = new System.Windows.Forms.TextBox();
            this.botonEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridTrabajos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridTrabajos
            // 
            this.gridTrabajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTrabajos.Location = new System.Drawing.Point(12, 81);
            this.gridTrabajos.Name = "gridTrabajos";
            this.gridTrabajos.ReadOnly = true;
            this.gridTrabajos.Size = new System.Drawing.Size(1047, 434);
            this.gridTrabajos.TabIndex = 152;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.OrangeRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(984, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 42);
            this.button3.TabIndex = 153;
            this.button3.Text = "Volver";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // idUser
            // 
            this.idUser.BackColor = System.Drawing.SystemColors.MenuText;
            this.idUser.ForeColor = System.Drawing.SystemColors.Info;
            this.idUser.Location = new System.Drawing.Point(539, 24);
            this.idUser.MaxLength = 50;
            this.idUser.Name = "idUser";
            this.idUser.Size = new System.Drawing.Size(32, 20);
            this.idUser.TabIndex = 185;
            this.idUser.Visible = false;
            // 
            // botonEditar
            // 
            this.botonEditar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.botonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonEditar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.botonEditar.Location = new System.Drawing.Point(874, 11);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(75, 43);
            this.botonEditar.TabIndex = 186;
            this.botonEditar.Text = "EDITAR";
            this.botonEditar.UseVisualStyleBackColor = false;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // Trabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1071, 527);
            this.ControlBox = false;
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.idUser);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.gridTrabajos);
            this.Name = "Trabajos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajos";
            this.Load += new System.EventHandler(this.Trabajos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridTrabajos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridTrabajos;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox idUser;
        private System.Windows.Forms.Button botonEditar;
    }
}