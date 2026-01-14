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
using ADTServis.Entities;
using ADTServis.BLL.Services;

namespace ADTServis.UI
{
    public partial class CostumerAddForm : Form
    {
        public CostumerAddForm()
        {

            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            
            c.FullName = txtFullName.Text;
            c.Phone = txtPhone.Text;
            c.Plate = txtPlate.Text;
            c.CarBrand = txtCarBrand.Text;
            c.CarModel = txtCarModel.Text;

            CustomerService service = new CustomerService();
            service.AddCustomer(c);

            MessageBox.Show("Müşteri eklendi abi");
            this.Close();
        }
    }
}
