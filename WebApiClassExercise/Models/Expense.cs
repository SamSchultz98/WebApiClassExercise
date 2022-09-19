using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiClassExercise.Models
{
    public class Expense
    {
        public int Id { get; set; }                 //PK

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(10)]
        public string Status { get; set; } = "NEW";

        [Column(TypeName = "Decimal(11,2)")]
        public decimal Total { get; set; } = 0;



        public int EmployeeId { get; set; }                 //FK to the Employee Class
        public virtual Employee? Employee { get; set; }



    }
}
