using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicTakToe_HW.Models
{
    public class GameBoards
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public int UserId { get; set; }
        public int Move { get; set; }

    }
}