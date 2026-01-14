using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADTServis.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Note { get; set; }
        public string Status { get; set; }

    }
}
