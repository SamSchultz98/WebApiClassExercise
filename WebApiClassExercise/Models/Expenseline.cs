namespace WebApiClassExercise.Models
{
    public class Expenseline
    {
        public int Id { get; set; }         //PK


        public int Quantity { get; set; } = 1;


        public int ExpenseId { get; set; }      //FK to Expense Class
        public virtual Expense? Expense { get; set; }


        public int ItemId { get; set; }         //FK to Item class
        public virtual Item? Item { get; set; }

    }
}
