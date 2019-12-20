using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibreriaDLL
{
    public class Biblioteca
    {
        public static DataSet Validaciones(string cmd)
        {
            SqlConnection ConnectDB = new SqlConnection("Data Source=LITIONGEEK-PC\\LITIONGEEK;Initial Catalog=Dynamics_SMARTINTE;Integrated Security=True");
            ConnectDB.Open();

            DataSet Data = new DataSet();
            SqlDataAdapter DataAdapter = new SqlDataAdapter(cmd,ConnectDB);

            DataAdapter.Fill(Data);

            ConnectDB.Close();
            return Data;
        }

        public static Boolean ValidarFormulario(Control ObjetoError,ErrorProvider ErrorProvider)
        {
            Boolean SiError = false;

            foreach(Control campo in ObjetoError.Controls)
            {
                if(campo is ErrorTxtBox)
                {
                    ErrorTxtBox objeto = (ErrorTxtBox)campo;

                    if(objeto.Validar == true)
                    {
                        if(string.IsNullOrEmpty(objeto.Text.Trim()))
                        {
                            ErrorProvider.SetError(objeto,"Los campos no pueden estar vacios");
                            SiError = true;
                        }
                    }
                    if(objeto.ValidarNumeros == true)
                    {
                        int contador = 0, EncontrarLetras = 0;
                        
                        foreach(char letra in objeto.Text.Trim())
                        {
                            if(char.IsLetter(objeto.Text.Trim(), contador))
                            {
                                EncontrarLetras++;
                            }
                            contador++;
                        }
                        if(EncontrarLetras !=0) 
                        {
                            SiError = true;
                            ErrorProvider.SetError(objeto, "Solo se aceptan numeros");
                        }

                    }
                }
            }
            return SiError;
        }

    }
}
