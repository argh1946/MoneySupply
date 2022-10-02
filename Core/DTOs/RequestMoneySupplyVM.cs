using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.DTOs
{

    public class RequestMoneySupplyVM
    {
        public int AtmCrsId { get; set; }
        public int StatusId { get; set; }        
        public string RequestType { get; set; }       
        public DateTime RequestDate { get; set; }    
        public int LetterNo { get; set; }     
        public int CassetteSeries { get; set; }
    }

    public class RequestMoneySupplyInput
    {
        public int AtmCrsId { get; set; }

        [Display(Name = "نوع درخواست")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(5, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string RequestType { get; set; }

        [Display(Name = "تاریخ درخواست")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string RequestDate { get; set; }        

        [Display(Name = "سری کاست")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int CassetteSeries { get; set; }        

        #region اسکناس تحویل

        [Display(Name = "نوع اسکناس")]
        public int? DMoneyType1 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? DMoneyCount1 { get; set; }

        [Display(Name = "مبلغ")]
        public double? DAmount1 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? DAmountToString1 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? DMoneyType2 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? DMoneyCount2 { get; set; }

        [Display(Name = "مبلغ")]
        public double? DAmount2 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? DAmountToString2 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? DMoneyType3 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? DMoneyCount3 { get; set; }

        [Display(Name = "مبلغ")]
        public double? DAmount3 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? DAmountToString3 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? DMoneyType4 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? DMoneyCount4 { get; set; }

        [Display(Name = "مبلغ")]
        public double? DAmount4 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? DAmountToString4 { get; set; }

        [Display(Name = "مبلغ کل")]
        public double? DTotalAmount { get; set; }

        [Display(Name = "مبلغ کل حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? DTotalAmountToString { get; set; }

        #endregion

    }


}
