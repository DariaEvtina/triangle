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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void run_button_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtA.Text);
            b = Convert.ToDouble(txtB.Text);
            c = Convert.ToDouble(txtC.Text);
            triangle triangle = new triangle(a, b, c);
            listView1.Items.Add("pool a:");
            listView1.Items.Add("pool b:");
            listView1.Items.Add("pool c:");
            listView1.Items.Add("perimeetri:");
            listView1.Items.Add("Ruut:");
            listView1.Items.Add("on olemas?:");
            listView1.Items.Add("täpsustaja");
            listView1.Items[0].SubItems.Add(triangle.outPutA());
            listView1.Items[1].SubItems.Add(triangle.outPutB());
            listView1.Items[2].SubItems.Add(triangle.outPutC());
            listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Peremeter()));
            listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
            if (triangle.ExistTriangle) { listView1.Items[5].SubItems.Add("olemas"); }
            else { listView1.Items[5].SubItems.Add("ei ole"); }
            listView1.Items[6].SubItems.Add(triangle.Triangletype);
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            omeWorm frm = new omeWorm();
            frm.Show();
            this.Hide();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
