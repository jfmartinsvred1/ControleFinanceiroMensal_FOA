namespace ControleFinanceiroMensalDomain.Models.Common
{
    public abstract class Transacao
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime CriadoEm { get; private set; } = DateTime.Now;
        public int Dia { get; set; }

    }
}
