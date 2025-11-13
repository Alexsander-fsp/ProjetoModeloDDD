using PrimeiroModelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]

        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo sobrenome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]

        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha o campo email")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]

        public string Email { get; set; }

        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        //public virtual IEnumerable<Produto> Produtos { get; set; }
    }
}