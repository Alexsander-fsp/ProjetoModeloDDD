using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.Aplication.ViewModels
{
    public class ProdutoViewModel
    {        
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres ")]
        [MinLength(2, ErrorMessage = "Mínimo de {0} caracteres")]
        public string Nome { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Preencha um valor")]
        public decimal Valor { get; set; }
        
        public bool Disponivel { get; set; }

        public int ClienteProduto { get; set; }
    }
}