using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSalesAutomation.Models
{
   public  class Session
    {
        public Session()
        {
            SetDefaultChairs();
        }


        public string date { get; set; }
        public string time { get; set; }
        public List<Chair> chairs { get; set; }

        private void SetDefaultChairs()
        {
            chairs = new List<Chair>();
            string[] rows = { "A", "B", "C", "D" };
            string[] numbers = { "1", "2", "3", "4", "5", "6" };
            foreach (var row in rows)
            {
                foreach (var number in numbers)
                {
                    Chair chair = new Chair(row,number);
                    chairs.Add(chair);
                }
            }
        }
    }
}
