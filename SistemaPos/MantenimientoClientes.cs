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
    public partial class MantenimientoClientes : Mantenimiento
    {
        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {

        }

        public override Boolean Guardar()
        {
           if(Biblioteca.ValidarFormulario(this,errorProvider1) == false)
            {
                try
                {
                    string insertar = string.Format("EXEC ActualizarClientes '{0}','{1}'", txtNombre.Text.Trim(), txtApellido.Text.Trim());
                    Biblioteca.Validaciones(insertar);
                    MessageBox.Show("Cliente guardado correctamente");
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrio un error " + error);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public void Eliminar()
        {
            try
            {
                string eliminar = string.Format("EXEC EliminarClientes'{0}','{1}'",txtNombre.Text.Trim(), txtApellido.Text.Trim());
                Biblioteca.Validaciones(eliminar);
                MessageBox.Show("Cliente eliminado correctamente");
            }
            catch(Exception error)
            {
                MessageBox.Show("Ocurrio un error "+error);
            }

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNombre.Text.Trim())== false && string.IsNullOrEmpty(txtApellido.Text.Trim())==false)
            {
                txtNombre.Text = "";
                txtApellido.Text = "";
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarCliente Consul = new ConsultarCliente();
            Consul.MdiParent = this;
        }
    }
}
