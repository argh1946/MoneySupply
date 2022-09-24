using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.DTOs
{
    public class MoneyTypeVM
    {       
        public string Title { get; set; }       
        public double Amount { get; set; }       
        public bool IsActive { get; set; }
    }
}
