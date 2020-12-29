using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGE_Classes;

namespace DGE_Classes
{
    public class Session
    {
        public DateTime dateTimeEntered { get; set; }
        public DateTime dateTimeLeft { get; set; }
        public string roomID { get; set; }
        public string sessionType { get; set; }
        public string userID { get; set; }

        public string session { get { return (this.dateTimeLeft.ToShortDateString() + this.dateTimeEntered.ToShortDateString()); } }


    }

}
