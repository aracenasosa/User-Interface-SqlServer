using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Metodos
    {

        private Conexion Conexion = new Conexion();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader Leer;
        private DataTable Table = new DataTable();


        public SqlDataReader Validar(string User, string Pass)
        {
           
            Comando.Connection = Conexion.Conectar();
            Comando.CommandText = "ValidarUser";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@User",User);
            Comando.Parameters.AddWithValue("@Pass",Pass);
            Leer = Comando.ExecuteReader();
            return Leer;

        }

        public void Insertar(string Name, string LastName, string Sexo, string Username, string Pass, string Cedula)
        {

            try
            {
                Comando.Connection = Conexion.Conectar();
                Comando.CommandText = "Insert Into Usuarios Values ('" + Name + "','" + LastName + "','" + Sexo + "','" + Username + "','" + Pass + "','" + Cedula + "')";
                Leer = Comando.ExecuteReader();
                MessageBox.Show("Insertado Correctamente.");
                Leer.Close();
                Conexion.Desconectar();


            }
            catch (Exception ex)

            {

                MessageBox.Show("Error!! " + ex.ToString());
            }

        }

        public DataTable ListarUsuarios()
        {
            try
            {

            Comando.Connection = Conexion.Conectar();
            Comando.CommandText = "Select * from Usuarios";
            Leer = Comando.ExecuteReader();
            Table.Load(Leer);
            Leer.Close();
            Conexion.Desconectar();
           

            }catch(Exception ex)
            {

                MessageBox.Show("Error!! " + ex); 

            }
           
         return Table;
        }

        public void Eliminar(string Username)
        {
            try
            {

            Comando.Connection = Conexion.Conectar();
            Comando.CommandText = "Delete from Usuarios Where Username = '" + Username + "'";
            Leer = Comando.ExecuteReader();
            MessageBox.Show("Eliminado Correctamente.");
            Leer.Close();
            Conexion.Desconectar();

            }
            catch(Exception ex)
            {

                MessageBox.Show("Error!! " + ex);
            }
           

        } 

     
        public DataTable Buscar(string Username)
        {
            try
            {

                Comando.Connection = Conexion.Conectar();
                Comando.CommandText = "Select * from Usuarios Where Username = '" + Username + "'";
                Leer = Comando.ExecuteReader();
                Table.Load(Leer);
                Leer.Close();
                Conexion.Desconectar();


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error!! " + ex);

            }

            return Table;
        }

    }
}
