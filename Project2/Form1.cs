using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //global tanimlama. Diger yerlerde de erisilebilir.
        List<string> students;
        private void Form1_Load(object sender, EventArgs e)
        {
            students = new List<string>() {"Ali Can Sariboga","Ahmet Anil","Gokturk Boz" };

            foreach (var student in students)
            {
                lbxStudentList.Items.Add(student);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if(tbxStudentName.Text.Length >= 2)
            {
                students.Add(tbxStudentName.Text);
                lbxStudentList.Items.Clear();

                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                    tbxStudentName.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Ogrenci ismi en az 2 karakterden olusmalidir.");
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if(lbxStudentList.SelectedItem != null)
            {
                students.Remove(lbxStudentList.SelectedItem.ToString());
                lbxStudentList.Items.Clear();

                foreach (var student in students)
                {
                    lbxStudentList.Items.Add(student);
                }
            }
            else
            {
                MessageBox.Show("Lutfen seciminizi yapiniz.");
            }
        }
    }
}
