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
    public partial class Procesos : Base
    {
        public Procesos()
        {
            InitializeComponent();
        }

        private void Procesos_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
