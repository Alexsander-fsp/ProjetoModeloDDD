using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroModelo.Domain.Entities
{
    public class Colaborador
    {
        // Identificador único do colaborador
        public int Id { get; set; }

        // Nome completo
        public string Nome { get; set; }

        // Cargo ou função
        public string Cargo { get; set; }

        // Departamento
        public string Departamento { get; set; }

        // Data de admissão
        public DateTime DataAdmissao { get; set; }

        // Salário
        public decimal Salario { get; set; }

        // E-mail corporativo
        public string Email { get; set; }

        // Telefone de contato
        public string Telefone { get; set; }

        // Método auxiliar para exibir informações resumidas
        public string ExibirResumo()
        {
            return $"{Nome} - {Cargo} ({Departamento}) | Admissão: {DataAdmissao.ToShortDateString()}";
        }
    }
}
