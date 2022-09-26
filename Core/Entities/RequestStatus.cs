using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Contracts;

namespace Core.Entities
{
    public class RequestStatus : BaseEntity
    {
        public int StatusId { get; set; }
        public int RequestId { get; set; }

        [Display(Name = "توضیحات")]
        [MaxLength(400, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Description { get; set; }

        [Display(Name = "تاریخ و ساعت")]
        public DateTime DateTime { get; set; }
    }
}
