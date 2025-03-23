using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class GameDevice
    {
        public int GameId { get; set; }
        public Game game { get; set; }
        public int deviceId { get; set; }
        public Devices devices { get; set; }
    }
}
