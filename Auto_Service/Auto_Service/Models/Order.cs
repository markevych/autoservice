using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auto_Service.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PostTime { get; set; }
        public string Owner { get; set; }
        public string CarName { get; set; }
        public string Address { get; set; }
    }
}