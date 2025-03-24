using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoKolcsonzes.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CarId { get; set; }
        public int TotalPrice { get; set; }
        public string UserUID  { get; set; }

        public Booking(string sor)
        {
            var t= sor.Split(";");

            Id = Convert.ToInt32(t[0]);
            StartDate = Convert.ToDateTime(t[1]);
            EndDate = Convert.ToDateTime(t[2]); 
            CarId = Convert.ToInt32(t[3]);
            TotalPrice = Convert.ToInt32(t[4]); ;
            UserUID = t[5];
        }

        public override string? ToString()
        {
            return $"{CarId} ({StartDate:yyyy-MM-dd} - {EndDate:yyyy-MM-dd}";
        }
    }
}
