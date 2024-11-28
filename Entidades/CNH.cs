using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multas.Entidades
{
    internal class CNH
    {      
            public int _IdCNH;
            public DateOnly dataEmissao;
            public DateOnly dataVencimento;
            public string categoria;
            public int pontuacao;
            public string numeroCNH;
    }
}
