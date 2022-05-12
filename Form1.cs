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
        private Figure obj1;
        private bool first_create;
        private int num_exception;
        public Form1()
        {
            InitializeComponent();
            redact.Hide();
            Create_Figure.Size = new Size(424, 265);
            Figure_charact.Hide();
            exception.Hide();
            first_create = true;
            Basica.Hide();
            Basica.Text = "Сделал 10 вводов нечисловых значений в чужой фоновой?\nА может, лучше сделаешь Богданову на завтра?";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            exception.Hide();
            Basica.Hide();
            bool a = int.TryParse(width_text.Text, out int width);
            if (a)
            {  a = int.TryParse(height_text.Text, out int height);
                if (a)
                {
                    if (width <=0)
                    {
                        exception.Text = "Введено неположительное значение стороны.\nИсправьте и снова попробуйте создать фигуру";
                        if (num_exception >= 10)
                            Basica.Show();
                        exception.Show();
                    }
                    else if (height<=0)
                    {
                        if (rectangle.Checked)
                        {
                            exception.Text = "Введено неположительное значение высоты.\nИсправьте и снова попробуйте создать фигуру";

                        }
                        else
                        {
                            exception.Text = "Введено неположительное значение угла.\nИсправьте и снова попробуйте создать фигуру";
                        }
                        num_exception++;
                        if (num_exception >= 10)
                            Basica.Show();
                        exception.Show();
                    }
                    else if (romb.Checked & )
                }
                else
                {
                    if (rectangle.Checked)
                    {
                        exception.Text = "Введено нечисловое значение высоты.\nИсправьте и снова попробуйте создать фигуру";
                       
                    }
                    else
                    {
                        exception.Text = "Введено нечисловое значение угла.\nИсправьте и снова попробуйте создать фигуру";
                    }
                    num_exception++;
                    if (num_exception >= 10)
                        Basica.Show();
                    exception.Show();
                }
            }
            else
            {
                exception.Text = "Введено нечисловое значение стороны. \nИсправьте и снова попробуйте создать фигуру";
                num_exception++;
                if (num_exception >= 10)
                    Basica.Show();
                exception.Show();
            }
            
        }
        private void Output_charact()
        {
            first_create = false;
            if (rectangle.Checked) obj1 = new Rectangle();
            else obj1 = new Romb();
            Create_Figure.Size = new Size(424, 251);
            Figure_charact.Show();
            redact.Show();
        }

        private void rectangle_Click(object sender, EventArgs e)
        {
            height.Text = "Высота:";
            sm_or_grad.Text = "см";
            Figure_charact.Hide();
            width_text.Text = "";
            height_text.Text = "";
        }

        private void romb_Click(object sender, EventArgs e)
        {
            height.Text = "Угол:";
            sm_or_grad.Text = "град.";
            Figure_charact.Hide();
            width_text.Text = "";
            height_text.Text = "";
        }
    }
}
