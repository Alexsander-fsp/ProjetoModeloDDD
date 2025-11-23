using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Aplication.Commands
{
    public class FornecedorCommand
    {
        public int Id { get; set; }
        public string Nome { get; set; }      // Nome do fornecedor
        public string CNPJ { get; set; }      // Cadastro Nacional da Pessoa Jurídica
        public string Telefone { get; set; }  // Contato telefônico
        public string Email { get; set; }     // Endereço de e-mail
        public string Endereco { get; set; }  // Endereço físico
    }
}
