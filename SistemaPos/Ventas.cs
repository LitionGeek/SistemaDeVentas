﻿using System;
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
    public partial class Ventas : Consultas
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MostrarInfo("Factura").Tables[0]; 
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim()) == false)
            {
                try
                {
                    DataSet DS;
                    string buscar = "Select * from Factura WHERE NumeroFactura LIKE ('%" + textBox1.Text.Trim() + "%')";
                    DS = Biblioteca.Validaciones(buscar);
                    dataGridView1.DataSource = DS.Tables[0];
                    }
                catch (Exception error)
                {
                    MessageBox.Show("No se puede conectar, Error: ", error.Message);
                }
            }
        }
    }

}
