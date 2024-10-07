using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Login_stForm : Form
    {    
        public Login_stForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(Idtxt.Text.Trim());
                string password = Passwordtxt.Text;

                using (taskEntities db = new taskEntities())
                {
                    try
                    {
                        var pass = db.schools.FirstOrDefault(p => p.id == id && p.password == null);
                        var student = db.schools.FirstOrDefault(s => s.id == id && s.password == password);

                        if (pass != null)
                        {
                            PasswordForm form = new PasswordForm(id);
                            form.Show();
                        }
                        else
                        {
                            if (student != null)
                            {
                                SchoolPageForm form = new SchoolPageForm();
                                form.Show();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("This Id Is Incorrect");
                            }

                        }

                    }
                    catch
                    {
                        MessageBox.Show("*****Error*****");
                    }
                }
            }
            catch
            {
                MessageBox.Show("The Id Must Be Integer");

            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
