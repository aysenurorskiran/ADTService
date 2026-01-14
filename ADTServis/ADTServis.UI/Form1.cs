using ADTServis.BLL.Services;
namespace ADTServis.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var service = new CustomerService();
            dgvCustomers.DataSource = service.GetCustomers();

        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
