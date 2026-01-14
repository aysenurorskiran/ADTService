using ADTServis.BLL;
using ADTServis.Entities;
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
    public partial class AppointmentsForm : Form
    {
        CustomerService customerService = new CustomerService();
        AppointmentService appointmentService = new AppointmentService();
        CustomerService costumerService = new CustomerService();
        


        public AppointmentsForm()
        {
          
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            cmbCustomer.DataSource = customerService.GetAll();
            cmbCustomer.DisplayMember = "FullName";
            cmbCustomer.ValueMember = "Id";
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Bekliyor");
            cmbStatus.Items.Add("Tamamlandı");
            cmbStatus.Items.Add("İptal");
            cmbStatus.SelectedIndex = 0;

            var list = appointmentService.GetAll();
            MessageBox.Show("Randevu sayısı: " + list.Count);
            dgvAppointments.DataSource = list;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Appointment a = new Appointment();
            a.CustomerId = Convert.ToInt32(cmbCustomer.SelectedValue);
            a.AppointmentDate = dtpDate.Value;
            a.Note = txtNote.Text;
            a.Status = cmbStatus.SelectedItem.ToString();
           


            appointmentService.Add(a);

            txtNote.Text = "";
            cmbStatus.SelectedIndex = 0;

            void LoadAppointments() 
            {
                dgvAppointments.DataSource = appointmentService.GetAll();
            }
            MessageBox.Show("Randevu kaydedildi.");

            


        }
    }
}
