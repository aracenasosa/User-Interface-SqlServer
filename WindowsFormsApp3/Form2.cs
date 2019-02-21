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

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        Conexion cn = new Conexion();
        Metodos Met = new Metodos();
        
        public Form2()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                Pass.UseSystemPasswordChar = true;

            }
            else
            {

                Pass.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            cn.Conectar();
            if(cn != null)
            {

                string name = NameT.Text;
                string apellido = lastN.Text;
                string Sexo = "";
                string UserN = User.Text;
                string pass = Pass.Text;
                string cedula = IdentificationC.Text;

                if (Male.Checked)
                {

                    Sexo = "M";
                }
                else if (Female.Checked)
                {
                    Sexo = "F";
                }

                 Met.Insertar(name,apellido,Sexo,UserN,pass,cedula);
                

            }
            else
            {
                MessageBox.Show("No se pudo Agregar.");

            }

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lineShape3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            if (NameT.Text == "Name")
            {

                NameT.Text = "";
                NameT.ForeColor = Color.LightGray;
            }
        }

        private void Name_Leave(object sender, EventArgs e)
        {
            if (NameT.Text == "")
            {

                NameT.Text = "Name";
                NameT.ForeColor = Color.DimGray;

            }
        }

        private void lastN_Enter(object sender, EventArgs e)
        {


            if (lastN.Text == "LastName")
            {

                lastN.Text = "";
                lastN.ForeColor = Color.LightGray;
            }
        }

        private void lastN_Leave(object sender, EventArgs e)
        {

            if (lastN.Text == "")
            {

                lastN.Text = "LastName";
                lastN.ForeColor = Color.DimGray;

            }
        }

        private void User_Enter(object sender, EventArgs e)
        {

            if (User.Text == "Username")
            {

                User.Text = "";
                User.ForeColor = Color.LightGray;
            }
        }

        private void User_Leave(object sender, EventArgs e)
        {

            if (User.Text == "")
            {

                User.Text = "Username";
                User.ForeColor = Color.DimGray;

            }
        }

        private void Pass_Enter(object sender, EventArgs e)
        {

            if (Pass.Text == "Password")
            {

                Pass.Text = "";
                Pass.ForeColor = Color.LightGray;
                Pass.UseSystemPasswordChar = false;
            }
        }

        private void Pass_Leave(object sender, EventArgs e)
        {

            if (Pass.Text == "")
            {

                Pass.Text = "Password";
                Pass.ForeColor = Color.DimGray;
                Pass.UseSystemPasswordChar = true;

            }
        }

        private void IdentificationC_Enter(object sender, EventArgs e)
        {

            if (IdentificationC.Text == "Identification Card")
            {

                IdentificationC.Text = "";
                IdentificationC.ForeColor = Color.LightGray;
            }
        }

        private void IdentificationC_Leave(object sender, EventArgs e)
        {

            if (IdentificationC.Text == "")
            {

                IdentificationC.Text = "Identification Card";
                IdentificationC.ForeColor = Color.DimGray;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NameT_Validated(object sender, EventArgs e)
        {
           
        }

        private void NameT_Validating(object sender, CancelEventArgs e)
        {

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            Dispose();
        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
