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
            double a, b, c, h;
            a = Convert.ToDouble(txtbox1.Text);
            b = Convert.ToDouble(txtbox2.Text);
            c = Convert.ToDouble(txtbox3.Text);
            h = Convert.ToDouble(txtbox4.Text);
            if (h==0)
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
                triangle triangle = new triangle(a,h);
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
                listView1.Items[3].SubItems.Add(triangle.outPutH());
                listView1.Items[6].SubItems.Add(Convert.ToString(triangle.SurfaceAH()));
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
    }
}
