using ADTServis.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADTServis.UI
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            var service = new CustomerService();
            dgvCostumers.AutoGenerateColumns = true;
            dgvCostumers.DataSource = service.GetCustomers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CostumerAddForm frm = new CostumerAddForm();
            frm.ShowDialog();

            CustomerService service = new CustomerService();
            dgvCostumers.DataSource = service.GetCustomers();
        }
    }
}
