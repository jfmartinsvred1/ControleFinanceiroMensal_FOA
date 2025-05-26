using ControleFinanceiroMensalDomain.Models.Enums;

namespace ControleFinanceiroMensal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            nomeMovimentacaoLabel = new Label();
            textNomeMovimentacao = new TextBox();
            inputValorMovimentacao = new TextBox();
            labelValorMovimentacao = new Label();
            tipoMovimentacaoLabel = new Label();
            diaMovimentacaoLabel = new Label();
            inputTipoMovimentacao = new ComboBox();
            diaMovimentacaonput = new NumericUpDown();
            seRepeteTodoMesMovimentacao = new Label();
            mesDaMovimentacaoLabel = new Label();
            mesMovimentacaoInput = new NumericUpDown();
            seRepeteInput = new ComboBox();
            criarMovimentacao = new Button();
            resumoBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            dataInicioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataFimDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            saldoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            resumosLabel = new Label();
            movimentacoesBindingSource = new BindingSource(components);
            label1 = new Label();
            anoDaMovimentacaoLabel = new Label();
            anoMovimentacaoInput = new NumericUpDown();
            dataGridView2 = new DataGridView();
            nomeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            diaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            criadoEmDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)diaMovimentacaonput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mesMovimentacaoInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resumoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movimentacoesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)anoMovimentacaoInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // nomeMovimentacaoLabel
            // 
            nomeMovimentacaoLabel.AutoSize = true;
            nomeMovimentacaoLabel.Location = new Point(31, 38);
            nomeMovimentacaoLabel.Name = "nomeMovimentacaoLabel";
            nomeMovimentacaoLabel.Size = new Size(140, 15);
            nomeMovimentacaoLabel.TabIndex = 0;
            nomeMovimentacaoLabel.Text = "Nome Da Movimentação";
            // 
            // textNomeMovimentacao
            // 
            textNomeMovimentacao.Location = new Point(31, 56);
            textNomeMovimentacao.Name = "textNomeMovimentacao";
            textNomeMovimentacao.Size = new Size(140, 23);
            textNomeMovimentacao.TabIndex = 1;
            // 
            // inputValorMovimentacao
            // 
            inputValorMovimentacao.Location = new Point(31, 109);
            inputValorMovimentacao.Name = "inputValorMovimentacao";
            inputValorMovimentacao.Size = new Size(140, 23);
            inputValorMovimentacao.TabIndex = 2;
            inputValorMovimentacao.TextChanged += inputValorMovimentacao_TextChanged;
            // 
            // labelValorMovimentacao
            // 
            labelValorMovimentacao.AutoSize = true;
            labelValorMovimentacao.Location = new Point(31, 91);
            labelValorMovimentacao.Name = "labelValorMovimentacao";
            labelValorMovimentacao.Size = new Size(133, 15);
            labelValorMovimentacao.TabIndex = 6;
            labelValorMovimentacao.Text = "Valor Da Movimentação";
            // 
            // tipoMovimentacaoLabel
            // 
            tipoMovimentacaoLabel.AutoSize = true;
            tipoMovimentacaoLabel.Location = new Point(31, 147);
            tipoMovimentacaoLabel.Name = "tipoMovimentacaoLabel";
            tipoMovimentacaoLabel.Size = new Size(130, 15);
            tipoMovimentacaoLabel.TabIndex = 7;
            tipoMovimentacaoLabel.Text = "Tipo Da Movimentação";
            // 
            // diaMovimentacaoLabel
            // 
            diaMovimentacaoLabel.AutoSize = true;
            diaMovimentacaoLabel.Location = new Point(31, 201);
            diaMovimentacaoLabel.Name = "diaMovimentacaoLabel";
            diaMovimentacaoLabel.Size = new Size(124, 15);
            diaMovimentacaoLabel.TabIndex = 8;
            diaMovimentacaoLabel.Text = "Dia Da Movimentação";
            // 
            // inputTipoMovimentacao
            // 
            inputTipoMovimentacao.FormattingEnabled = true;
            inputTipoMovimentacao.Items.AddRange(new object[] { "Entrada", "Saida" });
            inputTipoMovimentacao.Location = new Point(31, 165);
            inputTipoMovimentacao.Name = "inputTipoMovimentacao";
            inputTipoMovimentacao.Size = new Size(140, 23);
            inputTipoMovimentacao.TabIndex = 10;
            // 
            // diaMovimentacaonput
            // 
            diaMovimentacaonput.Location = new Point(31, 228);
            diaMovimentacaonput.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            diaMovimentacaonput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            diaMovimentacaonput.Name = "diaMovimentacaonput";
            diaMovimentacaonput.Size = new Size(140, 23);
            diaMovimentacaonput.TabIndex = 11;
            diaMovimentacaonput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // seRepeteTodoMesMovimentacao
            // 
            seRepeteTodoMesMovimentacao.AutoSize = true;
            seRepeteTodoMesMovimentacao.Location = new Point(31, 264);
            seRepeteTodoMesMovimentacao.Name = "seRepeteTodoMesMovimentacao";
            seRepeteTodoMesMovimentacao.Size = new Size(113, 15);
            seRepeteTodoMesMovimentacao.TabIndex = 12;
            seRepeteTodoMesMovimentacao.Text = "Se repete todo mês?";
            // 
            // mesDaMovimentacaoLabel
            // 
            mesDaMovimentacaoLabel.AutoSize = true;
            mesDaMovimentacaoLabel.Location = new Point(31, 320);
            mesDaMovimentacaoLabel.Name = "mesDaMovimentacaoLabel";
            mesDaMovimentacaoLabel.Size = new Size(129, 15);
            mesDaMovimentacaoLabel.TabIndex = 14;
            mesDaMovimentacaoLabel.Text = "Mês Da Movimentação";
            mesDaMovimentacaoLabel.Visible = false;
            // 
            // mesMovimentacaoInput
            // 
            mesMovimentacaoInput.Location = new Point(31, 338);
            mesMovimentacaoInput.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            mesMovimentacaoInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            mesMovimentacaoInput.Name = "mesMovimentacaoInput";
            mesMovimentacaoInput.Size = new Size(140, 23);
            mesMovimentacaoInput.TabIndex = 15;
            mesMovimentacaoInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            mesMovimentacaoInput.Visible = false;
            // 
            // seRepeteInput
            // 
            seRepeteInput.FormattingEnabled = true;
            seRepeteInput.Items.AddRange(new object[] { true, false });
            seRepeteInput.Location = new Point(31, 282);
            seRepeteInput.Name = "seRepeteInput";
            seRepeteInput.Size = new Size(140, 23);
            seRepeteInput.TabIndex = 13;
            seRepeteInput.SelectedIndexChanged += seRepeteInput_SelectedIndexChanged;
            // 
            // criarMovimentacao
            // 
            criarMovimentacao.Location = new Point(22, 442);
            criarMovimentacao.Name = "criarMovimentacao";
            criarMovimentacao.Size = new Size(162, 36);
            criarMovimentacao.TabIndex = 16;
            criarMovimentacao.Text = "Criar Movimentação";
            criarMovimentacao.UseVisualStyleBackColor = true;
            criarMovimentacao.Click += criarMovimentacao_Click;
            // 
            // resumoBindingSource
            // 
            resumoBindingSource.DataSource = typeof(ControleFinanceiroMensalDomain.Models.Entities.Resumo);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataInicioDataGridViewTextBoxColumn, dataFimDataGridViewTextBoxColumn, saldoDataGridViewTextBoxColumn });
            dataGridView1.DataSource = resumoBindingSource;
            dataGridView1.Location = new Point(197, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(342, 290);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            // 
            // dataInicioDataGridViewTextBoxColumn
            // 
            dataInicioDataGridViewTextBoxColumn.DataPropertyName = "DataInicio";
            dataInicioDataGridViewTextBoxColumn.HeaderText = "DataInicio";
            dataInicioDataGridViewTextBoxColumn.Name = "dataInicioDataGridViewTextBoxColumn";
            dataInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataFimDataGridViewTextBoxColumn
            // 
            dataFimDataGridViewTextBoxColumn.DataPropertyName = "DataFim";
            dataFimDataGridViewTextBoxColumn.HeaderText = "DataFim";
            dataFimDataGridViewTextBoxColumn.Name = "dataFimDataGridViewTextBoxColumn";
            dataFimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // saldoDataGridViewTextBoxColumn
            // 
            saldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo";
            saldoDataGridViewTextBoxColumn.HeaderText = "Saldo";
            saldoDataGridViewTextBoxColumn.Name = "saldoDataGridViewTextBoxColumn";
            saldoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // resumosLabel
            // 
            resumosLabel.AutoSize = true;
            resumosLabel.ForeColor = SystemColors.MenuHighlight;
            resumosLabel.Location = new Point(331, 64);
            resumosLabel.Name = "resumosLabel";
            resumosLabel.Size = new Size(55, 15);
            resumosLabel.TabIndex = 18;
            resumosLabel.Text = "Resumos";
            // 
            // movimentacoesBindingSource
            // 
            movimentacoesBindingSource.DataMember = "Movimentacoes";
            movimentacoesBindingSource.DataSource = resumoBindingSource;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(771, 64);
            label1.Name = "label1";
            label1.Size = new Size(223, 15);
            label1.TabIndex = 20;
            label1.Text = "Movimentações Do Resumo Selecionado";
            // 
            // anoDaMovimentacaoLabel
            // 
            anoDaMovimentacaoLabel.AutoSize = true;
            anoDaMovimentacaoLabel.Location = new Point(31, 378);
            anoDaMovimentacaoLabel.Name = "anoDaMovimentacaoLabel";
            anoDaMovimentacaoLabel.Size = new Size(129, 15);
            anoDaMovimentacaoLabel.TabIndex = 21;
            anoDaMovimentacaoLabel.Text = "Ano Da Movimentação";
            anoDaMovimentacaoLabel.Visible = false;
            // 
            // anoMovimentacaoInput
            // 
            anoMovimentacaoInput.Location = new Point(31, 396);
            anoMovimentacaoInput.Maximum = DateTime.Now.Year + 5;
            anoMovimentacaoInput.Minimum = DateTime.Now.Year;
            anoMovimentacaoInput.Name = "anoMovimentacaoInput";
            anoMovimentacaoInput.Size = new Size(140, 23);
            anoMovimentacaoInput.TabIndex = 22;
            anoMovimentacaoInput.Visible = false;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { nomeDataGridViewTextBoxColumn, diaDataGridViewTextBoxColumn, valorDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, criadoEmDataGridViewTextBoxColumn });
            dataGridView2.DataSource = movimentacoesBindingSource;
            dataGridView2.Location = new Point(646, 91);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(542, 290);
            dataGridView2.TabIndex = 23;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // diaDataGridViewTextBoxColumn
            // 
            diaDataGridViewTextBoxColumn.DataPropertyName = "Dia";
            diaDataGridViewTextBoxColumn.HeaderText = "Dia";
            diaDataGridViewTextBoxColumn.Name = "diaDataGridViewTextBoxColumn";
            diaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // criadoEmDataGridViewTextBoxColumn
            // 
            criadoEmDataGridViewTextBoxColumn.DataPropertyName = "CriadoEm";
            criadoEmDataGridViewTextBoxColumn.HeaderText = "Data Criação";
            criadoEmDataGridViewTextBoxColumn.Name = "criadoEmDataGridViewTextBoxColumn";
            criadoEmDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 594);
            Controls.Add(dataGridView2);
            Controls.Add(anoMovimentacaoInput);
            Controls.Add(anoDaMovimentacaoLabel);
            Controls.Add(label1);
            Controls.Add(resumosLabel);
            Controls.Add(dataGridView1);
            Controls.Add(criarMovimentacao);
            Controls.Add(mesMovimentacaoInput);
            Controls.Add(mesDaMovimentacaoLabel);
            Controls.Add(seRepeteInput);
            Controls.Add(seRepeteTodoMesMovimentacao);
            Controls.Add(diaMovimentacaonput);
            Controls.Add(inputTipoMovimentacao);
            Controls.Add(diaMovimentacaoLabel);
            Controls.Add(tipoMovimentacaoLabel);
            Controls.Add(labelValorMovimentacao);
            Controls.Add(inputValorMovimentacao);
            Controls.Add(textNomeMovimentacao);
            Controls.Add(nomeMovimentacaoLabel);
            Name = "Form1";
            Text = "ResumoFinanceiro";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)diaMovimentacaonput).EndInit();
            ((System.ComponentModel.ISupportInitialize)mesMovimentacaoInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)resumoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)movimentacoesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)anoMovimentacaoInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nomeMovimentacaoLabel;
        private TextBox textNomeMovimentacao;
        private TextBox inputValorMovimentacao;
        private Label labelValorMovimentacao;
        private Label tipoMovimentacaoLabel;
        private Label diaMovimentacaoLabel;
        private ComboBox inputTipoMovimentacao;
        private NumericUpDown diaMovimentacaonput;
        private Label seRepeteTodoMesMovimentacao;
        private ComboBox seRepeteInput;
        private Label mesDaMovimentacaoLabel;
        private NumericUpDown mesMovimentacaoInput;
        private Button criarMovimentacao;
        private BindingSource resumoBindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataFimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn saldoDataGridViewTextBoxColumn;
        private Label resumosLabel;
        private BindingSource movimentacoesBindingSource;
        private Label label1;
        private Label anoDaMovimentacaoLabel;
        private NumericUpDown anoMovimentacaoInput;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn diaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn criadoEmDataGridViewTextBoxColumn;
    }
}
