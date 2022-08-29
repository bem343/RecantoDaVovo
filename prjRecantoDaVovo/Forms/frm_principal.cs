using System;
using System.Windows.Forms;
using prjRecantoDaVovo.classes;

namespace prjRecantoDaVovo.Forms
{
	public partial class frm_principal : Form
    {

		private string cpf = "";

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
			private void mostraViews(){
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
				cpf = txtCpf.Text;
				responsavel responsavel = new responsavel(cpf);
				if (!responsavel.Verificar()) {

					// Caso o resonsável não exista
					if (MessageBox.Show("Deseja cadastrá-lo?", "Responsável não cadastrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
						txtCpf.Clear();
						txtCpf.Focus();
						return;
					} else {
						if(!responsavel.Inserir()) { erro(); }
					}
				} else {

					// Caso o responsável já exista
					//carregaInfo();
				}
				mostraViews();
				txtNome.Focus();
			}
			//Botão Concluir
			private void btnConcluir_Click(object sender, EventArgs e)
			{
				if(btnSalvarCriancas.Enabled | btnSalvarNovaCrianca.Enabled | btnSalvarResponsavel.Enabled)
				{
					if(MessageBox.Show("Deseja salvá-las?", "Alterações não salvas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
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
			}
			//Botão Nova criança
			private void btnNovaCrianca_Click(object sender, EventArgs e)
			{
				panelNovaCrianca.Dock = DockStyle.Fill;
				panelNovaCrianca.Visible = true;
				panelCriancas.Visible = false;
				cbGestando.Focus();
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
				if(cbEditarInfoResponsavel.Checked) {
					txtEndereco.Enabled = true;
					txtTelefone.Enabled = true;
					txtNome.Enabled = true;
					txtNome.Focus();
				}
				else {
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

	}
}
