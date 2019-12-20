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
    public partial class Facturacion : Procesos
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            string Vendedor = "SELECT * FROM Usuarios WHERE id_usuario = " + IniciarSesion.Codigo;
            DataSet DS;
            DS = Biblioteca.Validaciones(Vendedor);

            lblVendedor.Text = DS.Tables[0].Rows[0]["username"].ToString().Trim();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCod.Text.Trim()) == false)
                {
                    string cmd = string.Format("SELECT NombreCliente FROM Clientes_SMART WHERE id_cliente = '{0}'", txtCod.Text.Trim());
                    DataSet DS = Biblioteca.Validaciones(cmd);

                    txtCliente.Text = DS.Tables[0].Rows[0]["NombreCliente"].ToString().Trim();

                    txtCodigo.Focus();
                }
            }
            catch(Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: " + error.Message);
            }
        }

        public static int contadorFila = 0;
        public static double total;

        private void BtnColocar_Click(object sender, EventArgs e)
        {
            if (Biblioteca.ValidarFormulario(this, errorProvider1) == false)
            {
                bool existe = false;
                int numeroFila = 0;

                if (contadorFila == 0)
                {
                    dataGridView1.Rows.Add(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);
                    double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                    dataGridView1.Rows[contadorFila].Cells[4].Value = importe;

                    contadorFila++;
                }
                else
                {
                    foreach (DataGridViewRow fila in dataGridView1.Rows)
                    {
                        if (fila.Cells[0].Value.ToString() == txtCodigo.Text)
                        {
                            existe = true;
                            numeroFila = fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        dataGridView1.Rows[numeroFila].Cells[3].Value = (Convert.ToDouble(txtCantidad.Text) + Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[3].Value)).ToString();
                        double importe = Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[numeroFila].Cells[3].Value);
                        dataGridView1.Rows[numeroFila].Cells[4].Value = importe;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(txtCodigo.Text, txtDescripcion.Text, txtPrecio.Text, txtCantidad.Text);
                        double importe = Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[contadorFila].Cells[3].Value);
                        dataGridView1.Rows[contadorFila].Cells[4].Value = importe;

                        contadorFila++;
                    }
                }
                
            }
            total = 0;

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                total += Convert.ToDouble(fila.Cells[4].Value);           
            }
            lblTotal.Text = "$ " + total.ToString();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void BtrnEliminar_Click(object sender, EventArgs e)
        {
            if(contadorFila > 0 )
            {
                total -= (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                lblTotal.Text = "$ " + total.ToString();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
                contadorFila--;
            }
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            ConsultarCliente consultar = new ConsultarCliente();
            consultar.ShowDialog();

            if(consultar.DialogResult == DialogResult.OK)
            {
                txtCod.Text = consultar.dataGridView1.Rows[consultar.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtCliente.Text = consultar.dataGridView1.Rows[consultar.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                txtCodigo.Focus();
            }
        }

        private void BtnProd_Click(object sender, EventArgs e)
        {
            ConsultarProducto consulProd = new ConsultarProducto();
            consulProd.ShowDialog();
            if (consulProd.DialogResult == DialogResult.OK)
            {
                txtCodigo.Text = consulProd.dataGridView1.Rows[consulProd.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtDescripcion.Text = consulProd.dataGridView1.Rows[consulProd.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtPrecio.Text = consulProd.dataGridView1.Rows[consulProd.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();

                txtCantidad.Focus();
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public override void Nuevo()
        {
            txtCodigo.Text = "";
            txtCliente.Text = "";
            txtCod.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text ="";
            txtCantidad.Text ="";
            lblTotal.Text = "$ 0";
            dataGridView1.Rows.Clear();

            contadorFila = 0;
            total = 0;

            txtCod.Focus();
        }

        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            if(contadorFila !=0 )
            {
                try
                {
                    string cmd = string.Format("EXEC ActualizarFactura '{0}'",txtCod.Text.Trim());
                    DataSet DS = Biblioteca.Validaciones(cmd);

                    string NumeroFactura = DS.Tables[0].Rows[0]["NumeroFactura"].ToString().Trim();

                    foreach(DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        cmd = string.Format("EXEC ActualizarDetalles '{0}','{1}','{2}','{3}'", NumeroFactura,Fila.Cells[0].Value.ToString(),Fila.Cells[2].Value.ToString(),Fila.Cells[3].Value.ToString());
                        DS = Biblioteca.Validaciones(cmd);
                    }

                    cmd = "EXEC DatosFactura " + NumeroFactura;

                    DS = Biblioteca.Validaciones(cmd);

                    //Factura fac = new Factura();
                    

                }
                catch(Exception error)
                {
                    MessageBox.Show("Error: "+error.Message);
                }
            }
        }
    }
}
