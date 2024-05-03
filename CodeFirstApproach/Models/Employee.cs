using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirstApproach.Models
{
    public class Employee
    {
        [Key]
        public int Eid { get; set; }
        [Column("Empname",TypeName = "varchar(100)")]
        public string? Ename { get; set; }
        public string? Desig { get; set; }
    }
}