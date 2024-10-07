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
    public partial class login : Form
    {
        public static login instance;
        public Label lbl; 
        public login()
        {
            InitializeComponent();
            instance = this;
            lbl = label4;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {            
            string username = UserNametxt.Text.Trim();
            string password = Passwordtxt.Text.Trim();  
            using (taskEntities db = new taskEntities())
            {
                try
                {
                    var admin = db.registers.FirstOrDefault(u => u.username == username && u.password == password);
                    if (admin != null)
                    {

                        if (Regex.IsMatch(admin.username, "[admin]"))
                        {

                            StudentsForm form = new StudentsForm();
                            form.Show();
                            

                        }
                        else
                        {
                            StudentsForm form = new StudentsForm();
                            form.Show();
                            StudentsForm.Instance.getbyid.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"The Username Or Password Is Incorrect
                                                                               
                                                     -Please Make An Account First");

                        Registerform form = new Registerform();
                        form.Show();
                    }
                }
                catch 
                {
                    MessageBox.Show("*****Error*****");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registerform form = new Registerform();
            form.Show();
        }
    }
}
