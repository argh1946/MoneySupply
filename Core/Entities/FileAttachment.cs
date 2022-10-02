using Core.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Entities
{
    public class FileAttachment : BaseEntity
    {
        public int RequestId { get; set; }

        [Display(Name = "عنوان فایل")]
        [MaxLength(50, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Title { get; set; }

        [Display(Name = "نوع فایل")]
        public int FileType { get; set; }

        [Display(Name = "فایل")]
        public byte[] FileArrey { get; set; }
    }
}
