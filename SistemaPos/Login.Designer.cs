namespace Sistema_Pos
{
    partial class IniciarSesion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesion));
            this.BtnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.ChkMostrar = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(212, 452);
            this.BtnSalir.Size = new System.Drawing.Size(245, 23);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLogin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.Location = new System.Drawing.Point(212, 376);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(245, 65);
            this.BtnLogin.TabIndex = 3;
            this.BtnLogin.Text = "Iniciar Sesion";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(175, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Sistema_Pos.Properties.Resources.login_png_12;
            this.pictureBox1.Location = new System.Drawing.Point(237, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(260, 301);
            this.TxtPass.Multiline = true;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(153, 25);
            this.TxtPass.TabIndex = 1;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(260, 254);
            this.TxtUser.Multiline = true;
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(153, 25);
            this.TxtUser.TabIndex = 0;
            this.TxtUser.TextChanged += new System.EventHandler(this.TxtUser_TextChanged);
            // 
            // ChkMostrar
            // 
            this.ChkMostrar.AutoSize = true;
            this.ChkMostrar.BackColor = System.Drawing.Color.Transparent;
            this.ChkMostrar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkMostrar.Location = new System.Drawing.Point(441, 308);
            this.ChkMostrar.Name = "ChkMostrar";
            this.ChkMostrar.Size = new System.Drawing.Size(68, 19);
            this.ChkMostrar.TabIndex = 2;
            this.ChkMostrar.Text = "Mostrar";
            this.ChkMostrar.UseVisualStyleBackColor = false;
            this.ChkMostrar.CheckedChanged += new System.EventHandler(this.ChkMostrar_CheckedChanged);
            // 
            // IniciarSesion
            // 
            this.AcceptButton = this.BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(594, 487);
            this.Controls.Add(this.ChkMostrar);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogin);
            this.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(610, 525);
            this.MinimumSize = new System.Drawing.Size(610, 525);
            this.Name = "IniciarSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IniciarSesion";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Controls.SetChildIndex(this.BtnLogin, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.TxtPass, 0);
            this.Controls.SetChildIndex(this.TxtUser, 0);
            this.Controls.SetChildIndex(this.ChkMostrar, 0);
            this.Controls.SetChildIndex(this.BtnSalir, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.CheckBox ChkMostrar;
    }
}

