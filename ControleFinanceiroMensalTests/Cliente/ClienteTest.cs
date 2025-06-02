using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControleFinanceiroMensalDomain.Interfaces;
using ControleFinanceiroMensalDomain.Models.Entities;
using ControleFinanceiroMensalDomain.Models.Enums;

namespace ControleFinanceiroMensalTests.Cliente
{
    public class ClienteTest
    {
        [Fact]
        public void CadastrarMovimentacao_QuandoSeCadastrarUmaMovimentacaoQueNaoSeRepeteCorreta_DeveIrParaOResumoCorreto()
        {

            #region Arrange
            var cliente = new ControleFinanceiroMensalDomain.Models.Entities.Cliente();
            var movimentacao = new Movimentacao(ETipoMovimentacao.Entrada,500,"",5);
            var dataAtual = DateTime.Now;
            #endregion Arrange
            #region Act
            cliente.CadastrarMovimentacao(movimentacao,false,dataAtual.Month,dataAtual.Year,5);
            #region Act
            #endregion Assert
            var resumo = cliente.Resumos.FirstOrDefault(r => r.Id == $"{dataAtual.Month}_{dataAtual.Year}");
            Assert.NotNull(resumo);
            Assert.Equal(1, resumo.Movimentacoes.Count());
            Assert.Equal(movimentacao, resumo.Movimentacoes.FirstOrDefault());
            #endregion Assert
        }
        [Fact]
        public void CadastrarMovimentacao_QuandoSeCadastrarUmaMovimentacaoQueSeRepeteCorreta_DeveIrParaTodosOsResumos()
        {

            #region Arrange
            var cliente = new ControleFinanceiroMensalDomain.Models.Entities.Cliente();
            var movimentacao = new Movimentacao(ETipoMovimentacao.Entrada, 500,"",5);
            var dataAtual = DateTime.Now;
            #endregion Arrange
            #region Act
            cliente.CadastrarMovimentacao(movimentacao, true, dataAtual.Month, dataAtual.Year,5);
            #region Act
            #endregion Assert
            foreach( var resumo in cliente.Resumos)
            {
                Assert.NotNull(resumo);
                Assert.Equal(movimentacao,resumo.Movimentacoes.FirstOrDefault());
                Assert.Equal(500, resumo.Saldo);
            }
            #endregion Assert
        }
        //#region Arrange
        //#endregion Arrange
        //#region Act
        //#region Act
        //#endregion Assert
        //#endregion Assert
    }
}
