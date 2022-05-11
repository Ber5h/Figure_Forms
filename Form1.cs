using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Четырехугольники
{
    public partial class Form1 : Form
    {
        Figure obj1;
        public Form1()
        {
            InitializeComponent();
            redact.Hide();
            Create_Figure.Size = new Size(424, 265);
            Figure_charact.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            height.Text = "Высота:";
            sm_or_grad.Text = "см";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            height.Text = "Угол:";
            sm_or_grad.Text = "град.";
        }

        private void create_Click(object sender, EventArgs e)
        {
            Create_Figure.Size = new Size(424, 384);
            redact.Show();
        }
    }
}
