using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Aplication.Commands
{
    public class ColaboradorCommand
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Cargo { get; set; }

        public string Departamento { get; set; }

        public DateTime DataAdmissao { get; set; }

        public decimal Salario { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }
    }
}
