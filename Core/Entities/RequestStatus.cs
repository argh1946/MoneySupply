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
        public virtual int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public virtual int RequestId { get; set; }
        public virtual Request Request { get; set; }

        [Display(Name = "توضیحات")]
        [MaxLength(400, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? Description { get; set; }

        [Display(Name = "تاریخ و ساعت")]
        public DateTime DateTime { get; set; }
        [Display(Name = "ویرایشگر")]
        public int Editor { get; set; }
    }
}
