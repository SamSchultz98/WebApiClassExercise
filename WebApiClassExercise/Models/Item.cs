using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiClassExercise.Models
{
    public class Item
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [Column(TypeName ="Decimal(11,2)")]
        public Decimal Price { get; set; }




    }
}
