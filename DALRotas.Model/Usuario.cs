using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALRotas.Model
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int IdPerfilUsuario { get; set; }
        public int  IdSituacaoUsuario { get; set; }
        public int IdInclusao { get; set; }
        public DateTime DtInclusao { get; set; }
        public int IdAlteracao { get; set; }
        public DateTime DtAlteracao { get; set; }
    }
}
