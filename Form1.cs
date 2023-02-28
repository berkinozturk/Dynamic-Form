using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static CustomerControl[] list;
        private CustomerControl selectedCustomerControl;
        private CustomerControl CustomerControl_MouseClick;
        
        



        public Form1()
        {
            InitializeComponent();
        }

        public List<string> name = new List<string>();
        public List<string> address = new List<string>();
        



        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            
            

        }
       


        private void LoadData()
        {
            string connectionString = "Data Source=DESKTOP-CROD6B4;Initial Catalog=deneme;Integrated Security=True;";

            string query = "SELECT * FROM deneme4";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    name.Add(reader.GetString(0));
                    address.Add(reader.GetString(1));

                    list = new CustomerControl[name.Count];
                    for (int i = 0; i < name.Count; i++)
                    {
                        list[i] = new CustomerControl(this);
                        list[i].Name = name[i];
                        list[i].Address = address[i];
                        if (flowLayoutPanel1.Controls.Count < 0)
                        {
                            flowLayoutPanel1.Controls.Clear();
                        }
                        else
                        {
                            flowLayoutPanel1.Controls.Add(list[i]);
                        }
                    }
                }

                reader.Close();
                connection.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (CustomerControl c in CustomerControl.SelectedItems)
            {
                flowLayoutPanel1.Controls.Remove(c);
            }
            CustomerControl.SelectedItems.Clear();
        }




        /* private void label1_Click(object sender, EventArgs e)
         {
             // Seçilen müşterinin adını ve adresini MessageBox'ta göster
             string message = $"Selected Customer: {selectedCustomerControl.Name}, {selectedCustomerControl.Address}";
             MessageBox.Show(message);

         } */
    }

}

