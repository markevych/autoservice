using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoService.Models
{
    public class Advertisement
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
    }
}
