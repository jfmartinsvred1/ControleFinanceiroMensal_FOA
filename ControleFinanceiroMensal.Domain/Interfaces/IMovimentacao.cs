using ControleFinanceiroMensalDomain.Models.Entities;

namespace ControleFinanceiroMensalDomain.Interfaces
{
    public interface IMovimentacao
    {
        void AdicionarResumo(Resumo resumo);
    }
}
