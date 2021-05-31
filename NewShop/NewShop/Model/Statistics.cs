using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop.Model
{
    public class Statistics
    {
        public Statistics()
        {
            NumberReviews = "NumberReviews";
            PositiveReviews = "NumberPositiveReviews";
            NegativeReviews = "NumberNegativeReviews";
        }
        public int StatisticsId { get; set; }
        public string NumberReviews { get; set; }
        public string PositiveReviews { get; set; }
        public string NegativeReviews { get; set; }
    }
}
