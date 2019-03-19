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
    public partial class Form1 :  Form
    {
        public frmAddPerson addperson = new frmAddPerson();
        public Form1 form1 = new Form1();
        public Form1()
        {
            InitializeComponent();
            
    }

        public void BtnCreateNewPerson_Click(object sender, EventArgs e)
        {

            addperson = new frmAddPerson(form1);
            addperson.Show();
           
        }

        private void btnPerson_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
