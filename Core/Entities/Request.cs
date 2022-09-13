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
    public class Request : EntityBase
    {
        public Request()
        {
            RequestStatus = new List<RequestStatus>();
        }

        [Display(Name = "نوع درخواست")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string RequestType { get; set; }

        [Display(Name = "تاریخ درخواست")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime RequestDate { get; set; }

        [Display(Name = "شماره نامه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int LetterNo { get; set; }

        [Display(Name = "سری کاست")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int CassetteSeries { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? DMoneyType1 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? DMoneyCount1 { get; set; }

        [Display(Name = "مبلغ")]
        public double? DAmount1 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        public string? DAmountToString1 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? DMoneyType2 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? DMoneyCount2 { get; set; }

        [Display(Name = "مبلغ")]
        public double? DAmount2 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        public string? DAmountToString2 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? DMoneyType3 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? DMoneyCount3 { get; set; }

        [Display(Name = "مبلغ")]
        public double? DAmount3 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        public string? DAmountToString3 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? DMoneyType4 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? DMoneyCount4 { get; set; }

        [Display(Name = "مبلغ")]
        public double? DAmount4 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        public string? DAmountToString4 { get; set; }

        [Display(Name = "مبلغ کل")]
        public double? DTotalAmount { get; set; }

        [Display(Name = "مبلغ کل حروفی")]
        public string? DTotalAmountToString { get; set; }


        public ICollection<RequestStatus> RequestStatus { get; set; }


    }
}
