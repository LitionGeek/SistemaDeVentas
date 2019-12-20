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
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        public void BtnSalir_Click(object sender, EventArgs e)
        {

        }

        private void Base_Load(object sender, EventArgs e)
        {

        }

        public virtual void Eliminar()
        {


        }

        public virtual void Nuevo()
        {

        }

        public virtual void Consultar()
        {

        }
            
        public virtual Boolean Guardar()
        {
            return false;
        }
        

    }
}
