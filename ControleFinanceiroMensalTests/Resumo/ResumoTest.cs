using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiroMensalDomain.Models.Entities;
using ControleFinanceiroMensalDomain.Models.Enums;

namespace ControleFinanceiroMensalTests.Resumo
{
    public class ResumoTest
    {
        [Fact]
        public void AdicionarMovimentacao_QuandoSeCadastrarUmaMovimentacao_DeveSalvarSaldoCorreto()
        {

            #region Arrange
            var dataAtual = DateTime.Now;
            var resumo = new ControleFinanceiroMensalDomain.Models.Entities.Resumo(dataAtual, new ControleFinanceiroMensalDomain.Models.Entities.Cliente());
            var movimentacao = new Movimentacao(ETipoMovimentacao.Entrada, 500, "", 5);
            #endregion Arrange
            #region Act
            resumo.AdicionarMovimentacao(movimentacao);
            #region Act
            #endregion Assert
            Assert.NotNull(resumo);
            Assert.Equal(500, resumo.Saldo);
            #endregion Assert
        }
        [Fact]
        public void AdicionarMovimentacao_QuandoSeCadastrarUmaMovimentacao_DeveConterApenasUmaMovimentacao()
        {

            #region Arrange
            var dataAtual = DateTime.Now;
            var resumo = new ControleFinanceiroMensalDomain.Models.Entities.Resumo(dataAtual, new ControleFinanceiroMensalDomain.Models.Entities.Cliente());
            var movimentacao = new Movimentacao(ETipoMovimentacao.Entrada, 500, "", 5);
            #endregion Arrange
            #region Act
            resumo.AdicionarMovimentacao(movimentacao);
            #region Act
            #endregion Assert
            Assert.NotNull(resumo);
            Assert.Equal(1, resumo.Movimentacoes.Count());
            #endregion Assert
        }
    }
}
