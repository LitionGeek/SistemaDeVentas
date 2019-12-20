using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriaDLL
{
    public partial class ErrorTxtBox : TextBox
    {
        public ErrorTxtBox()
        {
            InitializeComponent();
        }

        private void ErrorTxtBox_Load(object sender, EventArgs e)
        {

        }

        public Boolean ValidarNumeros
        {
            set;
            get;
        }

        public Boolean Validar
        {
            set;
            get;
        }
    }
}
