using CinemaTicketSalesAutomation.Enums;
using CinemaTicketSalesAutomation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaTicketSalesAutomation.Helpers
{
    public class Helper
    {
        public static List<Movie> CreateMovies()
        {
            string basePath = "C:/Users/iamyu/source/repos/CinemaTicketSalesAutomation/CinemaTicketSalesAutomation/Pictures/";

            return new List<Movie>()
            {
                new Movie()
                {
                    movieName="Hababam Sınıfı",
                    category=Category.komedi,
                    minute="2 saat 12 dk",
                    price=50,
                    picturePath=basePath+"chaos-class-again.jpg"


                },
                new Movie()
                {
                    movieName="Nefesini Tut 2",
                    category=Category.gerilim,
                    minute="2 saat 4 dk",
                    price=90,
                    picturePath=basePath+"don-t-breathe-2.jpg"
                },
                new Movie()
                {
                    movieName="Black Widow (Karadul)",
                    category=Category.bilim_kurgu,
                    minute="1 saat 12 dk",
                    price=70,
                    picturePath=basePath+"kara-dul-izle.jpg"
                },
                 new Movie()
                {
                    movieName="Mortal kombat efsanenin dönüşü",
                    category=Category.fantastik,
                    minute="1 saat 57 dk",
                    price=40,
                    picturePath=basePath+"mortal-kombat-legends-battle-of-the-realms.jpg"
                },
                  
                new Movie()
                {
                    movieName="Orman Gezisi",
                    category=Category.komedi,
                    minute="1 saat 12 dk",
                    price=50,
                    picturePath=basePath+"orman-gezisi-izle.jpg"
                },
                   
                new Movie()
                {
                    movieName="Superost",
                    category=Category.gerilim,
                    minute="1 saat 12 dk",
                    price=150,
                    picturePath=basePath+"superhost.jpg"
                }

            };
        }


    }
}
