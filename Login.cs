using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BillOfQuantity
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il faut créer la fonctionnalité");
        }

        private void locateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vous avez choisi Locate");
        }
    }
}
