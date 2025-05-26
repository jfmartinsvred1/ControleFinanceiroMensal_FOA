namespace ControleFinanceiroMensalDomain.Models.Entities
{
    public class Cliente
    {
        public Cliente()
        {

            Id = Guid.NewGuid();
            Resumos = new List<Resumo>();

            var dataAtual = DateTime.Now;
            var dataFinal = new DateTime(dataAtual.Year + 5, 12, 1);

            var dataIteracao = new DateTime(dataAtual.Year, dataAtual.Month, 1);

            while (dataIteracao < dataFinal)
            {
                Resumos.Add(new Resumo(dataIteracao));
                dataIteracao = dataIteracao.AddMonths(1);
            }
        }

        public Guid Id { get; private set; }

        public List<Resumo> Resumos { get; private set; }= new List<Resumo>();

        public void CadastrarMovimentacao(Movimentacao movimentacao,bool seRepete, int? mes, int? ano)
        {
            if (!seRepete)
            {
                var resumo = Resumos.FirstOrDefault(r => r.Id == $"{mes}_{ano}");
                if (resumo == null)
                {
                    throw new Exception($"Não Existe Resumo para o Mês: {mes} Ano:{ano}");
                }
                else
                {
                    resumo.AdicionarMovimentacao(movimentacao);
                }
            }
            else
            {
                foreach(var resumo in Resumos)
                {
                    resumo.AdicionarMovimentacao(movimentacao);
                }
            }
        }
    }
}
