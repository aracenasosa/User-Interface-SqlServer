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
    public partial class Form4 : Form
           
    {  Metodos Met = new Metodos();

        public Form4()  
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            Listar();
        }

        private void Listar()
        {

          
            DGV.DataSource = Met.ListarUsuarios();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            Dispose();
        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Username")
            {

                name.Text = "";
                name.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
               if (name.Text == "")
            {

                name.Text = "Username";
                name.ForeColor = Color.Black;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jaja = name.Text;
            DGV.DataSource = Met.Buscar(jaja);  
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
