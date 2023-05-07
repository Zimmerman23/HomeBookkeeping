using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectBL.Model
{
    [Table("expenses")]
    public class Expense
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("id")]
        public int Id { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("food")]
        public double Food { get; set; }
        [Column("transport")]
        public double Transport { get; set; }
        [Column("mobile connection")]
        public double MobileConnection { get; set; }
        [Column("internet")]
        public double Internet { get; set; }
        [Column("entertainment")]
        public double Entertainment { get; set; }
        [Column("other")]
        public double Other { get; set; }
        public Expense() { }
        public Expense(int id, DateTime date, double food, double transport, double mobileConnection, double internet, double entertainment, double other)
        {
            if (id < 0)
            {
                throw new ArgumentException("Data is incorrect.", nameof(id));
            }
            if (date > DateTime.Today || date < DateTime.Parse("01.01.1900"))
            {
                throw new ArgumentException("Data is incorrect.", nameof(date));
            }
            if (food < 0)
            {
                throw new ArgumentException("Data is incorrect.", nameof(food));
            }
            if (transport < 0)
            {
                throw new ArgumentException("Data is incorrect.", nameof(transport));
            }
            if (mobileConnection < 0)
            {
                throw new ArgumentException("Data is incorrect.", nameof(mobileConnection));
            }
            if (internet < 0)
            {
                throw new ArgumentException("Data is incorrect.", nameof(internet));
            }
            if (entertainment < 0)
            {
                throw new ArgumentException("Data is incorrect.", nameof(entertainment));
            }
            if (other < 0)
            {
                throw new ArgumentException("Data is incorrect.", nameof(other));
            }
            Id = id;
            Date = date;
            Food = food;
            Transport = transport;
            MobileConnection = mobileConnection;
            Internet = internet;
            Entertainment = entertainment;
            Other = other;
        }
    }
}
