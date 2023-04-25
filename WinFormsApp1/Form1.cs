using System.ComponentModel.DataAnnotations.Schema;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Controller database;
        public Form1()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database = new Controller("Server = COM-20220903RZR\\SQLEXPRESS: " +
                "Trusted_Connection=true;" +
                "Database=northwing;" +
                "User Instance=false;" +
                "Connection timeout=30");

            MessageBox.Show("Connection information sent");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string count = database.getCustomerCount();
            MessageBox.Show(count, "Customer Count");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string names = database.getCompanyNames();
            MessageBox.Show(names, "Company names");
        }
    }
}