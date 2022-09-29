using System.Diagnostics;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.DirectoryServices.ActiveDirectory;

namespace WaitQuery
{
    public partial class Form1 : Form
    {
        //Diyar Laptop Connection
        //SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=180;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //Personal Laptop Connection
        SqlConnection conn = new SqlConnection("Data Source=localhost;Initial Catalog=TestDB;User ID=sa;Password=P@ssw0rd;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        List<int> dbValues = new List<int>();
        public Form1()
        {
            InitializeComponent();
            init();
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            checkFillingValues();

            while (true)
            {
                dbValues.Clear();
                await SomeLongTask();
                if (dbValues.Contains(Convert.ToInt32(txtVal1.Text)))
                {
                    await SomeLongTask();
                    lblMsg.Text = "Please Wait ...... ";
                    lblMsg.BackColor = Color.Transparent;
                }
                else
                {
                    foreach (int i in dbValues)
                    {
                        lbResult.Items.Add(i);
                    }
                    lblMsg.Text = "Done..";
                    lblMsg.BackColor = Color.Green;
                    break;
                }

            }

            async Task SomeLongTask()
            {
                conn.Open();
                SqlCommand command = new SqlCommand(txtQueryString.Text, conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        foreach (var i in reader)
                        {
                            dbValues.Add((int)reader[txtCol1.Text]);
                        }
                    }
                }
                conn.Close();
                await Task.Delay(Convert.ToInt32(txtWaitingMin));
            }


        }
        private void checkFillingValues()
        {
            if (string.IsNullOrEmpty(txtQueryString.Text) || string.IsNullOrEmpty(txtCol1.Text) 
                || string.IsNullOrEmpty(txtVal1.Text) || string.IsNullOrEmpty(txtWaitingMin.Text)
                || cbRunType.SelectedIndex.Equals(0))
            {
                MessageBox.Show("You have to fill query string, Column name, Values name and Waiting time", "Missing Field", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void init()
        {
            txtRunQuery.Visible = false;
        }

        private void cbRunType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbRunType.SelectedIndex == 1)
            {
                txtRunQuery.Visible = true;
            }
            if (cbRunType.SelectedIndex == 1)
            {
                txtRunQuery.Visible = false;
            }
        }
    }
}