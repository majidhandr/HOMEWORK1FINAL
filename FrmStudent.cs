using StudentInfo.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace StudentInfo
{

    public partial class frmStudent : Form
    {
        private List<Student> studentlists = new List<Student>();

        public frmStudent()
        {
            InitializeComponent();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            dGVStudentList.Rows.Add(txtId.Text,
                                     txtFirstName.Text,
                                     txtLastName.Text,
                                     txtBirthDate.Text,
                                     txtAddress.Text);

            //studentlists.Add(new Student(txtId.Text,txtFirstName.Text,txtLastName.Text,
            //                             txtBirthDate.Text,txtAddress.Text));



            /* dGVStudentList.Columns.Clear();
             var columns = from std in studentlists
                           orderby std.firstName ascending
                           select new {
                                         StudentId = std.studentid,
                                         std.firstName,
                                         std.lastName,
                                         std.birthDate,
                                         std.address
                           };

             dGVStudentList.DataSource = columns.ToList();
             */


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dGVStudentList.Rows.Count; i++)
            {
                if (this.dGVStudentList.Rows[i].Cells[0].Value.ToString() == this.textBox1.Text)
                {
                    MessageBox.Show("yees" + this.dGVStudentList.Rows[i].Cells[i].Value);
                }



                else

                    MessageBox.Show("nooo");

                }
            }
        }
    } 
