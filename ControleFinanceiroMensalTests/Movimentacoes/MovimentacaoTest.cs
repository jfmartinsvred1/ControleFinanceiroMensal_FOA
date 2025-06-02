using ControleFinanceiroMensalDomain.Models.Entities;
using ControleFinanceiroMensalDomain.Models.Enums;

namespace ControleFinanceiroMensalTests.Movimentacoes
{
    public class MovimentacaoTest
    {
        [Fact]
        public void AdicionarResumo_QuandoSeCadastrarUmResumo_DeveConterApenasUmResumos()
        {

            #region Arrange
            var dataAtual = DateTime.Now;
            var resumo = new ControleFinanceiroMensalDomain.Models.Entities.Resumo(dataAtual);
            var movimentacao = new Movimentacao(ETipoMovimentacao.Entrada, 500, "", 5);
            #endregion Arrange
            #region Act
            movimentacao.AdicionarResumo(resumo);
            #region Act
            #endregion Assert
            Assert.NotNull(movimentacao);
            Assert.Equal(1, movimentacao.Resumos.Count());
            #endregion Assert
        }
    }
}
