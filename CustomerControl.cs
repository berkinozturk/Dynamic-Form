using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp1
{
    public partial class CustomerControl : UserControl
    {
        Form form1;
        Form1 form2 = new Form1(); //form2 object from Form1 class


        public CustomerControl(Form f1)
        {
            InitializeComponent(); 
            form1 = f1;
            

        }
        private string name; //name variable
        private string address; // address variable



        public static List<CustomerControl> SelectedItems { get; set; } = new List<CustomerControl>(); // list variable of selected items



        public string Name { get { return name; } set { name = value; nameLabel.Text = name; } } //name variable getter & setter
        public string Address { get { return address; } set { address = value; addressLabel.Text = address; } } // address variable getter & setter




        private void CustomerControl_MouseClick(object sender, MouseEventArgs e)
        {
            /* if ((Control.ModifierKeys & Keys.Control) != Keys.Control)
            {
                // If Ctrl key is not pressed, remove previous selections
                foreach (CustomerControl c in SelectedItems)
                {
                    c.BackColor = SystemColors.Control;
                }
                SelectedItems.Clear();
            } */


            // If the item is selected, remove it from the list.
            if (SelectedItems.Contains(this))
            {
                SelectedItems.Remove(this);
                this.BackColor = SystemColors.Control;
            }
            else
            {
                SelectedItems.Add(this); //Add to list if item is not selected
                this.BackColor = Color.Aqua; //Paint the item's background color
            }

            // Get form2 instance
            Form1 form2 = (Form1)Application.OpenForms["Form1"];
                
            // Check number of selected items
            if (SelectedItems.Count == 1)
            {
                form2.enableButton(); //make button enable 
            }
            else
            {
                form2.disableButton(); //make button disable
            }

        }
        
    }
}
