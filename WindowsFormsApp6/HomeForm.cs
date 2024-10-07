using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    
    public partial class HomeForm : Form
    {
        public Point mouselocation;
        public HomeForm()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Login_stForm form = new Login_stForm();
            form.Show();
            
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login_TecForm form = new Login_TecForm();
            form.Show();
            
            
        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            mouselocation = new Point(e.X, e.Y);

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousepose =Control.MousePosition;
                mousepose.Offset(mouselocation.X, mouselocation.Y);
                Location = mousepose;
            }
        }
    }
}
