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
        public static CustomerControl[] list; //list variable 
        private Point lastLocation;




        public Form1()
        {
            InitializeComponent();
           
        }
        //initiliaze variables
        public List<string> name = new List<string>(); 
        public List<string> address = new List<string>();
        

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            flowLayoutPanel1.AutoScroll = true; //scroll feature
            flowLayoutPanel1.VerticalScroll.Visible = true; //make visible the scroll
            
            
            
        }

        private void LoadData() //Database Connection and get data from SQL Server to display on flow layout panel.
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

        private void button1_Click(object sender, EventArgs e) //Delete button - when you select data and click button it removes data from panel.
        {
            foreach (CustomerControl c in CustomerControl.SelectedItems)
            {
                flowLayoutPanel1.Controls.Remove(c);
            }
            CustomerControl.SelectedItems.Clear();
        }

        

        public void button2_Click(object sender, EventArgs e)
        {
            
            foreach (CustomerControl c in CustomerControl.SelectedItems)
            {
                if (CustomerControl.SelectedItems.Count == 1)  {
                    MessageBox.Show(c.Name);
                }
                
                
            }
        }
       public void disableButton()
        {
            button2.Enabled = false;
        }
        public void enableButton()
        {
            button2.Enabled = true;
        }



        private void Form1_MouseDown(object sender, MouseEventArgs e) //fare tıklamasıyla formun bulunduğu son konumu kaydeder.
        {
            if (e.Button == MouseButtons.Left && e.Y <= panel1.Height)
            {
                lastLocation = e.Location;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e) //sol fare düğmesi basılıyken formu sürüklemenizi sağlar
        {
            if (e.Button == MouseButtons.Left && e.Y <= panel1.Height)
            {
                this.Left += e.X - lastLocation.X;
                this.Top += e.Y - lastLocation.Y;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e) //fare düğmesinin serbest bırakılmasıyla son konum kaydının sıfırlanmasını sağlar.
        {
            lastLocation = Point.Empty;

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = DefaultBackColor;

        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.BackColor = Color.Yellow;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = DefaultBackColor;
        }
    }


}

