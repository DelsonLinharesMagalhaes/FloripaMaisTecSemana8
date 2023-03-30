

namespace SistemaBanco
{
    public class Transacao
    {
        public DateTime Data { get; set; }
        public Double Valor { get; set; }

        public Transacao(DateTime data, double valor){
            Data=data;
            Valor=valor;
        }
    }
}