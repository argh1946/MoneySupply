using Core.Contracts;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Branch : BaseEntity
    {
        [Display(Name = "کد شعبه")]
        public string Code { get; set; }
        [Display(Name = "نام شعبه")]
        public string Name { get; set; }
    }
}
