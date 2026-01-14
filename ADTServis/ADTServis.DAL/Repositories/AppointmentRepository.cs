using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using ADTServis.Entities;
using ADTServis.DAL.Db;


namespace ADTServis.DAL.Repositories
{
    public class AppointmentRepository
    {
        public void Add(Appointment a)
        {
            MySqlConnection conn = DbConnectionFactory.Create();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand();
            string dt = a.AppointmentDate.ToString();
            string note;
            if (a.Note == null)
                note = "";
            else
                note = a.Note;
            string status;
            if (a.Status == null)
                status = "Bekliyor";
            else
                status = a.Status;
            cmd.CommandText = "INSERT INTO Appointments (CostumerId,AppointmentDate,Note,Status) VAlUES(" + a.CustomerId + ", '" + dt + "','" + note + "', '" + status + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Appointment> GetAll()
        {
            List<Appointment> list = new List<Appointment>();
            MySqlConnection conn = DbConnectionFactory.Create();
            conn.Open();

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT Id,CuustomerId,AppointmentDate,Note,Status FROM Appointments ORDER BY AppointmentDate DESC";

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Appointment a = new Appointment();
                a.Id = Convert.ToInt32(reader["Id"]);
                a.CustomerId = Convert.ToInt32(reader["CustomerId"]);
                a.AppointmentDate = Convert.ToDateTime(reader["AppointmrntDate"]);
                a.Note = reader["Note"].ToString();
                a.Status = reader["Status"].ToString();
                list.Add(a);
            }
            conn.Close();
            return list;
        }
    }
}
