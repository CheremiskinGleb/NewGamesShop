using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop.Model
{
    public class Reviews
    {
        public Reviews()
        {
        }
        public int Id { get; set; }
        public decimal Rating { get; set; }
        public string Comment { get; set; }
        public string UserId { get; set; }
        public int GameId { get; set; }
    }
}
