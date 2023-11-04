using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Ayni nesnenin btnAdd icerisinde de kullanilmasi gerekir. Bu yuzden public tanimlanir.
        CustomerManager customerManager = new CustomerManager();

        private void Form1_Load(object sender, EventArgs e)
        {
            dgrwCustomers.DataSource = customerManager.GetAll();

            dgrwCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Add isleminde donecek olan customer nesnesi. Bunun icin oncelikle textbox lardan gelen verinin bir nesneye donusturulmesi gerekir.
            Customer customer = new Customer();
            customer.Id = Convert.ToInt32(tbxId.Text);
            customer.FirstName = tbxFirstName.Text;
            customer.LastName = tbxLastName.Text;
            customer.City = tbxCity.Text;
            customer.Email = tbxEmail.Text;

            customerManager.Add(customer);

            dgrwCustomers.DataSource = null;
            //Tabloyu tekrar guncelleme
            dgrwCustomers.DataSource = customerManager.GetAll();

            MessageBox.Show("Kullanici basarili bir sekilde eklendi.");
        }
    }
}
