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
using System.Drawing.Drawing2D;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        protected override CreateParams CreateParams //this code make our form draggable without any glitch, perfect resize.
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }
        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.MediumTurquoise;

        }

        //initiliaze variables
        public List<string> name = new List<string>(); 
        public List<string> address = new List<string>();
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragPanelPoint;
        private Point dragFormPoint;
        public static CustomerControl[] list; //list variable 
        

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            flowLayoutPanel1.AutoScroll = true; //scroll feature
            flowLayoutPanel1.VerticalScroll.Visible = true; //make visible the scroll
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            
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

        public void button2_Click(object sender, EventArgs e) //Show name button - display the selected data name
        {
            
            foreach (CustomerControl c in CustomerControl.SelectedItems)
            {
                if (CustomerControl.SelectedItems.Count == 1)  {
                    MessageBox.Show(c.Name);
                }
              
            }
        }
       public void disableButton() //make button disabled
        {
            siticoneGradientButton2.Enabled = false;
        }
        public void enableButton() //make button enabled
        {
            siticoneGradientButton2.Enabled = true;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) // Panel MouseDown 
        {
            
            if (e.Button == MouseButtons.Left) // Only left-clicks of mouse
            {
                // Save the position of the dragging mouse cursor, the original position of the panel,
                // and the original position of the form when the drag operation is initiated
                dragging = true;
                dragCursorPoint = Cursor.Position;
                dragPanelPoint = panel1.Location;
                dragFormPoint = this.Location;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                // During the drag operation, update the position of the panel and the position of the form,
                // taking the difference between the mouse position and the original position of the panel
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                panel1.Location = Point.Add(dragPanelPoint, new Size(dif));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                dragging = false; // When the drag is finished, set the drag state to false to end the process
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close(); // terminate the program
        }

    }


}

