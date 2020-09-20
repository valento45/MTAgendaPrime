using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaBE
{
    public class LogCliente
    {
    }

    public enum Tipo : int
    {
        [Description("Inclusão")]
        Inclusao = 0,
        [Description("Alteração")]
        Alteracao = 1,
        [Description("Exclusão")]
        Exclusao = 2
    }
}
