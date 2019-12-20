using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDLL;

namespace Sistema_Pos
{
    public partial class Usuario : Base
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            string Consulta = "SELECT * FROM Usuarios WHERE id_usuario=" + IniciarSesion.Codigo;
            DataSet data = Biblioteca.Validaciones(Consulta);

            lblNombre.Text = data.Tables[0].Rows[0]["IsAdmin"].ToString();
            lblUsuario.Text = data.Tables[0].Rows[0]["username"].ToString();
            lblCod.Text = data.Tables[0].Rows[0]["id_usuario"].ToString();

            string imagen = data.Tables[0].Rows[0]["imagen"].ToString();
            PictureBox.Image = Image.FromFile(imagen);

        }

        private void BtnPrincipal_Click(object sender, EventArgs e)
        {
            Contenedor contenedor = new Contenedor();
            this.Hide();
            contenedor.Show();
        }
    }
}
