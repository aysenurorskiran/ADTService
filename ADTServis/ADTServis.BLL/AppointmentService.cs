using ADTServis.DAL.Repositories;
using ADTServis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTServis.BLL
{
    public class AppointmentService
    {
        AppointmentRepository appointmentRepository = new AppointmentRepository();
        public void Add(Appointment appointment) 
        {
            appointmentRepository.Add(appointment);
        }
        public List<Appointment> GetAll() 
        { 
            return appointmentRepository.GetAll();
        }
    }

}
