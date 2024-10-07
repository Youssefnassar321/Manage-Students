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
    public partial class Login_TecForm : Form
    {
        
        public Login_TecForm()
        {
            InitializeComponent();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registerform form = new Registerform();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = UserNametxt.Text.Trim();
            string password = Passwordtxt.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) 
            {
                MessageBox.Show("Please Enter All The Data");
            }
            else
            {
                using (taskEntities db = new taskEntities()) 
                {
                    try
                    {
                        var user = db.registers.FirstOrDefault(u => u.username == username && u.password == password);
                        if (user != null) 
                        {
                            if (Regex.IsMatch(user.username, "admin"))
                            {
                                StudentsForm form = new StudentsForm();
                                form.Show();
                                this.Close();
                            }
                            else
                            {
                                StudentsForm form = new StudentsForm();
                                form.Show();                                
                                StudentsForm.Instance.register.Hide();
                                this.Close();

                            }

                        }
                        else
                        {
                            MessageBox.Show("The Username Or Password Is Incorrect");

                        }
                    }
                    catch
                    {
                        MessageBox.Show("*****Error*****");

                    }
                }
            }

            UserNametxt.Clear();
            Passwordtxt.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
