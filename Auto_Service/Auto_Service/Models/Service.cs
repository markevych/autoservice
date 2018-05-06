using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auto_Service.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Owner { get; set; }
        public string Address { get; set; }

        public Service() { }
        public Service(string _name, string _description, string _owner, string _address)
        {
            Name = _name;
            Description = _description;
            Owner = _owner;
            Address = _address;
        }
    }
}