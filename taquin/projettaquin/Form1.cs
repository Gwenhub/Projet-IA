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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graph g = new Graph();
            NodeTaquin N0 = new NodeTaquin(textBox1.Text);
            List<GenericNode> Lres = g.RechercheSolutionAEtoile(N0);

            if (Lres.Count == 0)
            {
                labelsolution.Text = "Pas de solution";
            }
            else
            {   labelsolution.Text = "Une solution a été trouvée";
                foreach (GenericNode N in Lres)
                {
                    listBox1.Items.Add( N);
                }
                labelcountopen.Text = "Nb noeuds des ouverts : " + g.CountInOpenList().ToString();
                labelcountclosed.Text = "Nb noeuds des fermés : "+ g.CountInClosedList().ToString();
                g.GetSearchTree( treeView1 );
            }

        }
    }
}
