using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public string Name { get { return name; } set { name = value; nameLabel.Text = name; } }
        public string Address { get { return address; } set { address = value; addressLabel.Text = address; } }


        private void CustomerControl_Load(object sender, EventArgs e)
        {

        }
    }
}
