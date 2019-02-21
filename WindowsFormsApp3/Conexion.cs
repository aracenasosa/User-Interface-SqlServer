using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Conexion
    {

       static private string cadena = "Data Source = DESKTOP-4CI47L8;Initial Catalog = Login2; Integrated Security = true";

        private SqlConnection conectar = new SqlConnection(cadena);

       

        public SqlConnection Conectar()
        {

           
            if(conectar.State == ConnectionState.Closed)
            {
                conectar.Open();
                //MessageBox.Show("Conexion Establecida!");
            }
            
                
                return conectar;
            
        }

        public SqlConnection Desconectar()
        {

            if (conectar.State == ConnectionState.Open)
            {
                 conectar.Close();
                //MessageBox.Show("BD Desconectada Exitosamente.");
            }
               
                return conectar;
             
        }


    }
}
