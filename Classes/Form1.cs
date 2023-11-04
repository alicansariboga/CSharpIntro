using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<string> studentName = new List<string>() { "Ali Can", "Serkan", "Sena", "Derin" };
            List<int> studentAge = new List<int>() { 22, 26, 19, 12 };
            List<string> studentEmail = new List<string>() { "AliCan@example.com", "Serkan@example.com", "Sena@example.com", "Derin@example.com" };


            //liste uzunlugu ayni ise calisir.
            for (int i = 0; i < 3; i++)
            {
                //MessageBox.Show(studentName[i] + " " + studentAge[i] + " " + studentEmail[i]);
            }

            //ogrenci nesnesi ile islemler
            Student Ogrenci1 = new Student();
            Ogrenci1.FirstName = "Ali Can";
            Ogrenci1.Age = 22;
            Ogrenci1.Email = "AliCan@example.com";
            
            Student Ogrenci2 = new Student();
            Ogrenci2.FirstName = "Serkan";
            Ogrenci2.Age = 26;
            Ogrenci2.Email = "Serkan@example.com";

            Student Ogrenci3 = new Student();
            Ogrenci3.FirstName = "Sena";
            Ogrenci3.Age = 19;
            Ogrenci3.Email = "Sena@example.com";

            Student Ogrenci4 = new Student();
            Ogrenci4.FirstName = "Derin";
            Ogrenci4.Age = 12;
            Ogrenci4.Email = "Derin@example.com";


            List<Student> students = new List<Student>() { Ogrenci1, Ogrenci2, Ogrenci3, Ogrenci4 };

            foreach (var student in students)
            {
                //MessageBox.Show(student.FirstName + " " + student.Age + " " + student.Email);
                lbxStudents.Items.Add(student.FirstName);
            }

            dgrwStudents.DataSource = students;
        }
    }
}
