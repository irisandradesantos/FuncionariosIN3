using System;
using System.Globalization;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FuncionariosIN3.Models
{
    [Table("tbfuncionario")]
    public class Funcionario
    {
        [Key][System.ComponentModel.DisplayName("Código")]
        public int cdFuncionario { get; set; }
        [System.ComponentModel.DisplayName("Nome do Funcionário")]
        public string dsNome { get; set; }
        public string dsEmail { get; set; }
        public string dsCPF { get; set; }
        [System.ComponentModel.DisplayName("Admissão")]
        public DateTime dtAdmissao { get; set; }
        public DateTime dtNascimento { get; set; }
        public int biAtivo { get; set; }
        [System.ComponentModel.DisplayName("Descrição do Cargo")]
        public int cdCargo { get; set; }
        [System.ComponentModel.DisplayName("Salário")]
        public decimal vlSalario { get; set; }
        public string dsObservacao { get; set; }
        public DateTime dtSysInclusao { get; set; }
        public DateTime dtSysAlteracao { get; set; }

    }

    public class FuncionarioDBContext : DbContext
    {
        public DbSet<Funcionario> Funcionarios { get; set; }
    }
}