

namespace Multas.Entidades
{
    internal class Aplicacoes
    {
            public int _IdAplicacao;
            public DateOnly _data;
            public TimeOnly _horario;
            public string _longitude;
            public string _latitude;
            public double _valorAplicado;
            public Veiculos _veiculos;
            public Proprietario proprietario;
    }
}
