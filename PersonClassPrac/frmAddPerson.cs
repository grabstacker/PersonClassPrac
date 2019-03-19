using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonClassPrac
{
    public partial class frmAddPerson : Form
    {
        public Person person1;
        public Form _Form1;
        public frmAddPerson()
        {
            InitializeComponent();
            
        }
        public frmAddPerson(Form form1)
        {
            InitializeComponent();
            _Form1 = form1;
        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtEyeColor.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("Please enter all details before clicking submit!");
            }
            else
            {
                
                person1.FirstName = txtFirstName.Text;
                person1.LastName = txtLastName.Text;
                person1.EyeColor = txtEyeColor.Text;
                person1.Age = Convert.ToInt32(txtAge.Text);  
                
                MessageBox.Show("New Person added Successfully!" + person1.EyeColor);             
                this.Close();
            }
            
        }
    }
}
