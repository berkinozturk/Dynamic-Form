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
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.VerticalScroll.Visible = true;
            
            
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
                    string currentName = reader.GetString(0);
                    string currentAddress = reader.GetString(1);

                    if (!name.Contains(currentName) && !address.Contains(currentAddress))
                    {
                        name.Add(currentName);
                        address.Add(currentAddress);

                        CustomerControl newCustomer = new CustomerControl(this);
                        newCustomer.Name = currentName;
                        newCustomer.Address = currentAddress;
                        flowLayoutPanel1.Controls.Add(newCustomer);
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

        

        private void button2_Click(object sender, EventArgs e)
        {

            var customerControl = (CustomerControl)sender;
            bool isSelected = !customerControl.IsSelected;

            // Tüm müşteri kontrol seçimlerini kaldır ve seçileni güncelle
            foreach (var control in flowLayoutPanel1.Controls.OfType<CustomerControl>())
            {
                control.IsSelected = false;
            }

            customerControl.IsSelected = isSelected;

            // Seçili müşteri kontrol sayısını al
            int selectedCount = flowLayoutPanel1.Controls.OfType<CustomerControl>().Count(x => x.IsSelected);

            // Sadece 1 tane müşteri seçilmiş ise
            if (selectedCount == 1)
            {
                button2.Enabled = true;
                button2.FlatStyle = FlatStyle.Standard;

                // Seçilen müşteriyi bul ve ismini MessageBox'ta göster
                selectedCustomerControl = flowLayoutPanel1.Controls.OfType<CustomerControl>().FirstOrDefault(x => x.IsSelected);
                MessageBox.Show(selectedCustomerControl.Name);
            }
            else 
            {
                button2.Enabled=false;
                button2.FlatStyle = FlatStyle.Flat;
                
            }

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button2_EnabledChanged(object sender, EventArgs e)
        {
           
        }
    }

}

