using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class StudentsForm : Form
    {
        public static StudentsForm Instance;
        public DataGridView dataGrid;
        public Label messg;
        bool slidebarExband;
        public System.Windows.Forms.Button getbyid;
        public System.Windows.Forms.Button register;



        public StudentsForm()
        {
            InitializeComponent();
            Instance = this;
            dataGrid = dataGridView1;
            messg = Messagelbl;
            getbyid = Searchbutton;
            register = Registerbutton;  


        }

        private void Addbutton_Click(object sender, EventArgs e)
        {


            school student = new school();
            student.name = txt1.Text.Trim();
            student.country = txt2.Text.Trim();
            student.email = txt3.Text.Trim();

            if (string.IsNullOrEmpty(txt1.Text) || string.IsNullOrEmpty(txt2.Text) || string.IsNullOrEmpty(txt3.Text))
            {

                MessageBox.Show("Please Enter All The Data");

            }
            else
            {

                if (Regex.IsMatch(student.name, "[a-zA-Z]"))
                {

                    if (Regex.IsMatch(student.email, "[a-zA-Z1-9]@gmail.com"))
                    {

                        using (taskEntities db = new taskEntities())
                        {

                            try
                            {

                                db.schools.Add(student);
                                db.SaveChanges();

                                Degree d = new Degree();
                                d.Eid = 1;
                                d.Id = student.id;
                                d.ExamName = "Math";

                                db.Degrees.Add(d);
                                db.SaveChanges();

                                Degree de = new Degree();
                                de.Eid = 2;
                                de.Id = student.id;
                                de.ExamName = "English";

                                db.Degrees.Add(de);
                                db.SaveChanges();

                                Degree deg = new Degree();
                                deg.Eid = 3;
                                deg.Id = student.id;
                                deg.ExamName = "Arabic";

                                db.Degrees.Add(deg);
                                db.SaveChanges();

                                Degree degr = new Degree();
                                degr.Eid = 4;
                                degr.Id = student.id;
                                degr.ExamName = "French";
                                db.Degrees.Add(degr);
                                db.SaveChanges();

                                var students = db.schools.ToList();
                                dataGridView1.DataSource = students;
                            }
                            catch
                            {
                                MessageBox.Show("*****Error*****");
                            }
                            Messagelbl.Text = "Student Is Add Successfully";
                        }

                    }
                    else
                    {
                        MessageBox.Show(@"Enter Your Email Correctly 
                               
                               
                                ****Ex:[A-Z,a-z,1-9]@gmail.com****");
                    }

                }
                else
                {
                    MessageBox.Show(@"The Name Must Includes Letters Only


                                                       EX:[a-z,A-Z]");

                }

            }
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'taskDataSet.school' table. You can move, or remove it, as needed.
            this.schoolTableAdapter.Fill(this.taskDataSet.school);

        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }


        private void Getbutton_Click(object sender, EventArgs e)
        {
            try
            {

                if (Regex.IsMatch(txt3.Text, "[0-9]"))
                {
                    int id = int.Parse(txt3.Text);
                    using (taskEntities db = new taskEntities())
                    {
                        try
                        {
                            var student = db.schools.FirstOrDefault(x => x.id == id);
                            if (student != null)
                            {
                                var st = new List<school> { student };
                                dataGridView1.DataSource = st;

                                Messagelbl.Text = "The Data Is Viewed Successfully";
                            }
                            else
                            {
                                MessageBox.Show("The Id Is Not Found");
                            }

                        }
                        catch
                        {
                            MessageBox.Show("*****Error*****");

                        }
                        txt3.Clear();
                    }
                }
                else
                {
                    MessageBox.Show(@"The ID Must Be Integer 
                                                  
                                                       EX:[0-9]");

                }
            }
            catch
            {
                MessageBox.Show("*****Error*****");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Closebutton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Homebutton_Click(object sender, EventArgs e)
        {
            try
            {
                searchimg.Hide();
                searchbox.Hide();
                txt1.Hide();
                txt2.Hide();
                txt3.Hide();
                label1.Hide();
                label2.Hide();
                label3.Hide();
                Messagelbl.Hide();
                dataGridView1.Hide();
                Addbutton.Hide();
                Getbutton.Hide();
                pictureBox2.Show();
                label6.Show();
                label7.Show();
            }
            catch
            {
                MessageBox.Show("*****Error*****");
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Slidebartimer.Start();
        }

        private void Slidebartimer_Tick(object sender, EventArgs e)
        {
            try
            {
                if (slidebarExband)
                {
                    Slidebar.Width -= 10;

                    if (Slidebar.Width == Slidebar.MinimumSize.Width)
                    {
                        slidebarExband = false;
                        Slidebartimer.Stop();
                    }
                }
                else
                {
                    Slidebar.Width += 10;

                    if (Slidebar.Width == Slidebar.MaximumSize.Width)
                    {
                        slidebarExband = true;
                        Slidebartimer.Stop();
                    }
                }
            }
            catch
            {
                MessageBox.Show("*****Error*****");
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Addpage_Click(object sender, EventArgs e)
        {
            try
            {
                Getbutton.Hide();
                pictureBox2.Hide();
                label6.Hide();
                label7.Hide();
                label1.Text = "Enter Name : ";
                label2.Text = "Enter Country :";
                label3.Text = "Enter Email :";
                txt1.Show();
                txt2.Show();
                txt3.Show();
                label1.Show();
                label2.Show();
                label3.Show();
                Addbutton.Show();
                dataGridView1.Show();
                searchimg.Show();
                searchbox.Show();
            }
            catch
            {
                MessageBox.Show("*****Error*****");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Searchbutton_Click_1(object sender, EventArgs e)
        {
            try
            {
                label6.Hide();
                label7.Hide();
                pictureBox2.Hide();
                label1.Hide();
                label2.Hide();
                txt1.Hide();
                txt2.Hide();
                label3.Text = "Enter Id : ";
                txt3.Show();
                label3.Show();
                Getbutton.Show();
                dataGridView1.Show();
                searchimg.Show();
                searchbox.Show();

            }
            catch
            {
                MessageBox.Show("*****Error*****");
            }
        }

        private void Refreshbutton_Click(object sender, EventArgs e)
        {
            try
            {
                using (taskEntities db = new taskEntities())
                {
                    try
                    {
                        var list = db.schools.ToList();
                        dataGridView1.DataSource = list;
                    }
                    catch
                    {
                        MessageBox.Show("*****Error*****");
                    }
                }
            }
            catch
            {
                MessageBox.Show("*****Error*****");
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                UpdateForm f = new UpdateForm(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString(), row.Cells[2].Value.ToString()
                , Convert.ToInt32(row.Cells["id"].Value));
                f.Show();
            }
            catch
            {
                MessageBox.Show("*****Error*****");
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void searchbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (taskEntities db = new taskEntities())
                {
                    try
                    {
                        var search = db.schools.Where(stud => stud.name.Contains(searchbox.Text)).ToList();
                        dataGridView1.DataSource = search;
                    }
                    catch
                    {
                        MessageBox.Show("*****Error*****");

                    }
                }
            }
            catch
            {
                MessageBox.Show("*****Error*****");

            }


        }

        private void searchbox_KeyPress(object sender, KeyPressEventArgs e)
        {
                        
        }

        private void searchbox_ReadOnlyChanged(object sender, EventArgs e)
        {
        }

        private void Helpbutton_Click(object sender, EventArgs e)
        {
            Helpform helpform = new Helpform();
            helpform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registerform form = new Registerform();
            form.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DegreesForm form = new DegreesForm();
            form.Show();
        }
    }
}
