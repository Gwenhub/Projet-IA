using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projettaquin
{
    public partial class Grille_Deplacement : Form
    {
        public Grille_Deplacement()
        {
            InitializeComponent();      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Grille_Deplacement_Load(object sender, EventArgs e)
        {
        }

        private void Grille_Deplacement_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void all_Button_Click(object sender, EventArgs e)
        {
            int row = tableLayoutPanel1.GetRow((Button)sender);
            int column = tableLayoutPanel1.GetColumn((Button)sender);
            label1.Text = "Ligne : "+ row;
            label2.Text = "Colonne : "+column;
        }
    }
}
