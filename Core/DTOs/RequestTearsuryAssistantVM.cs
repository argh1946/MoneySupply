using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.DTOs
{

    public class RequestTearsuryAssistantInput
    {
        public int Id { get; set; }
        public int AtmCrsId { get; set; }

        [Display(Name = "نوع درخواست")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(5, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string RequestType { get; set; }

        [Display(Name = "تاریخ درخواست")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public DateTime RequestDate { get; set; }

        [Display(Name = "شماره نامه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public int LetterNo { get; set; }

        [Display(Name = "مانده دستگاه")]
        public int Remaining { get; set; }

        [Display(Name = "فزونی دستگاه")]
        public int Excess { get; set; }


        #region اسکناس تسویه

        [Display(Name = "نوع اسکناس")]
        public int? CMoneyType1 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? CMoneyCount1 { get; set; }

        [Display(Name = "مبلغ")]
        public double? CAmount1 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? CAmountToString1 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? CMoneyType2 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? CMoneyCount2 { get; set; }

        [Display(Name = "مبلغ")]
        public double? CAmount2 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? CAmountToString2 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? CMoneyType3 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? CMoneyCount3 { get; set; }

        [Display(Name = "مبلغ")]
        public double? CAmount3 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? CAmountToString3 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? CMoneyType4 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? CMoneyCount4 { get; set; }

        [Display(Name = "مبلغ")]
        public double? CAmount4 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? CAmountToString4 { get; set; }

        [Display(Name = "مبلغ کل")]
        public double? CTotalAmount { get; set; }

        [Display(Name = "مبلغ کل حروفی")]
        public string? CTotalAmountToString { get; set; }

        #endregion

        #region اسکناس ریجکت

        [Display(Name = "نوع اسکناس")]
        public int? RjMoneyType1 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? RjMoneyCount1 { get; set; }

        [Display(Name = "مبلغ")]
        public double? RjAmount1 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? RjAmountToString1 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? RjMoneyType2 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? RjMoneyCount2 { get; set; }

        [Display(Name = "مبلغ")]
        public double? RjAmount2 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? RjAmountToString2 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? RjMoneyType3 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? RjMoneyCount3 { get; set; }

        [Display(Name = "مبلغ")]
        public double? RjAmount3 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? RjAmountToString3 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? RjMoneyType4 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? RjMoneyCount4 { get; set; }

        [Display(Name = "مبلغ")]
        public double? RjAmount4 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? RjAmountToString4 { get; set; }

        [Display(Name = "مبلغ کل")]
        public double? RjTotalAmount { get; set; }

        [Display(Name = "مبلغ کل حروفی")]
        public string? RjTotalAmountToString { get; set; }

        #endregion

        #region اسکناس ریترکت

        [Display(Name = "نوع اسکناس")]
        public int? RtMoneyType1 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? RtMoneyCount1 { get; set; }

        [Display(Name = "مبلغ")]
        public double? RtAmount1 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? RtAmountToString1 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? RtMoneyType2 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? RtMoneyCount2 { get; set; }

        [Display(Name = "مبلغ")]
        public double? RtAmount2 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? RtAmountToString2 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? RtMoneyType3 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? RtMoneyCount3 { get; set; }

        [Display(Name = "مبلغ")]
        public double? RtAmount3 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? RtAmountToString3 { get; set; }

        [Display(Name = "نوع اسکناس")]
        public int? RtMoneyType4 { get; set; }

        [Display(Name = "تعداد برگ اسکناس")]
        public int? RtMoneyCount4 { get; set; }

        [Display(Name = "مبلغ")]
        public double? RtAmount4 { get; set; }

        [Display(Name = "مبلغ حروفی")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string? RtAmountToString4 { get; set; }

        [Display(Name = "مبلغ کل")]
        public double? RtTotalAmount { get; set; }

        [Display(Name = "مبلغ کل حروفی")]
        public string? RtTotalAmountToString { get; set; }

        #endregion




    }

}
