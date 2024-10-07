using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class UpdateForm : Form
    {
        private int _id;
        
        public UpdateForm(string txt1 , string txt2 , string txt3 , int id)
        {
            InitializeComponent();
            Nametxt.Text = txt1;
            Countrytxt.Text = txt2;
            Emailtxt.Text = txt3;
            _id = id;
          
        }
        

        private void button5_Click(object sender, EventArgs e)
        {
            using (taskEntities db = new taskEntities())
            {

                try
                {
         
                    var s = db.schools.FirstOrDefault(z => z.id == _id );

                    if (s != null)
                    {
                        s.name = Nametxt.Text;
                        s.country = Countrytxt.Text;
                        s.email = Emailtxt.Text;

                        if (string.IsNullOrEmpty(Nametxt.Text) || string.IsNullOrEmpty(Countrytxt.Text) || string.IsNullOrEmpty(Emailtxt.Text))
                        {

                            MessageBox.Show("Please Enter All The Data");

                        }
                        else
                        {

                            if (Regex.IsMatch(s.name, "[a-zA-Z]"))
                            {

                                if (Regex.IsMatch(s.email, "[a-zA-Z1-9]@gmail.com"))
                                {

                                    db.SaveChanges();

                                    var m = db.schools.ToList();
                                    StudentsForm.Instance.dataGrid.DataSource = m;

                                    this.Close();

                                    StudentsForm.Instance.messg.Text = "The Student Data Is Updated Successfully";
                                }
                                else
                                {
                                    MessageBox.Show(@"Enter Your Email Correctly 
                               
                              
                                                 ****Ex:[A-Z,a-z,1-9]@gmail.com****");
                                    Nametxt.Clear();
                                    Countrytxt.Clear();
                                    Emailtxt.Clear();

                                }

                            }
                            else
                            {

                                MessageBox.Show(@"The Name Must Includes Letters Only

                                                         ****Ex:[A-Z,a-z]");
                                Nametxt.Clear();
                                Countrytxt.Clear();
                                Emailtxt.Clear();

                            }

                        }
                    }
                    else
                    {

                       MessageBox.Show("This Student Does Not Exist");
                        this.Close();

                    }
                    
                }
                catch 
                {

                    MessageBox.Show("*****Error*****");
                    this.Close();

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (taskEntities db = new taskEntities())
            {
                try
                {
                    var s = db.schools.FirstOrDefault(z => z.id == _id);
                    if (s != null)
                    {
                        db.schools.Remove(s);
                        db.SaveChanges();

                        var m = db.schools.ToList();
                        StudentsForm.Instance.dataGrid.DataSource = m;

                        StudentsForm.Instance.messg.Text = "The Student Is Deleted Successfully";
                    }
                    else
                    {
                        MessageBox.Show("This Student Does Not Exist");
                        
                    }
                }
                catch 
                {
                    MessageBox.Show("*****Error*****");
                    
                }
                this.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
