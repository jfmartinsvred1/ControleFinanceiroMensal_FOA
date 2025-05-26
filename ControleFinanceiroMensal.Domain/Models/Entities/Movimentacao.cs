using ControleFinanceiroMensalDomain.Interfaces;
using ControleFinanceiroMensalDomain.Models.Common;
using ControleFinanceiroMensalDomain.Models.Enums;

namespace ControleFinanceiroMensalDomain.Models.Entities
{
    public class Movimentacao : Transacao, IMovimentacao
    {

        public Movimentacao(ETipoMovimentacao tipo, decimal valor,string nome,int dia)
        {
            this.Tipo = tipo;
            this.Valor = valor;
            this.Nome = nome;
            this.Dia = dia;
        }
        public ETipoMovimentacao Tipo { get; private set; }

        public List<Resumo> Resumos { get; private set; }=[];
        public void AdicionarResumo(Resumo resumo)
        {
            Resumos.Add(resumo);
        }
    }
}
