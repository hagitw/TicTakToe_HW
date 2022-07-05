using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTakToe_HW.Models
{
    public class SessionPlay
    {
        public int Id { get; set; }
        public int UserId { get; set; }       
        public Mode PlayMode { get; set; }
        //if game ongoing...
        public bool IsActiveSession { get; set; }

    }
}