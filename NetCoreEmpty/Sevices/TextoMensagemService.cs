using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEmpty.Sevices
{
    public class TextoMensagemService : IMensagemService
    {
        public string GetMensagem()
        {
            return "Retorna uma mensagem de texto";
        }
    }
}
