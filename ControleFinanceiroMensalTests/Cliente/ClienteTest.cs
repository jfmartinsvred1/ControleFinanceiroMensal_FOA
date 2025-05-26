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
        public void Ctor_QuandoCriarUmCliente_DeveCriarUmaListaDeResumoPor5Anoss()
        {
            #region Arrange
            var hoje = DateTime.Now;

            var dataFinal = new DateTime(hoje.Year + 5, 12, 31);

            int totalMeses = ((dataFinal.Year - hoje.Year) * 12) + dataFinal.Month - hoje.Month;

            #endregion Arrange
            #region Act
            var cliente = new ControleFinanceiroMensalDomain.Models.Entities.Cliente();
            #region Act
            #endregion Assert
            Assert.Equal(totalMeses,cliente.Resumos.Count());
            #endregion Assert
        }
        [Fact]
        public void CadastrarMovimentacao_QuandoSeCadastrarUmaMovimentacaoQueNaoSeRepeteCorreta_DeveIrParaOResumoCorreto()
        {

            #region Arrange
            var cliente = new ControleFinanceiroMensalDomain.Models.Entities.Cliente();
            var movimentacao = new Movimentacao(ETipoMovimentacao.Entrada,500,"",5);
            var dataAtual = DateTime.Now;
            #endregion Arrange
            #region Act
            cliente.CadastrarMovimentacao(movimentacao,false,dataAtual.Month,dataAtual.Year);
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
            cliente.CadastrarMovimentacao(movimentacao, true, dataAtual.Month, dataAtual.Year);
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
