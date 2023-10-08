using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Expense_Traker.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Please select a category.")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Amount should be greater than 0.")]
        public int Amount { get; set; }


        [Column(TypeName = "nvarchar(75)")]
        public string? Note { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        [NotMapped]
        public string? CategoryTitleWithIcon
        {
            get
            {
                return Category == null ? string.Empty : $"{Category.Icon} {Category.Title}";
            }
        }

        [NotMapped]
        public string? FormattedAmount
        {
            get
            {
                CultureInfo culture = new CultureInfo("id-ID");
                return ((Category == null || Category.Type == "Expense") ? "- " : "+ ") + Amount.ToString("C0", culture);
            }
        }
    }
}
