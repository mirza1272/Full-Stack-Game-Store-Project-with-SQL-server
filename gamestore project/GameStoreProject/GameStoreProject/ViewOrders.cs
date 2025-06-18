using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStoreProject
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            
        }

        private void vieworderdetailsbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            vieworderdetails orderDetailsForm = new vieworderdetails();
            orderDetailsForm.Show();
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void gotoadminpagebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }
    }
}