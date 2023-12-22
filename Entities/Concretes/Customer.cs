using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes
{
    public class Customer:IEntity
    {
        public int CustomerId { get; set; }

        public int UserId { get; set; }

        public string CustomerName { get; set; }

        public string CustomerEmail { get; set; }

        public string CustomerPhone { get; set; }

        public string CustomerCity { get; set; }

        public string CompanyName { get; set; }






    }
}
