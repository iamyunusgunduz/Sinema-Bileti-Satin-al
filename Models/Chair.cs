﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSalesAutomation.Models
{

   public  class Chair
    {
        public string row { get; set; }
        public string number { get; set; }
        public bool status { get; set; }

        public Chair(string _row,string _number)
        {
            row = _row;
            number = _number;
        }



       
    }
 
}

