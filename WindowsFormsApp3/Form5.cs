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
    public partial class Form5 : Form
    {
        Metodos Met = new Metodos();

        public Form5()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Met.Eliminar(name.Text);
        }


        private void name_Enter(object sender, EventArgs e)
        {

            if (name.Text == "Username")
            {

                name.Text = "";
                name.ForeColor = Color.LightGray;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {

            if (name.Text == "")
            {

                name.Text = "Username";
                name.ForeColor = Color.DimGray;

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

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void Form5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
