using System;
using System.Globalization;
using System.Windows.Forms;
using ControleFinanceiroMensalDomain.Models.Entities;
using ControleFinanceiroMensalDomain.Models.Enums;

namespace ControleFinanceiroMensal
{
    public partial class Form1 : Form
    {
        // Armazena o valor como decimal
        public decimal ValorMonetario { get; private set; } = 0;
        public bool SeRepete { get; set; }
        private Cliente Cliente { get; set; }

        public Form1()
        {
            InitializeComponent();

            inputValorMovimentacao.KeyPress += inputValorMovimentacao_KeyPress;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inputValorMovimentacao.Text = 0.ToString("C2");
            Cliente = new Cliente();
            dataGridView1.DataSource = Cliente.Resumos;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputValorMovimentacao_TextChanged(object sender, EventArgs e)
        {
            string texto = inputValorMovimentacao.Text.Replace("R$", "").Trim();

            if (decimal.TryParse(texto, NumberStyles.Any, CultureInfo.CurrentCulture, out decimal valor))
            {
                ValorMonetario = valor;
            }
            else
            {
                ValorMonetario = 0;
            }
        }

        private void inputValorMovimentacao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }

            if (e.KeyChar == ',' && inputValorMovimentacao.Text.Contains(','))
            {
                e.Handled = true;
            }
        }


        private void seRepeteInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (seRepeteInput.SelectedItem is bool selectedValue && selectedValue == false)
            {
                mesDaMovimentacaoLabel.Visible = true;
                mesMovimentacaoInput.Visible = true;
                anoDaMovimentacaoLabel.Visible=true;
                anoMovimentacaoInput.Visible=true;
                SeRepete = false;
            }
            else
            {
                SeRepete = true;
                mesDaMovimentacaoLabel.Visible = false;
                mesMovimentacaoInput.Visible = false;
                anoDaMovimentacaoLabel.Visible = false;
                anoMovimentacaoInput.Visible = false;
            }
        }



        private void criarMovimentacao_Click(object sender, EventArgs e)
        {
            string nome = textNomeMovimentacao.Text;

            decimal valor = ValorMonetario;

            string tipoSelecionado = inputTipoMovimentacao.SelectedItem?.ToString();

            int anoSelecionado = (int)anoMovimentacaoInput.Value;

            int diaSelecionado = (int) diaMovimentacaonput.Value;


            bool seRepete = bool.Parse(seRepeteInput.SelectedItem?.ToString() ?? "false");

            int? mes = null;
            if (!seRepete)
            {
                mes = (int)mesMovimentacaoInput.Value;
            }
            var dataAtual = DateTime.Now;
            var movimentacao = new Movimentacao(tipoSelecionado == "Entrada" ? ETipoMovimentacao.Entrada : ETipoMovimentacao.Saida, valor, nome,diaSelecionado);

            Cliente.CadastrarMovimentacao(movimentacao, seRepete, mes, anoSelecionado,diaSelecionado);

            MessageBox.Show("Movimentação criada com sucesso!");
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var resumo = Cliente.Resumos[e.RowIndex];

            dataGridView2.DataSource = resumo.Movimentacoes;

        }

    }
}
