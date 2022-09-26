using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.DTOs
{

    public class RequestEfardaVM
    {
        public int AtmCrsId { get; set; }
        public int StatusId { get; set; }        
        public string RequestType { get; set; }       
        public DateTime RequestDate { get; set; }    
        public int LetterNo { get; set; }     
        public int CassetteSeries { get; set; }

        public string? Description { get; set; }
    }
}
