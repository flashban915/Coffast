using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COFFAST
{
    public partial class cuer_jq : Form
    {
        public cuer_jq()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Menu = new COFFAST();
            Menu.Show();
            this.Close();
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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form Promociones = new Form3();
            Promociones.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form Promociones = new Form3();
            Promociones.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form Promociones = new Form3();
            Promociones.Show();
            this.Close();
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
    }
}
