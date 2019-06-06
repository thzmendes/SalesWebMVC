using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Department(int iD, string name)
        {
            ID = iD;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
