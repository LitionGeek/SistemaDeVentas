namespace Sistema_Pos
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.lblCod = new System.Windows.Forms.Label();
            this.BtnCerrarSesion = new System.Windows.Forms.Button();
            this.BtnChangePass = new System.Windows.Forms.Button();
            this.BtnPrincipal = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(423, 242);
            // 
            // lblCod
            // 
            this.lblCod.BackColor = System.Drawing.Color.Transparent;
            this.lblCod.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(141, 135);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(100, 20);
            this.lblCod.TabIndex = 23;
            // 
            // BtnCerrarSesion
            // 
            this.BtnCerrarSesion.Location = new System.Drawing.Point(392, 213);
            this.BtnCerrarSesion.Name = "BtnCerrarSesion";
            this.BtnCerrarSesion.Size = new System.Drawing.Size(106, 23);
            this.BtnCerrarSesion.TabIndex = 22;
            this.BtnCerrarSesion.Text = "Cerrar sesiòn";
            this.BtnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // BtnChangePass
            // 
            this.BtnChangePass.Location = new System.Drawing.Point(192, 213);
            this.BtnChangePass.Name = "BtnChangePass";
            this.BtnChangePass.Size = new System.Drawing.Size(119, 23);
            this.BtnChangePass.TabIndex = 21;
            this.BtnChangePass.Text = "Cambiar contraseña";
            this.BtnChangePass.UseVisualStyleBackColor = true;
            // 
            // BtnPrincipal
            // 
            this.BtnPrincipal.Location = new System.Drawing.Point(31, 213);
            this.BtnPrincipal.Name = "BtnPrincipal";
            this.BtnPrincipal.Size = new System.Drawing.Size(84, 23);
            this.BtnPrincipal.TabIndex = 19;
            this.BtnPrincipal.Text = "Principal";
            this.BtnPrincipal.UseVisualStyleBackColor = true;
            this.BtnPrincipal.Click += new System.EventHandler(this.BtnPrincipal_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(141, 90);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 20);
            this.lblUsuario.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Usuario:";
            // 
            // PictureBox
            // 
            this.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBox.Location = new System.Drawing.Point(353, 27);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(145, 148);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox.TabIndex = 16;
            this.PictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Codigo:";
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUser.Location = new System.Drawing.Point(28, 50);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(60, 16);
            this.lblNombreUser.TabIndex = 14;
            this.lblNombreUser.Text = "Nombre:";
            // 
            // lblNombre
            // 
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNombre.Location = new System.Drawing.Point(141, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 20);
            this.lblNombre.TabIndex = 13;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 277);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.BtnCerrarSesion);
            this.Controls.Add(this.BtnChangePass);
            this.Controls.Add(this.BtnPrincipal);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PictureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombreUser);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(540, 315);
            this.MinimumSize = new System.Drawing.Size(540, 315);
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.lblNombreUser, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.PictureBox, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.BtnPrincipal, 0);
            this.Controls.SetChildIndex(this.BtnChangePass, 0);
            this.Controls.SetChildIndex(this.BtnCerrarSesion, 0);
            this.Controls.SetChildIndex(this.lblCod, 0);
            this.Controls.SetChildIndex(this.BtnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button BtnCerrarSesion;
        private System.Windows.Forms.Button BtnChangePass;
        private System.Windows.Forms.Button BtnPrincipal;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.Label lblNombre;
    }
}