  using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TicTakToe_HW.Models;

namespace TicTakToe_HW.Controllers
{
    public class GameController : ApiController
    {
        /// <summary>  
        /// create board
        /// and SessionId
        /// </summary>
        /// <returns>SessionId</returns>
        public string InitGame(string playerName, Level level, Mode mode)
        {
            Session["UserId"] = "ddd";
            //Session[""]
            return "SessionId";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="playerName"></param>
        /// <param name="level"></param>
        /// <param name="mode"></param>
        public string[] MovePlay(string SessionId, string Postionxy)
        {
            return new string[] { "play board" }; // if win so winner sessionID
        }
      
    }
}
