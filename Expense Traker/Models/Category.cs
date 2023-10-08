using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Traker.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        
        [Column(TypeName ="nvarchar(50)")]
        public String Title { get; set; } = String.Empty;

        [Column(TypeName = "nvarchar(5)")]
        public String Icon { get; set; } = String.Empty;

        [Column(TypeName = "nvarchar(10)")]
        public String Type { get; set; } = "Expense";

        [NotMapped]
        public string? TitleWithIcon 
        {
            get
            {
                return $"{this.Icon} {this.Title}";
            }
        }
    }
}
