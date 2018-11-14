using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ANJYAssignment3.Models
{
    public class Foods
    {
        [Key]
        public long Food_id { get; set; }
        public string FoodName { get; set; }
        public string recipe { get; set; }
        public string description { get; set; }

    }
}
