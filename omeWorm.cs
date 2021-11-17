using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trriandle
{
    public partial class omeWorm : Form
    {
        public omeWorm()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void run_butt_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            double a, b, c, h;
                a = Convert.ToDouble(numericUpDown1.Text);
                b = Convert.ToDouble(numericUpDown2.Text);
                c = Convert.ToDouble(numericUpDown3.Text);
                h = Convert.ToDouble(numericUpDown4.Text);
            if (h == 0)
            {
                triangle triangle = new triangle(a, b, c);
                listView1.Items.Add("pool a:");
                listView1.Items.Add("pool b:");
                listView1.Items.Add("pool c:");
                listView1.Items.Add("kõrgem:");
                listView1.Items.Add("perimeetrit:");
                listView1.Items.Add("pool perimeetrit");
                listView1.Items.Add("Ruut:");
                listView1.Items.Add("on olemas?:");
                listView1.Items.Add("täpsustaja");
                listView1.Items[0].SubItems.Add(triangle.outPutA());
                listView1.Items[1].SubItems.Add(triangle.outPutB());
                listView1.Items[2].SubItems.Add(triangle.outPutC());
                listView1.Items[3].SubItems.Add(triangle.outPutH());
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Peremeter()));
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Half_perimeter()));
                listView1.Items[6].SubItems.Add(Convert.ToString(triangle.Surface()));

                if (triangle.ExistTriangle) { listView1.Items[7].SubItems.Add("olemas"); }
                else { listView1.Items[7].SubItems.Add("ei ole"); }
                listView1.Items[8].SubItems.Add(triangle.Triangletype);
                if (triangle.ExistTriangle == true)
                {
                    if (triangle.Triangletype == "võrdkülgne")
                    {
                        pictureBox1.Image = Properties.Resources.a_triangle;
                    }
                    else if (triangle.Triangletype == "võrdhaarne")
                    {
                        pictureBox1.Image = Properties.Resources.a_triangles;
                    }
                    else if (triangle.Triangletype == "täisnurkne")
                    {
                        pictureBox1.Image = Properties.Resources.a_triangle90;
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.a_triangles2;
                    }
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.nan;
                }
            }
            else if ((h != 0) && (a != 0) && (b != 0) && (c != 0))
            {
                triangle triangle = new triangle(a, b, c, h);
                listView1.Items.Add("pool a:");
                listView1.Items.Add("pool b:");
                listView1.Items.Add("pool c:");
                listView1.Items.Add("kõrgem:");
                listView1.Items.Add("perimeetrit:");
                listView1.Items.Add("pool perimeetrit");
                listView1.Items.Add("Ruut:");
                listView1.Items.Add("on olemas?:");
                listView1.Items.Add("täpsustaja");
                listView1.Items[0].SubItems.Add(triangle.outPutA());
                listView1.Items[1].SubItems.Add(triangle.outPutB());
                listView1.Items[2].SubItems.Add(triangle.outPutC());
                listView1.Items[3].SubItems.Add(triangle.outPutH());
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Peremeter()));
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Half_perimeter()));
                listView1.Items[6].SubItems.Add(Convert.ToString(triangle.Surface()));

                if (triangle.ExistTriangle) { listView1.Items[7].SubItems.Add("olemas"); }
                else { listView1.Items[7].SubItems.Add("ei ole"); }
                listView1.Items[8].SubItems.Add(triangle.Triangletype);
                if (triangle.ExistTriangle == true)
                {
                    if (triangle.Triangletype == "võrdkülgne")
                    {
                        pictureBox1.Image = Properties.Resources.a_triangle;
                    }
                    else if (triangle.Triangletype == "võrdhaarne")
                    {
                        pictureBox1.Image = Properties.Resources.a_triangles;
                    }
                    else if (triangle.Triangletype == "täisnurkne")
                    {
                        pictureBox1.Image = Properties.Resources.a_triangle90;
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.a_triangles2;
                    }
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.nan;
                }
            }
            else
            {
                triangle triangle = new triangle(a, h);
                listView1.Items.Add("pool a:");
                listView1.Items.Add("pool b:");
                listView1.Items.Add("pool c:");
                listView1.Items.Add("kõrgem:");
                listView1.Items.Add("perimeetrit:");
                listView1.Items.Add("pool perimeetrit");
                listView1.Items.Add("Ruut:");
                listView1.Items.Add("on olemas?:");
                listView1.Items.Add("täpsustaja");
                listView1.Items[0].SubItems.Add(triangle.outPutA());
                listView1.Items[1].SubItems.Add(triangle.outPutB());
                listView1.Items[2].SubItems.Add(triangle.outPutC());
                listView1.Items[3].SubItems.Add(triangle.outPutH());
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Peremeter()));
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Half_perimeter()));
                listView1.Items[6].SubItems.Add(Convert.ToString(triangle.Surface()));

                if (triangle.ExistTriangle) { listView1.Items[7].SubItems.Add("olemas"); }
                else { listView1.Items[7].SubItems.Add("ei ole"); }
                listView1.Items[8].SubItems.Add(triangle.Triangletype);
                if (triangle.ExistTriangle == true)
                {
                    if (triangle.Triangletype == "võrdkülgne")
                    {
                        pictureBox1.Image = Properties.Resources.a_triangle;
                    }
                    else if (triangle.Triangletype == "võrdhaarne")
                    {
                        pictureBox1.Image = Properties.Resources.a_triangles;
                    }
                    else if (triangle.Triangletype == "täisnurkne")
                    {
                        pictureBox1.Image = Properties.Resources.a_triangle90;
                    }
                    else
                    {
                        pictureBox1.Image = Properties.Resources.a_triangles2;
                    }
                }
                else
                {
                    pictureBox1.Image = Properties.Resources.nan;
                }
            }
            

            
            
        }

        private void txtbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void omeWorm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
