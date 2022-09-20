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
    public class Status : BaseEntity
    {
        public Status()
        {
            RequestStatus = new List<RequestStatus>();
            Request = new List<Request>();
        }
       
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Title { get; set; }
                

        public ICollection<RequestStatus> RequestStatus { get; set; }
        public ICollection<Request> Request { get; set; }



    }
}
