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
				}
			}
			else
			{

				// Caso o responsável já exista
				txtNome.Text = responsavel.nome;
				txtEndereco.Text = responsavel.endereco;
				txtTelefone.Text = responsavel.cel;

				criancas = new criancas().Listar(responsavel.cpf);

				for (int i = 0; i < criancas.Count; i++)
				{
					DateTime nascimento = criancas[i].nascimento;
					int t = DateTime.Now.Year - nascimento.Year;
					cbCriancas.Items.Add(criancas[i].nome + " - " + t + " anos");
				}
			}
			mostraViews();
			txtNome.Focus();

			sexos = new sexos().Listar();

			for (int i = 0; i < sexos.Count; i++)
			{
				cbSexo.Items.Add(sexos[i].nome);
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
			//bool participacao = false;

   //         if (cbEditarInfoCriancas.Checked)
   //         {
			//	int cd = cbCriancas.SelectedIndex;
			//	string roupa = txtRoupa.Text;
			//	int sapato = (int)txtSapato.Value;
			//	sexo sexo = new sexo(cbSexo.SelectedIndex);
   //             if (cbParticipacao.Checked) { participacao = true; }
   //         }
		}
		//Botão Salvar (dados de uma nova criança)
		private void btnSalvarNovaCrianca_Click(object sender, EventArgs e)
		{
			btnSalvarNovaCrianca.Enabled = false;
			panelCriancas.Dock = DockStyle.Fill;
			panelCriancas.Visible = true;
			panelInfoCrianca.Visible = true;
			panelNovaCrianca.Visible = false;
			cbCriancas.Focus();

			int cd = criancas.Count;
			string nome = txtNomeCrianca.Text;
			crianca crianca = null;
			sexo sexo = new sexo(cbSexoCrianca.SelectedIndex);

			if (!cbGestando.Checked)
            {
				string roupa = txtRoupaCrianca.Text;
				int sapato = (int)txtSapatoCrianca.Value;
				DateTime nascimento = dtNascimento.Value;
				crianca = new crianca(cd, nome, roupa, sapato, nascimento, true, sexo);
			} 
			else 
			{
                if (nome == "") { nome = null; }
				crianca = new crianca(cd, nome, sexo, true); 
			}
			
            if (!crianca.Atualiza(txtCpf.Text, cbGestando.Checked)) { erro(); return; }
		}
		//Botão Nova criança
		private void btnNovaCrianca_Click(object sender, EventArgs e)
		{
			panelNovaCrianca.Dock = DockStyle.Fill;
			panelNovaCrianca.Visible = true;
			panelCriancas.Visible = false;
			cbGestando.Focus();

			sexos = new sexos().Listar();
            for (int i = 0; i < sexos.Count; i++)
            {
				cbSexoCrianca.Items.Add(sexos[i].nome);
			}
			
			crianca crianca = new crianca();
			if (!crianca.Inserir(txtCpf.Text)) { erro(); return; }
			criancas.Add(crianca);
		}
		#endregion

		#region Da foco ao campo 'CPF do responsável' após carregar janela
		private void frm_principal_Activated(object sender, EventArgs e)
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
			btnSalvarCriancas.Enabled = true;
			cbEditarInfoCriancas.Enabled = false;
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
				dtNascimento.Enabled = true;
				txtSapato.Enabled = true;
				txtRoupa.Enabled = true;
				cbSexo.Enabled = true;
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
				panelInfoCrianca.Visible = true;
				cbEditarInfoCriancas.Enabled = true;
				txtRoupa.Text = criancas[cbCriancas.SelectedIndex].roupa;
				txtSapato.Value = criancas[cbCriancas.SelectedIndex].sapato;
				cbSexo.Text = criancas[cbCriancas.SelectedIndex].sexo.nome;
				dtNascimento.Value = criancas[cbCriancas.SelectedIndex].nascimento;
			}
		#endregion

	}
}
