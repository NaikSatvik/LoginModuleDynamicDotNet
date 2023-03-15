using LoginRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankDynamic
{
    public partial class landingForm : Form
    {
        app lgn = new app();
        public landingForm()
        {
            InitializeComponent();
        }

        private void landingForm_Load(object sender, EventArgs e)
        {
            this.welcomeMsg.Text = "Welcome " + lgn.userId;
        }

        private void editProfileBtn_Click(object sender, EventArgs e)
        {
        }
    }
}
