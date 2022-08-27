using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjRecantoDaVovo.Forms
{
	public partial class frm_login : Form
	{

		#region Variáveis globais
			string senha = "1234";
		#endregion

		#region Construtores
		public frm_login()
			{
				InitializeComponent();
			}
		#endregion

		#region Form Load 
		private void frm_login_Load(object sender, EventArgs e)
			{
				txtSenha.Focus();
			}
		#endregion

		#region Verifica a senha e caso esteja correta da permissão ao resto do programa
		private void btnEntrar_Click(object sender, EventArgs e)
			{
				if(txtSenha.Text == senha) {
					frm_principal frmPrincipal = new frm_principal();
					frmPrincipal.Show();
					this.Hide();
				}
				else {
					MessageBox.Show("Senha incorreta!", "Acesso negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtSenha.Clear();
					txtSenha.Focus();
				}
			}
		#endregion

		#region Libera o botão 'entrar' ao completar os quatro digitos
		private void txtSenha_TextChanged(object sender, EventArgs e)
			{
				if(txtSenha.TextLength == txtSenha.MaxLength)
					btnEntrar.Enabled = true;
				else
					btnEntrar.Enabled = false;
			}
		#endregion
	}
}
