using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Sistema_Pos
{
    public partial class Mantenimiento : Base
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Mantenimiento_Load(object sender, EventArgs e)
        {

        }
    }
}
