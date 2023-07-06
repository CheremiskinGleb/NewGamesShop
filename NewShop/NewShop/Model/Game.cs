using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop.Model
{
    public class Games
    {
        public Games()
        {
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Developer { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
		public int Price { get; set; }
        public string File { get; set; }
	}
}
