using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Game:BaseEntity
    {
        public string Descreption { get; set; } = string.Empty;
        public string Cover { get; set; } = string.Empty;
        public string Video { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category category { get; set; } = default!;
        public List<GameDevice> devices { get; set; }

    }
}
