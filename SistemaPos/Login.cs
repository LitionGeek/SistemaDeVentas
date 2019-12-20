using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaDLL;


namespace Sistema_Pos
{
    public partial class IniciarSesion : Base
    {
        public IniciarSesion()
        {
            InitializeComponent();
        }

        public static string Codigo = "";

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            
            Administrador admin = new Administrador();
            Usuario user = new Usuario();
            IniciarSesion login = new IniciarSesion();

            try
            {
                string validar = string.Format("Select * from Usuarios where username ='{0}' AND password='{1}'", TxtUser.Text.Trim(),TxtPass.Text.Trim());
                DataSet conectar = Biblioteca.Validaciones(validar);

                Codigo = conectar.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                string cuenta = conectar.Tables[0].Rows[0]["username"].ToString().Trim();
                string pass = conectar.Tables[0].Rows[0]["password"].ToString().Trim();

                if(cuenta == TxtUser.Text.Trim() && pass == TxtPass.Text.Trim())
                {
                    MessageBox.Show("Se inicio sesion Correctamente!");
                    this.Hide();

                    if(Convert.ToBoolean(conectar.Tables[0].Rows[0]["IsAdmin"].ToString().Trim()) == true)
                    {
                        admin.Show();
                    }
                    else
                    {                  
                        user.Show();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Usuario o contraseña invalidos!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ChkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkMostrar.Checked== true)
            {
                if(TxtPass.PasswordChar=='*')
                {
                    TxtPass.PasswordChar = '\0';
                }
            }
            else
            {
                TxtPass.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BntSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
