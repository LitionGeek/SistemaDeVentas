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
    public partial class MantenimientoProductos : Mantenimiento
    {
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {

        }

        public override Boolean Guardar()
        {
            if (Biblioteca.ValidarFormulario(this, errorProvider1) == false)
            {
                try
                {
                    string insertar = string.Format("EXEC ActualizarProductos '{0}','{1}'", txtDesc.Text.Trim(), txtPrecio.Text.Trim());
                    Biblioteca.Validaciones(insertar);
                    MessageBox.Show("Producto guardado correctamente");
                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrio un error " + error);
                    return false;
                }
            }
            return false;
        }

        public override void Eliminar()
        {
            try
            {
                string eliminar = string.Format("EXEC EliminarProductos '{0}'", txtDesc.Text.Trim());
                Biblioteca.Validaciones(eliminar);
                MessageBox.Show("Producto eliminado");
            }
            catch(Exception error)
            {
                MessageBox.Show("Se produjo un error "+error);
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDesc.Text.Trim())== false && string.IsNullOrEmpty(txtPrecio.Text.Trim()) == false)
            {
                txtDesc.Text = "";
                txtPrecio.Text = "";
            }
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            ConsultarProducto consultProd = new ConsultarProducto();
            consultProd.Show();
        }
    }
}
