using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsFormsApp2.Model
{
    [Table("expense")]
    public class Expense
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("date")]
        public DateTime Date { get; set; }

        [Column("category")]
        public string Category { get; set; }

        [Column("price")]
        public int Price { get; set; }

        [Column("memo")]
        public string Memo { get; set; }

        [Column("sakamoto")]
        public bool Sakamoto { get; set; }
    }
}