using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;

namespace UpdateOnQueryResult
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        // get all gender values from DB
        public void getValues()
        {
            
            List<int> values = new List<int>();
            SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=TestDB;Integrated Security=True");
            conn.Open();

            SqlCommand command = new SqlCommand("Select * from Persons", conn);
            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int eee = (int)reader["Gender"];
                    if(eee != 2)
                    {
                        getValues();
                    }
                }
            }
            
            conn.Close();
            Thread.Sleep(2000);
        }

        // check if all values is 2
        public bool checkValues(List<int> listOfValues)
        {
            bool result = true;
            foreach(int value in listOfValues)
            {
                if(value != 2)
                {
                    result = false;
                }
            }
            return result;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            getValues();
        }
    }
}
