using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LuanAPI.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } 
        public string Turma { get; set; } 
        public DateTime DataNascimento { get; set; }
        public string NomeMae { get; set; } 
        public string NomePai { get; set; } 
        public string Turno { get; set; } 
    }
}
