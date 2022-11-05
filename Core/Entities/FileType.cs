using Core.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class FileType : BaseEntity
    {
        
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید.")]
        [MaxLength(150, ErrorMessage = "{0} نمیتواند بیشتر از {1} کاراکتر باشد.")]
        public string Title { get; set; }
    }

    class FileTypeConfiguration : IEntityTypeConfiguration<FileType>
    {
        public void Configure(EntityTypeBuilder<FileType> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Title).HasMaxLength(150).IsRequired();
        }
    }    
}