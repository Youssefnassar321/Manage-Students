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
    public partial class Registerform : Form
    {
        public Registerform()
        {
            InitializeComponent();
        }

        private void Registerform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            register user = new register();
            user.username = UserNametxt.Text.Trim();
            user.password = Passwordtxt.Text.Trim();

            if(string.IsNullOrEmpty(UserNametxt.Text) || string.IsNullOrEmpty(Passwordtxt.Text))
            {
                MessageBox.Show("Please Enter All The Data");
            }
            else
            {
                if (Regex.IsMatch(user.username, "[a-zA-Z0-9]"))
                {
                    using (taskEntities db = new taskEntities())
                    {
                        try
                        {
                            db.registers.Add(user);
                            db.SaveChanges();                            
                            this.Close();
                        }
                        catch 
                        {
                            MessageBox.Show("*****Error*****");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(@"The Username Must Includes Only


                                                       EX:[a-z,A-Z,0-9]");
                }
                UserNametxt.Clear();
                Passwordtxt.Clear();
                
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
