using System.ComponentModel;

namespace ControleFinanceiroMensalDomain.Models.Entities
{
    public class Cliente
    {
        public Cliente()
        {

            Id = Guid.NewGuid();

            CriarResumosNaoExistentesPor5Anos();
        }

        public Guid Id { get; private set; }
        
        public BindingList<Resumo> Resumos { get; set; } = new BindingList<Resumo>();


        private void CriarResumosNaoExistentesPor5Anos()
        {
            var dataAtual = DateTime.Now;
            var dataFinal = new DateTime(dataAtual.Year + 5, 12, 1);

            var dataIteracao = new DateTime(dataAtual.Year, dataAtual.Month, 1);

            while (dataIteracao < dataFinal)
            {
                if (!Resumos.Any(r => r.Id == $"{dataIteracao.Month}_{dataIteracao.Year}"))
                {
                    Resumos.Add(new Resumo(dataIteracao,this));
                    dataIteracao = dataIteracao.AddMonths(1);
                }
            }
        }
        public void CadastrarMovimentacao(Movimentacao movimentacao,bool seRepete, int? mes, int? ano, int? dia)
        {
            if (!seRepete)
            {

                var data = new DateTime(ano.Value, mes.Value, dia.Value);
                var id = $"{data.Month}_{data.Year}";
                var resumo = Resumos.FirstOrDefault(r => r.Id == id);
                if (resumo == null)
                {
                    Resumos.Add(new Resumo(data, this));
                    var resumoAdicionado = Resumos.FirstOrDefault(r => r.Id == id);
                    resumoAdicionado.AdicionarMovimentacao(movimentacao);
                }
                else
                {
                    resumo.AdicionarMovimentacao(movimentacao);
                }
            }
            else
            {
                foreach (var resumo in Resumos)
                {
                    resumo.AdicionarMovimentacao(movimentacao);
                }
            }
        }
    }
}
