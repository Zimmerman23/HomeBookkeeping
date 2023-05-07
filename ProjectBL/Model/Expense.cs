using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Permissions;

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

    }
}
