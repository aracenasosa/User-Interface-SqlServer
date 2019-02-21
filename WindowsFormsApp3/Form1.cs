using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Conexion cn = new Conexion();

        public Form1()
        {
            InitializeComponent();
        }

        Metodos Met = new Metodos();
        private string _User;
        private string _Pass;

        public String Usuario
        {
            set { _User = value;}
            get { return _User; }
        }

        public String Contraseña
        {
            set { _Pass = value; }
            get { return _Pass; }
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(user.Text == "Username")
            {

                user.Text = "";
                user.ForeColor = Color.LightGray;
            }
        }

        private void user_Leave(object sender, EventArgs e)
        {
            if (user.Text == "")
            {

                user.Text = "Username";
                user.ForeColor = Color.DimGray;

            }
        }

        private void pass_Enter(object sender, EventArgs e)
        {
            if (pass.Text == "Password")
            {

                pass.Text = "";
                pass.ForeColor = Color.LightGray;
                pass.UseSystemPasswordChar = true;
            }
        }

        private void pass_Leave(object sender, EventArgs e)
        {

            if (pass.Text == "")
            {

                pass.Text = "Password";
                pass.ForeColor = Color.DimGray;
                pass.UseSystemPasswordChar = false;

            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (user.Text.Trim() != "" || pass.Text.Trim() != "")
            {
                if(user.Text.Trim() != "Usuario" || pass.Text.Trim() != "Password")
                {

                SqlDataReader Leer;
                Usuario = user.Text;
                Contraseña = pass.Text;
                Leer = ValidarUser();
                if(Leer.Read() == true)
                {

                Form3 f = new Form3();
                f.Show();
                this.Hide();

                }
                else
                {

                    MessageBox.Show("Usuario o Contraseña Incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                }
                else
                {
                    MessageBox.Show("Un Campo Esta vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            else
            {

                MessageBox.Show("Un Campo Esta vacio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private SqlDataReader ValidarUser()
        {
            
            SqlDataReader Leer;
            Leer = Met.Validar(Usuario, Contraseña);
           
            return Leer;
           
        }

        private void exit_Click(object sender, EventArgs e)
        {

           Application.Exit();
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            cn.Conectar();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            cn.Desconectar();
        }
    }
}
