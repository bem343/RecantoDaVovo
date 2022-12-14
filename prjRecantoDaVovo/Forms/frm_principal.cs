using System;
using System.Collections.Generic;
using System.Windows.Forms;
using prjRecantoDaVovo.classes;
using Proffreddy;

namespace prjRecantoDaVovo.Forms
{
	public partial class frm_principal : Form
	{

		private responsavel responsavel = null;
		private List<crianca> criancas = new List<crianca>();
		private List<sexo> sexos = null;

		#region Construtores
		public frm_principal()
		{
			InitializeComponent();
		}
		#endregion

		#region Fecha a aplicação ao fechar este formulário
			private void frm_principal_FormClosed(object sender, FormClosedEventArgs e)
			{
				Application.Exit();
			}
		#endregion

		#region Botões da tela principal
		private void mostraViews()
		{
			txtCpf.Enabled = false;
			btnConsultar.Enabled = false;
			btnConcluir.Visible = true;
			gbCriancas.Visible = true;
			gbResponsavel.Visible = true;
			panelCriancas.Dock = DockStyle.Fill;
			panelCriancas.Visible = true;
			panelNovaCrianca.Visible = false;
		}
		private void erro()
		{
			MessageBox.Show("Falha na conexão com o banco.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
		//Botão Consultar
		private void btnConsultar_Click(object sender, EventArgs e)
		{
			//ValidaCpf();
			responsavel = new responsavel(txtCpf.Text);
			if (!responsavel.Verificar())
			{

				// Caso o resonsável não exista
				if (MessageBox.Show("Deseja cadastrá-lo?", "Responsável não cadastrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					txtCpf.Clear();
					txtCpf.Focus();
					return;
				}
				else
				{
					if (!responsavel.Inserir()) { erro(); return; }
					cbEditarInfoResponsavel.Visible = false;
					btnSalvarResponsavel.Enabled = true;
					cbEditarInfoResponsavel.Checked = true;
					cbEditarInfoResponsavel.Enabled = false;
					panelInfoCrianca.Visible = false;
					txtNome.Enabled = true;
					txtEndereco.Enabled = true;
					txtTelefone.Enabled = true;
					btnNovaCrianca.Enabled = false;
					cbCriancas.Enabled = false;
				}
				mostraViews();
				txtNome.Focus();
			}
			else
			{

				// Caso o responsável já exista
				txtNome.Text = responsavel.nome;
				txtEndereco.Text = responsavel.endereco;
				txtTelefone.Text = responsavel.cel;

				criancas = new criancas().Listar(responsavel.cpf);
				cbCriancas.Items.Clear();

				for (int i = 0; i < criancas.Count; i++)
				{
					InserirCrianca(i);
				}

				cbEditarInfoResponsavel.Visible = true;
				btnSalvarResponsavel.Enabled = false;
				cbEditarInfoResponsavel.Checked = false;
				cbEditarInfoResponsavel.Enabled = true;
				panelInfoCrianca.Visible = true;
				txtNome.Enabled = false;
				txtEndereco.Enabled = false;
				txtTelefone.Enabled = false;
				btnNovaCrianca.Enabled = true;
				cbCriancas.Enabled = true;
				cbCriancas.Focus();

				mostraViews();
				if(criancas.Count > 0) { cbCriancas.SelectedIndex = 0; }
				cbCriancas.Focus();
			}
		}
		//Botão Concluir
		private void btnConcluir_Click(object sender, EventArgs e)
		{
			if (btnSalvarCriancas.Enabled | btnSalvarNovaCrianca.Enabled | btnSalvarResponsavel.Enabled)
			{
				if (MessageBox.Show("Deseja salvá-las?", "Alterações não salvas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					return;
				}
			}
			//Retorna a tela inicial
			txtCpf.Enabled = true;
			btnConsultar.Enabled = false;
			btnConcluir.Visible = false;
			gbCriancas.Visible = false;
			gbResponsavel.Visible = false;
			txtNome.Clear();
			txtEndereco.Clear();
			txtTelefone.Clear();
			txtSapato.Value = 0;
			txtRoupa.Clear();
			dtNascimento.Value = DateTime.Today;
			cbCriancas.Items.Clear();
			criancas.Clear();
			cbCriancas.Text = "";
			cbSexo.SelectedIndex = -1;
			txtCpf.Clear(); txtCpf.Focus();
		}

		//Botão Salvar (dados do responsável)
		private void btnSalvar_Click(object sender, EventArgs e)
		{
			responsavel.cel = txtTelefone.Text;
			responsavel.endereco = txtEndereco.Text;
			responsavel.nome = txtNome.Text;

			if (!responsavel.Atualiza()) { erro(); return; }

			cbEditarInfoResponsavel.Visible = true;
			btnSalvarResponsavel.Enabled = false;
			cbEditarInfoResponsavel.Checked = false;
			cbEditarInfoResponsavel.Enabled = true;
			txtNome.Enabled = false;
			txtEndereco.Enabled = false;
			txtTelefone.Enabled = false;
			btnNovaCrianca.Enabled = true;
			cbCriancas.Enabled = true;
			cbCriancas.Focus();
		}
		//Botão Salvar (dados das crianças)
		private void btnSalvarCriancas_Click(object sender, EventArgs e)
		{
			btnSalvarCriancas.Enabled = false;
			cbEditarInfoCriancas.Checked = false;
			cbEditarInfoCriancas.Enabled = true;
			cbCriancas.Focus();
            bool participacao = false;
            crianca crianca = null;
            
            int cd = cbCriancas.SelectedIndex;
            string roupa = txtRoupa.Text;
            int sapato = (int)txtSapato.Value;
            if (cbParticipacao.Checked) { participacao = true; }
			sexo sexo = new sexo(cbSexo.SelectedIndex);
            crianca = new crianca(cd + 1, criancas[cd].nome, roupa, sapato, dtNascimento.Value, participacao, sexo);
			if (!crianca.Atualiza(txtCpf.Text, false)) { erro(); return; }
        }
        //Botão Salvar (dados de uma nova criança)
        private void btnSalvarNovaCrianca_Click(object sender, EventArgs e)
		{
			int cd = criancas.Count;
			string nome = txtNomeCrianca.Text;
			sexo sexo = new sexo(cbSexoCrianca.SelectedIndex);

			if (!cbGestando.Checked)
            {
				string roupa = txtRoupaCrianca.Text;
				int sapato = (int)txtSapatoCrianca.Value;
				DateTime nascimento = dtNascimentoCrianca.Value;
				criancas[cd - 1] = new crianca(cd, nome, roupa, sapato, nascimento, true, sexo);
			} 
			else 
			{
                if (nome == "") { nome = null; }
				criancas[cd - 1] = new crianca(cd, nome, sexo, true); 
			}
			
            if (!criancas[cd - 1].Atualiza(txtCpf.Text, cbGestando.Checked)) { erro(); return; }

			InserirCrianca(cd-1);

			btnSalvarNovaCrianca.Enabled = false;
			panelCriancas.Dock = DockStyle.Fill;
			panelCriancas.Visible = true;
			panelInfoCrianca.Visible = true;
			panelNovaCrianca.Visible = false;

			cbCriancas.SelectedIndex = cd-1;
			cbCriancas.Focus();
		}
		//Botão Nova criança
		private void btnNovaCrianca_Click(object sender, EventArgs e)
		{
			panelNovaCrianca.Dock = DockStyle.Fill;
			panelNovaCrianca.Visible = true;
			panelCriancas.Visible = false;
			cbGestando.Focus();
			cbGestando.Checked = false;
			txtNomeCrianca.Text = "";
			txtRoupaCrianca.Text = "";
			cbSexoCrianca.SelectedIndex = -1;
			txtSapatoCrianca.Value = 0;
			dtNascimentoCrianca.Value = DateTime.Now;
			
			crianca crianca = new crianca();
			if (!crianca.Inserir(txtCpf.Text)) { erro(); return; }
			criancas.Add(crianca);
		}
		#endregion

		#region Insere as crianças na ComboBox
		private void InserirCrianca(int cd)
        {
			int t = DateTime.Now.Year - criancas[cd].nascimento.Year;
			string n = criancas[cd].nome;
			if (n == null) { n = "Gestando Criança " + criancas.Count; t = 0; }
			if (criancas[cd].nascimento.ToShortDateString() == "01/01/0001") { t = 0; }
			cbCriancas.Items.Add(n + " - " + t + " anos");
		}
        #endregion

        #region Da foco ao campo 'CPF do responsável' após carregar janela
        private void frm_principal_Shown(object sender, EventArgs e)
			{
				txtCpf.Focus();
			}
		#endregion

		#region Habilita o botão 'Consultar' após digitar os onze números do CPF
		private void txtCpf_TextChanged(object sender, EventArgs e)
		{
			if (txtCpf.Text.Length == 11)
				btnConsultar.Enabled = true;
			else
				btnConsultar.Enabled = false;
		}
		#endregion

		#region Habilita o botão 'salvar' após fazer uma alteração em algum campo
			private void txtNome_TextChanged(object sender, EventArgs e)
			{
				btnSalvarResponsavel.Enabled = true;
				cbEditarInfoResponsavel.Enabled = false;
			}
			private void txtRoupa_TextChanged(object sender, EventArgs e)
			{
				if(cbEditarInfoCriancas.Checked)
				{
					btnSalvarCriancas.Enabled = true;
					cbEditarInfoCriancas.Enabled = false;
				}
			}
			private void txtNomeCrianca_TextChanged(object sender, EventArgs e)
			{
				btnSalvarNovaCrianca.Enabled = true;
			}
		#endregion

		#region Habilita/Desabilita os campos com a opção 'Editar informações'
		private void cbEditarInfoResponsavel_CheckedChanged(object sender, EventArgs e)
		{
			if (cbEditarInfoResponsavel.Checked)
			{
				txtEndereco.Enabled = true;
				txtTelefone.Enabled = true;
				txtNome.Enabled = true;
				txtNome.Focus();
			}
			else
			{
				txtEndereco.Enabled = false;
				txtTelefone.Enabled = false;
				txtNome.Enabled = false;
			}
		}
		private void cbEditarInfoCriancas_CheckedChanged(object sender, EventArgs e)
		{
			if (cbEditarInfoCriancas.Checked)
			{
				cbParticipacao.Enabled = true;
				if (criancas[cbCriancas.SelectedIndex].nascimento.ToShortDateString() == "01/01/0001") { dtNascimento.Enabled = true; }
				txtSapato.Enabled = true;
				txtRoupa.Enabled = true;
				if (criancas[cbCriancas.SelectedIndex].sexo.nome == null) { cbSexo.Enabled = true; }
				txtRoupa.Focus();
			}
			else
			{
				cbParticipacao.Enabled = false;
				dtNascimento.Enabled = false;
				txtSapato.Enabled = false;
				txtRoupa.Enabled = false;
				cbSexo.Enabled = false;
			}
		}
		private void cbGestando_CheckedChanged(object sender, EventArgs e)
		{
			btnSalvarNovaCrianca.Enabled = true;
			if (cbGestando.Checked)
			{
				txtRoupaCrianca.Enabled = false;
				txtSapatoCrianca.Enabled = false;
				dtNascimentoCrianca.Enabled = false;
				txtNomeCrianca.Focus();
			}
			else
			{
				txtRoupaCrianca.Enabled = true;
				txtSapatoCrianca.Enabled = true;
				dtNascimentoCrianca.Enabled = true;
			}
		}


		#endregion

		#region Ajusta o tamanho das colunas do Excel
		private void ajustaTamanho(clsExcel Excel)
		{
			Excel.ajustaTamanho("A1", "A1");
			Excel.ajustaTamanho("B1", "B1");
			Excel.ajustaTamanho("C1", "C1");
			Excel.ajustaTamanho("D1", "D1");
			Excel.ajustaTamanho("E1", "E1");
			Excel.ajustaTamanho("F1", "F1");
		}
		#endregion

		#region Gera o cabeçário do Excel
		private void geraCabecario(clsExcel Excel)
		{
			Excel.Adiciona("A1", "NÚMERO");
			Excel.Adiciona("B1", "NOME DA CRIANÇA");
			Excel.Adiciona("C1", "NOME DO RESPONSÁVEL");
			Excel.Adiciona("D1", "NÚMERO DA ROUPA");
			Excel.Adiciona("E1", "NÚMERO DO SAPATO");
			Excel.Adiciona("F1", "SEXO DA CRIANÇA");
			Excel.Negrito("A1", "F1");
		}
		#endregion

		#region Realiza a exportação do excel
			private void btnExportar_Click(object sender, EventArgs e)
			{

				#region Pergunta de segurança
				List<crianca> criancas = new criancas().Convidadas();
				if(criancas.Count == 0)
				{
					MessageBox.Show("Não há nenhum convidado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				if (MessageBox.Show("Tem certeza que deseja exportar " + criancas.Count + " convidado(s) para um excel?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
				{
					return;
				}
				#endregion

				#region Carregando a gridview
				btnExportar.Enabled = false;
				pgExportacao.Maximum = criancas.Count * 2;
				gvExportacao.Rows.Clear(); int n = 1;
				foreach (crianca crianca in criancas)
				{
					pgExportacao.Value++;
					Application.DoEvents();
					gvExportacao.Rows.Add(
						n,
						crianca.nome,
						crianca.responsavel.nome,
						crianca.roupa,
						crianca.sapato,
						crianca.sexo.nome
					); n++;
				}
				#endregion

				#region Gera o excel
				//Forma o Excel
				clsExcel Excel = new clsExcel();
				Excel.CriaExcel();
				Excel.EscolhaPlan(1);
				geraCabecario(Excel);
				for (int i = 1; i < gvExportacao.Rows.Count + 1; i++)
				{
					pgExportacao.Value++;
					Application.DoEvents();
					Excel.Adiciona("A" + (i + 1), gvExportacao.Rows[(i - 1)].Cells[0].Value.ToString());
					Excel.Adiciona("B" + (i + 1), gvExportacao.Rows[(i - 1)].Cells[1].Value.ToString());
					Excel.Adiciona("C" + (i + 1), gvExportacao.Rows[(i - 1)].Cells[2].Value.ToString());
					Excel.Adiciona("D" + (i + 1), gvExportacao.Rows[(i - 1)].Cells[3].Value.ToString());
					Excel.Adiciona("E" + (i + 1), gvExportacao.Rows[(i - 1)].Cells[4].Value.ToString());
					Excel.Adiciona("F" + (i + 1), gvExportacao.Rows[(i - 1)].Cells[5].Value.ToString());
				}
				ajustaTamanho(Excel);
				string final = "F" + (gvExportacao.Rows.Count + 1);
				Excel.Borda("A1", final, "media");

				//Salva o Excel
				Excel.Salvar("Lista de participação " + DateTime.Now.Year); Excel.Fechar();
				string mensagem = "Todos os convidados foram exportados! Acesse o arquivo em sua pasta de Dowloads.";
				MessageBox.Show(mensagem, "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				#endregion

				#region Protocolo de reset
				gvExportacao.Rows.Clear();
				btnExportar.Enabled = true;
				btnExportar.Focus();
				pgExportacao.Value = 0;
				#endregion

			}
		#endregion

		#region Carrega as crianças de um responsável
			private void cbCriancas_SelectedIndexChanged(object sender, EventArgs e)
			{
				txtRoupa.Text = criancas[cbCriancas.SelectedIndex].roupa;
				txtSapato.Value = criancas[cbCriancas.SelectedIndex].sapato;
				if (criancas[cbCriancas.SelectedIndex].sexo.codigo != 0 && criancas[cbCriancas.SelectedIndex].sexo.codigo != 1) { cbSexo.SelectedIndex = -1; }
				else { cbSexo.SelectedIndex = criancas[cbCriancas.SelectedIndex].sexo.codigo; }
				if (criancas[cbCriancas.SelectedIndex].nascimento.ToShortDateString() != "01/01/0001")
				{
					dtNascimento.Value = criancas[cbCriancas.SelectedIndex].nascimento;
				}else { dtNascimento.Value = dtNascimento.MaxDate; }
				cbEditarInfoCriancas.Enabled = true;
				cbEditarInfoCriancas.Checked = false;
				panelInfoCrianca.Visible = true;
			}
		#endregion

		#region Carrega as comboBox 'sexo' ao carregar o forms
			private void frm_principal_Load(object sender, EventArgs e)
			{
				sexos = new sexos().Listar();
				cbSexo.Items.Clear();
				for (int i = 0; i < sexos.Count; i++)
				{
					cbSexo.Items.Add(sexos[i].nome);
				}

				sexos = new sexos().Listar();
				cbSexoCrianca.Items.Clear();
				for (int i = 0; i < sexos.Count; i++)
				{
					cbSexoCrianca.Items.Add(sexos[i].nome);
				}

				dtNascimento.MaxDate = DateTime.Today;
			}
		#endregion

	}
}
