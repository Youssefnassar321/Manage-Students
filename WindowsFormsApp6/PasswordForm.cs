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
    public partial class PasswordForm : Form
    {
        private int _id;
        public PasswordForm(int id )
        {
            InitializeComponent();
            _id = id;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string confirmpass = ConfirmPasstxt.Text;

            using (taskEntities db = new taskEntities())
            {
                try
                {
                    var student = db.schools.FirstOrDefault(s => s.id == _id);
                    student.password = Passwordtxt.Text;

                     if (student.password != confirmpass)
                     {
                        MessageBox.Show("The Confirm Password Must Be Like The Password");

                     }
                     else
                     {
                        db.SaveChanges();
                        MessageBox.Show("The Password Is Updated Successfully");
                        this.Close();

                     }                     
                   
                }
                catch
                {
                    MessageBox.Show("*****Error*****");

                }
            }

        }

        
    }
}
