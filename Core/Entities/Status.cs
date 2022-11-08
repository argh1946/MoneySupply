using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Contracts;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Core.Entities
{
    public class Status : BaseEntity
    {

        //[Display(Name = "عنوان")]
        //[Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        //[MaxLength(150, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Title { get; set; }        
        //public string name { get; set; }        
    }

    public class StatusCfg : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.ToTable("Status");
            //builder.Property(t => t.name).HasColumnType("nvarchar").HasMaxLength(150);
            builder.Property(t => t.Title).HasColumnType("nvarchar").HasMaxLength(150).IsRequired();
            builder.HasData(
                   new Status { Id = 1, Title = "تایید نماینده پول رسان" },
                   new Status { Id = 2, Title = "تایید ارتباط فردا" },
                   new Status { Id = 3, Title = "تایید مدیر گروه خزانه" },
                   new Status { Id = 4, Title = "تایید حسابدار خزانه" },
                   new Status { Id = 5, Title = "تایید اداره عملیات" },
                   new Status { Id = 6, Title = "تایید معاون گروه خزانه - تسویه" },
                   new Status { Id = 7, Title = "تایید پول رسان - تسویه" },
                   new Status { Id = 8, Title = "تایید مدیر گروه خزانه - تسویه" },
                   new Status { Id = 9, Title = "تایید حسابدار خزانه - تسویه" },
                   new Status { Id = 10, Title = "تایید اداره عملیات - تسویه" },
                   new Status { Id = 11, Title = "رد نماینده پول رسان" },
                   new Status { Id = 12, Title = "رد ارتباط فردا" },
                   new Status { Id = 13, Title = "رد مدیر گروه خزانه" },
                   new Status { Id = 14, Title = "رد حسابدار خزانه" },
                   new Status { Id = 15, Title = "رد اداره عملیات" },
                   new Status { Id = 16, Title = "رد معاون گروه خزانه - تسویه" },
                   new Status { Id = 17, Title = "رد پول رسان - تسویه" },
                   new Status { Id = 18, Title = "رد مدیر گروه خزانه - تسویه" },
                   new Status { Id = 19, Title = "رد حسابدار خزانه - تسویه" },
                   new Status { Id = 20, Title = "رد اداره عملیات - تسویه" }
                   );
        }
    }
}
