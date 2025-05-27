using System;
using System.ComponentModel;
using ControleFinanceiroMensalDomain.Interfaces;
using ControleFinanceiroMensalDomain.Models.Enums;

namespace ControleFinanceiroMensalDomain.Models.Entities
{
    public class Resumo : IResumo, INotifyPropertyChanged
    {
        public Resumo(DateTime data)
        {
            DataInicio = new DateTime(data.Year, data.Month, 1);
            DataFim = DataInicio.AddMonths(1).AddDays(-1);
            Id = $"{DataInicio.Month}_{DataInicio.Year}";
        }

        public string Id { get; set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }

        public BindingList<Movimentacao> Movimentacoes { get; private set; } = new();

        private decimal saldo;
        public decimal Saldo
        {
            get => saldo;
            private set
            {
                if (saldo != value)
                {
                    saldo = value;
                    OnPropertyChanged(nameof(Saldo));
                }
            }
        }

        public void AdicionarMovimentacao(Movimentacao movimentacao)
        {
            Movimentacoes.Add(movimentacao);
            if (movimentacao.Tipo == ETipoMovimentacao.Entrada)
            {
                Saldo += movimentacao.Valor;
            }
            else
            {
                Saldo -= movimentacao.Valor;
            }
            movimentacao.AdicionarResumo(this);
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
