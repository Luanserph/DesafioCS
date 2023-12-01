using System;
using System.ComponentModel.DataAnnotations;

namespace LuanAPI.Models
{
    public class Teacher
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } 
        public string Turma { get; set; } 
        public DateTime DataNascimento { get; set; }
        public string NomeEscola { get; set; } 
        public string Turno { get; set; } 
    }
}
