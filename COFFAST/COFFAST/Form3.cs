using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFAST
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form Comentarios = new Form4();
            Comentarios.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form Comentarios = new Form4();
            Comentarios.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form Comentarios = new Form4();
            Comentarios.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form Carrito = new Form6();
            Carrito.Show();
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form Menu = new COFFAST();
            Menu.Show();
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form Menu = new COFFAST();
            Menu.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Menu = new COFFAST();
            Menu.Show();
            this.Close();
        }
    }
}
