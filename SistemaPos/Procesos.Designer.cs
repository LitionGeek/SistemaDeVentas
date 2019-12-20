namespace Sistema_Pos
{
    partial class Procesos
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
            this.SuspendLayout();
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(193, 129);
            this.BtnSalir.Size = new System.Drawing.Size(96, 22);
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click_1);
            // 
            // Procesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 277);
            this.MaximumSize = new System.Drawing.Size(540, 315);
            this.MinimumSize = new System.Drawing.Size(540, 315);
            this.Name = "Procesos";
            this.Text = "Procesos";
            this.Load += new System.EventHandler(this.Procesos_Load);
            this.ResumeLayout(false);

        }

        #endregion
    }
}