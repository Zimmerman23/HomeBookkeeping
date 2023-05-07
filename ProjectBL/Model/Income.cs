using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectBL.Model
{
    [Table("incomes")]
    public class Income
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("salary")]
        public double Salary { get; set; }
        [Column("rental income")]
        public double RentalIncome { get; set; }
        [Column("other income")]
        public double OtherIncome { get; set; }
        public Income() { }
        public Income(int id, DateTime date, double salary, double rentalIncome, double otherIncome)
        {
            if (id < 0)
            {
                throw new ArgumentException("Data is incorrect.", nameof(id));
            }
            if (date > DateTime.Today || date < DateTime.Parse("01.01.1900"))
            {
                throw new ArgumentException("Data is incorrect.", nameof(date));
            }
            if (salary < 0)
            {
                throw new ArgumentException("Data is incorrect.", nameof(salary));
            }
            if (rentalIncome < 0)
            {
                throw new ArgumentException("Data is incorrect.", nameof(rentalIncome));
            }
            if (otherIncome < 0)
            {
                throw new ArgumentException("Data is incorrect.", nameof(otherIncome));
            }
            Id = id;
            Date = date;
            Salary = salary;
            RentalIncome = rentalIncome;
            OtherIncome = otherIncome;
        }
    }
}
