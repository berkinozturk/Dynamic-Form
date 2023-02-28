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
        

        public CustomerControl(Form f1)
        {
            InitializeComponent();
            form1 = f1;
           
        }
        private string name;
        private string address;
        private bool selected = false;
        private List<string> data = new List<string>();
        public static List<CustomerControl> SelectedItems { get; set; } = new List<CustomerControl>(); // bu liste selected item'ları tutacak
        


        public string Name { get { return name; } set { name = value; nameLabel.Text = name; } }
        public string Address { get { return address; } set { address = value; addressLabel.Text = address; } }
        public bool Selected { get { return selected; } set { selected = value; } }
        



        private void CustomerControl_Load(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }


        private void CustomerControl_MouseClick(object sender, MouseEventArgs e)
        {
            /* if ((Control.ModifierKeys & Keys.Control) != Keys.Control)
            {
                // Ctrl tuşu basılı değilse, önceki seçimleri kaldırın
                foreach (CustomerControl c in SelectedItems)
                {
                    c.BackColor = SystemColors.Control;
                }
                SelectedItems.Clear();
            } */


            // Seçilen öğelerin arkaplan renklerini ayarlama ve kaldırma
            if (SelectedItems.Contains(this))
            {
                SelectedItems.Remove(this);
                this.BackColor = SystemColors.Control;
            }
            else
            {
                SelectedItems.Add(this);
                this.BackColor = Color.Aqua;
            }
           
        }

        
    }
}
