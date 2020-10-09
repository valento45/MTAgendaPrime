using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioBE
{
    public class Usuario
    {

        #region PROPRIEDADES
        public int Id { get; set; }
        public string Nome { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Tipo { get; set; }
        public string UserName { get; set; }
        public string Senha { get; set; }
        public string IsSupervisor { get; set; }
        #endregion


    }
}
