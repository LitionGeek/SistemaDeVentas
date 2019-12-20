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
    public partial class Consultas : Base
    {
        public Consultas()
        {
            InitializeComponent();
        }

        public DataSet MostrarInfo(string tabla)
        {
            DataSet DS;
            string CMD = string.Format("SELECT * FROM " + tabla);
            DS = Biblioteca.Validaciones(CMD);

            return DS;
        }

        public void Consultas_Load(object sender, EventArgs e)
        {

        }

        public void BtnSelect_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
