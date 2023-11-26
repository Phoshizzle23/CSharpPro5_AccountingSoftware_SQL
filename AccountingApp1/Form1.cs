using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace AccountingApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5KJ157N\\MATTDATABASEPRO;Initial Catalog=accountingdb;Persist Security Info=True;User ID=sa;Password=1234qwer");

            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into accountable values(@clientid,@clientname,@date,@address,@total)", con);

            cnn.Parameters.AddWithValue(@"ClientId", int.Parse(clientIdText.Text));

            cnn.Parameters.AddWithValue(@"ClientName", (clientNameText.Text));

            cnn.Parameters.AddWithValue(@"Date", (dateText.Text));

            cnn.Parameters.AddWithValue(@"Address", (addressText.Text));

            cnn.Parameters.AddWithValue(@"Total", (totalText.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Saved!");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5KJ157N\\MATTDATABASEPRO;Initial Catalog=accountingdb;Persist Security Info=True;User ID=sa;Password=1234qwer");

            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from accountable", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5KJ157N\\MATTDATABASEPRO;Initial Catalog=accountingdb;Persist Security Info=True;User ID=sa;Password=1234qwer");

            con.Open();

            SqlCommand cnn = new SqlCommand("Update accountable Set clientid=@clientid,clientname=@clientname,date=@date,address=@address,total=@total where clientid=@clientid", con);

            cnn.Parameters.AddWithValue(@"ClientId", int.Parse(clientIdText.Text));

            cnn.Parameters.AddWithValue(@"ClientName", (clientNameText.Text));

            cnn.Parameters.AddWithValue(@"Date", (dateText.Text));

            cnn.Parameters.AddWithValue(@"Address", (addressText.Text));

            cnn.Parameters.AddWithValue(@"Total", (totalText.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Updated!");
        }

        private void displayBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5KJ157N\\MATTDATABASEPRO;Initial Catalog=accountingdb;Persist Security Info=True;User ID=sa;Password=1234qwer");

            con.Open();

            SqlCommand cnn = new SqlCommand("Select * from accountable", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable table = new DataTable();

            da.Fill(table);

            dataGridView1.DataSource = table;

            con.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5KJ157N\\MATTDATABASEPRO;Initial Catalog=accountingdb;Persist Security Info=True;User ID=sa;Password=1234qwer");

            con.Open();

            SqlCommand cnn = new SqlCommand("Delete accountable where clientid=@clientid", con);

            cnn.Parameters.AddWithValue(@"ClientId", int.Parse(clientIdText.Text));

            cnn.Parameters.AddWithValue(@"ClientName", (clientNameText.Text));

            cnn.Parameters.AddWithValue(@"Date", (dateText.Text));

            cnn.Parameters.AddWithValue(@"Address", (addressText.Text));

            cnn.Parameters.AddWithValue(@"Total", (totalText.Text));

            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Deleted!");
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clientIdText.Text = "";
            clientNameText.Text = "";
            dateText.Text = "";
            addressText.Text = "";
            totalText.Text = "";
        }
    }
}