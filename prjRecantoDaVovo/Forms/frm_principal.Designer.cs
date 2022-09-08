
namespace prjRecantoDaVovo.Forms
{
	partial class frm_principal
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.tcPrincipal = new System.Windows.Forms.TabControl();
            this.tabResponsaveis = new System.Windows.Forms.TabPage();
            this.gbCriancas = new System.Windows.Forms.GroupBox();
            this.panelNovaCrianca = new System.Windows.Forms.Panel();
            this.cbGestando = new System.Windows.Forms.CheckBox();
            this.dtNascimentoCrianca = new System.Windows.Forms.DateTimePicker();
            this.txtSapatoCrianca = new System.Windows.Forms.NumericUpDown();
            this.btnSalvarNovaCrianca = new System.Windows.Forms.Button();
            this.cbSexoCrianca = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeCrianca = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRoupaCrianca = new System.Windows.Forms.TextBox();
            this.panelCriancas = new System.Windows.Forms.Panel();
            this.panelInfoCrianca = new System.Windows.Forms.Panel();
            this.btnSalvarCriancas = new System.Windows.Forms.Button();
            this.dtNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtSapato = new System.Windows.Forms.NumericUpDown();
            this.cbParticipacao = new System.Windows.Forms.CheckBox();
            this.cbEditarInfoCriancas = new System.Windows.Forms.CheckBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRoupa = new System.Windows.Forms.TextBox();
            this.btnNovaCrianca = new System.Windows.Forms.Button();
            this.cbCriancas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbResponsavel = new System.Windows.Forms.GroupBox();
            this.cbEditarInfoResponsavel = new System.Windows.Forms.CheckBox();
            this.btnSalvarResponsavel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnConcluir = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.tabExportacao = new System.Windows.Forms.TabPage();
            this.pgExportacao = new System.Windows.Forms.ProgressBar();
            this.gvExportacao = new System.Windows.Forms.DataGridView();
            this.colNumCrianca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeCrianca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeResponsavel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumRoupa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumSapato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExportar = new System.Windows.Forms.Button();
            this.tcPrincipal.SuspendLayout();
            this.tabResponsaveis.SuspendLayout();
            this.gbCriancas.SuspendLayout();
            this.panelNovaCrianca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSapatoCrianca)).BeginInit();
            this.panelCriancas.SuspendLayout();
            this.panelInfoCrianca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSapato)).BeginInit();
            this.gbResponsavel.SuspendLayout();
            this.tabExportacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvExportacao)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrincipal
            // 
            this.tcPrincipal.Controls.Add(this.tabResponsaveis);
            this.tcPrincipal.Controls.Add(this.tabExportacao);
            this.tcPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tcPrincipal.Name = "tcPrincipal";
            this.tcPrincipal.SelectedIndex = 0;
            this.tcPrincipal.Size = new System.Drawing.Size(987, 557);
            this.tcPrincipal.TabIndex = 0;
            // 
            // tabResponsaveis
            // 
            this.tabResponsaveis.BackColor = System.Drawing.SystemColors.Control;
            this.tabResponsaveis.Controls.Add(this.gbCriancas);
            this.tabResponsaveis.Controls.Add(this.gbResponsavel);
            this.tabResponsaveis.Controls.Add(this.btnConcluir);
            this.tabResponsaveis.Controls.Add(this.txtCpf);
            this.tabResponsaveis.Controls.Add(this.label1);
            this.tabResponsaveis.Controls.Add(this.btnConsultar);
            this.tabResponsaveis.Location = new System.Drawing.Point(4, 27);
            this.tabResponsaveis.Name = "tabResponsaveis";
            this.tabResponsaveis.Padding = new System.Windows.Forms.Padding(3);
            this.tabResponsaveis.Size = new System.Drawing.Size(979, 526);
            this.tabResponsaveis.TabIndex = 0;
            this.tabResponsaveis.Text = "Responsáveis e crianças";
            // 
            // gbCriancas
            // 
            this.gbCriancas.Controls.Add(this.panelNovaCrianca);
            this.gbCriancas.Controls.Add(this.panelCriancas);
            this.gbCriancas.Location = new System.Drawing.Point(326, 100);
            this.gbCriancas.Name = "gbCriancas";
            this.gbCriancas.Size = new System.Drawing.Size(612, 360);
            this.gbCriancas.TabIndex = 4;
            this.gbCriancas.TabStop = false;
            this.gbCriancas.Text = "Dados das crianças";
            this.gbCriancas.Visible = false;
            // 
            // panelNovaCrianca
            // 
            this.panelNovaCrianca.Controls.Add(this.cbGestando);
            this.panelNovaCrianca.Controls.Add(this.dtNascimentoCrianca);
            this.panelNovaCrianca.Controls.Add(this.txtSapatoCrianca);
            this.panelNovaCrianca.Controls.Add(this.btnSalvarNovaCrianca);
            this.panelNovaCrianca.Controls.Add(this.cbSexoCrianca);
            this.panelNovaCrianca.Controls.Add(this.label11);
            this.panelNovaCrianca.Controls.Add(this.label12);
            this.panelNovaCrianca.Controls.Add(this.label13);
            this.panelNovaCrianca.Controls.Add(this.label10);
            this.panelNovaCrianca.Controls.Add(this.txtNomeCrianca);
            this.panelNovaCrianca.Controls.Add(this.label14);
            this.panelNovaCrianca.Controls.Add(this.txtRoupaCrianca);
            this.panelNovaCrianca.Location = new System.Drawing.Point(3, 22);
            this.panelNovaCrianca.Name = "panelNovaCrianca";
            this.panelNovaCrianca.Size = new System.Drawing.Size(606, 335);
            this.panelNovaCrianca.TabIndex = 1;
            // 
            // cbGestando
            // 
            this.cbGestando.AutoSize = true;
            this.cbGestando.Location = new System.Drawing.Point(61, 37);
            this.cbGestando.Name = "cbGestando";
            this.cbGestando.Size = new System.Drawing.Size(95, 22);
            this.cbGestando.TabIndex = 0;
            this.cbGestando.Text = "Gestando";
            this.cbGestando.UseVisualStyleBackColor = true;
            this.cbGestando.CheckedChanged += new System.EventHandler(this.cbGestando_CheckedChanged);
            // 
            // dtNascimentoCrianca
            // 
            this.dtNascimentoCrianca.CustomFormat = "";
            this.dtNascimentoCrianca.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimentoCrianca.Location = new System.Drawing.Point(226, 244);
            this.dtNascimentoCrianca.MaxDate = new System.DateTime(2022, 10, 1, 0, 0, 0, 0);
            this.dtNascimentoCrianca.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtNascimentoCrianca.Name = "dtNascimentoCrianca";
            this.dtNascimentoCrianca.Size = new System.Drawing.Size(165, 26);
            this.dtNascimentoCrianca.TabIndex = 5;
            this.dtNascimentoCrianca.Value = new System.DateTime(2022, 9, 2, 0, 0, 0, 0);
            this.dtNascimentoCrianca.ValueChanged += new System.EventHandler(this.txtNomeCrianca_TextChanged);
            // 
            // txtSapatoCrianca
            // 
            this.txtSapatoCrianca.Location = new System.Drawing.Point(296, 207);
            this.txtSapatoCrianca.Name = "txtSapatoCrianca";
            this.txtSapatoCrianca.Size = new System.Drawing.Size(95, 26);
            this.txtSapatoCrianca.TabIndex = 4;
            this.txtSapatoCrianca.ValueChanged += new System.EventHandler(this.txtNomeCrianca_TextChanged);
            // 
            // btnSalvarNovaCrianca
            // 
            this.btnSalvarNovaCrianca.Enabled = false;
            this.btnSalvarNovaCrianca.Location = new System.Drawing.Point(497, 284);
            this.btnSalvarNovaCrianca.Name = "btnSalvarNovaCrianca";
            this.btnSalvarNovaCrianca.Size = new System.Drawing.Size(95, 39);
            this.btnSalvarNovaCrianca.TabIndex = 6;
            this.btnSalvarNovaCrianca.Text = "Salvar";
            this.btnSalvarNovaCrianca.UseVisualStyleBackColor = true;
            this.btnSalvarNovaCrianca.Click += new System.EventHandler(this.btnSalvarNovaCrianca_Click);
            // 
            // cbSexoCrianca
            // 
            this.cbSexoCrianca.FormattingEnabled = true;
            this.cbSexoCrianca.Location = new System.Drawing.Point(226, 134);
            this.cbSexoCrianca.Name = "cbSexoCrianca";
            this.cbSexoCrianca.Size = new System.Drawing.Size(165, 26);
            this.cbSexoCrianca.TabIndex = 2;
            this.cbSexoCrianca.SelectedIndexChanged += new System.EventHandler(this.txtNomeCrianca_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(58, 247);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "Data de nascimento";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(58, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "Número do sapato";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(58, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "Sexo da criança";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(58, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nome";
            // 
            // txtNomeCrianca
            // 
            this.txtNomeCrianca.Location = new System.Drawing.Point(61, 95);
            this.txtNomeCrianca.Name = "txtNomeCrianca";
            this.txtNomeCrianca.Size = new System.Drawing.Size(330, 26);
            this.txtNomeCrianca.TabIndex = 1;
            this.txtNomeCrianca.TextChanged += new System.EventHandler(this.txtNomeCrianca_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(58, 173);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 18);
            this.label14.TabIndex = 5;
            this.label14.Text = "Tamanho da roupa";
            // 
            // txtRoupaCrianca
            // 
            this.txtRoupaCrianca.Location = new System.Drawing.Point(296, 170);
            this.txtRoupaCrianca.Name = "txtRoupaCrianca";
            this.txtRoupaCrianca.Size = new System.Drawing.Size(95, 26);
            this.txtRoupaCrianca.TabIndex = 3;
            this.txtRoupaCrianca.TextChanged += new System.EventHandler(this.txtNomeCrianca_TextChanged);
            // 
            // panelCriancas
            // 
            this.panelCriancas.Controls.Add(this.panelInfoCrianca);
            this.panelCriancas.Controls.Add(this.btnNovaCrianca);
            this.panelCriancas.Controls.Add(this.cbCriancas);
            this.panelCriancas.Controls.Add(this.label5);
            this.panelCriancas.Location = new System.Drawing.Point(3, 22);
            this.panelCriancas.Name = "panelCriancas";
            this.panelCriancas.Size = new System.Drawing.Size(606, 335);
            this.panelCriancas.TabIndex = 0;
            // 
            // panelInfoCrianca
            // 
            this.panelInfoCrianca.Controls.Add(this.btnSalvarCriancas);
            this.panelInfoCrianca.Controls.Add(this.dtNascimento);
            this.panelInfoCrianca.Controls.Add(this.txtSapato);
            this.panelInfoCrianca.Controls.Add(this.cbParticipacao);
            this.panelInfoCrianca.Controls.Add(this.cbEditarInfoCriancas);
            this.panelInfoCrianca.Controls.Add(this.cbSexo);
            this.panelInfoCrianca.Controls.Add(this.label9);
            this.panelInfoCrianca.Controls.Add(this.label8);
            this.panelInfoCrianca.Controls.Add(this.label7);
            this.panelInfoCrianca.Controls.Add(this.label6);
            this.panelInfoCrianca.Controls.Add(this.txtRoupa);
            this.panelInfoCrianca.Location = new System.Drawing.Point(14, 74);
            this.panelInfoCrianca.Name = "panelInfoCrianca";
            this.panelInfoCrianca.Size = new System.Drawing.Size(578, 249);
            this.panelInfoCrianca.TabIndex = 12;
            this.panelInfoCrianca.Visible = false;
            // 
            // btnSalvarCriancas
            // 
            this.btnSalvarCriancas.Enabled = false;
            this.btnSalvarCriancas.Location = new System.Drawing.Point(483, 210);
            this.btnSalvarCriancas.Name = "btnSalvarCriancas";
            this.btnSalvarCriancas.Size = new System.Drawing.Size(95, 39);
            this.btnSalvarCriancas.TabIndex = 8;
            this.btnSalvarCriancas.Text = "Salvar";
            this.btnSalvarCriancas.UseVisualStyleBackColor = true;
            this.btnSalvarCriancas.Click += new System.EventHandler(this.btnSalvarCriancas_Click);
            // 
            // dtNascimento
            // 
            this.dtNascimento.CustomFormat = "%d %m %y";
            this.dtNascimento.Enabled = false;
            this.dtNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNascimento.Location = new System.Drawing.Point(209, 133);
            this.dtNascimento.MaxDate = new System.DateTime(2022, 8, 27, 0, 0, 0, 0);
            this.dtNascimento.MinDate = new System.DateTime(2010, 1, 1, 0, 0, 0, 0);
            this.dtNascimento.Name = "dtNascimento";
            this.dtNascimento.Size = new System.Drawing.Size(165, 26);
            this.dtNascimento.TabIndex = 6;
            this.dtNascimento.Value = new System.DateTime(2022, 8, 27, 0, 0, 0, 0);
            this.dtNascimento.ValueChanged += new System.EventHandler(this.txtRoupa_TextChanged);
            // 
            // txtSapato
            // 
            this.txtSapato.Enabled = false;
            this.txtSapato.Location = new System.Drawing.Point(279, 69);
            this.txtSapato.Name = "txtSapato";
            this.txtSapato.Size = new System.Drawing.Size(95, 26);
            this.txtSapato.TabIndex = 4;
            this.txtSapato.ValueChanged += new System.EventHandler(this.txtRoupa_TextChanged);
            // 
            // cbParticipacao
            // 
            this.cbParticipacao.AutoSize = true;
            this.cbParticipacao.Enabled = false;
            this.cbParticipacao.Location = new System.Drawing.Point(254, 189);
            this.cbParticipacao.Name = "cbParticipacao";
            this.cbParticipacao.Size = new System.Drawing.Size(120, 22);
            this.cbParticipacao.TabIndex = 7;
            this.cbParticipacao.Text = "Vai participar";
            this.cbParticipacao.UseVisualStyleBackColor = true;
            this.cbParticipacao.CheckedChanged += new System.EventHandler(this.txtRoupa_TextChanged);
            // 
            // cbEditarInfoCriancas
            // 
            this.cbEditarInfoCriancas.AutoSize = true;
            this.cbEditarInfoCriancas.Location = new System.Drawing.Point(44, 189);
            this.cbEditarInfoCriancas.Name = "cbEditarInfoCriancas";
            this.cbEditarInfoCriancas.Size = new System.Drawing.Size(159, 22);
            this.cbEditarInfoCriancas.TabIndex = 2;
            this.cbEditarInfoCriancas.Text = "Editar informações";
            this.cbEditarInfoCriancas.UseVisualStyleBackColor = true;
            this.cbEditarInfoCriancas.CheckedChanged += new System.EventHandler(this.cbEditarInfoCriancas_CheckedChanged);
            // 
            // cbSexo
            // 
            this.cbSexo.Enabled = false;
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(209, 101);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(165, 26);
            this.cbSexo.TabIndex = 5;
            this.cbSexo.SelectedIndexChanged += new System.EventHandler(this.txtRoupa_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Data de nascimento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sexo da criança";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Número do sapato";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tamanho da roupa";
            // 
            // txtRoupa
            // 
            this.txtRoupa.Enabled = false;
            this.txtRoupa.Location = new System.Drawing.Point(279, 37);
            this.txtRoupa.Name = "txtRoupa";
            this.txtRoupa.Size = new System.Drawing.Size(95, 26);
            this.txtRoupa.TabIndex = 3;
            this.txtRoupa.TextChanged += new System.EventHandler(this.txtRoupa_TextChanged);
            // 
            // btnNovaCrianca
            // 
            this.btnNovaCrianca.Enabled = false;
            this.btnNovaCrianca.Location = new System.Drawing.Point(434, 35);
            this.btnNovaCrianca.Name = "btnNovaCrianca";
            this.btnNovaCrianca.Size = new System.Drawing.Size(127, 26);
            this.btnNovaCrianca.TabIndex = 1;
            this.btnNovaCrianca.Text = "Nova criança";
            this.btnNovaCrianca.UseVisualStyleBackColor = true;
            this.btnNovaCrianca.Click += new System.EventHandler(this.btnNovaCrianca_Click);
            // 
            // cbCriancas
            // 
            this.cbCriancas.Enabled = false;
            this.cbCriancas.FormattingEnabled = true;
            this.cbCriancas.Location = new System.Drawing.Point(14, 35);
            this.cbCriancas.Name = "cbCriancas";
            this.cbCriancas.Size = new System.Drawing.Size(414, 26);
            this.cbCriancas.TabIndex = 0;
            this.cbCriancas.SelectedIndexChanged += new System.EventHandler(this.cbCriancas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Criança";
            // 
            // gbResponsavel
            // 
            this.gbResponsavel.Controls.Add(this.cbEditarInfoResponsavel);
            this.gbResponsavel.Controls.Add(this.btnSalvarResponsavel);
            this.gbResponsavel.Controls.Add(this.label4);
            this.gbResponsavel.Controls.Add(this.txtTelefone);
            this.gbResponsavel.Controls.Add(this.label3);
            this.gbResponsavel.Controls.Add(this.txtEndereco);
            this.gbResponsavel.Controls.Add(this.label2);
            this.gbResponsavel.Controls.Add(this.txtNome);
            this.gbResponsavel.Location = new System.Drawing.Point(39, 100);
            this.gbResponsavel.Name = "gbResponsavel";
            this.gbResponsavel.Size = new System.Drawing.Size(281, 360);
            this.gbResponsavel.TabIndex = 3;
            this.gbResponsavel.TabStop = false;
            this.gbResponsavel.Text = "Dados do responsável";
            this.gbResponsavel.Visible = false;
            // 
            // cbEditarInfoResponsavel
            // 
            this.cbEditarInfoResponsavel.AutoSize = true;
            this.cbEditarInfoResponsavel.Location = new System.Drawing.Point(15, 266);
            this.cbEditarInfoResponsavel.Name = "cbEditarInfoResponsavel";
            this.cbEditarInfoResponsavel.Size = new System.Drawing.Size(159, 22);
            this.cbEditarInfoResponsavel.TabIndex = 4;
            this.cbEditarInfoResponsavel.Text = "Editar informações";
            this.cbEditarInfoResponsavel.UseVisualStyleBackColor = true;
            this.cbEditarInfoResponsavel.Visible = false;
            this.cbEditarInfoResponsavel.CheckedChanged += new System.EventHandler(this.cbEditarInfoResponsavel_CheckedChanged);
            // 
            // btnSalvarResponsavel
            // 
            this.btnSalvarResponsavel.Enabled = false;
            this.btnSalvarResponsavel.Location = new System.Drawing.Point(170, 306);
            this.btnSalvarResponsavel.Name = "btnSalvarResponsavel";
            this.btnSalvarResponsavel.Size = new System.Drawing.Size(95, 39);
            this.btnSalvarResponsavel.TabIndex = 3;
            this.btnSalvarResponsavel.Text = "Salvar";
            this.btnSalvarResponsavel.UseVisualStyleBackColor = true;
            this.btnSalvarResponsavel.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Celular";
            // 
            // txtTelefone
            // 
            this.txtTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.Location = new System.Drawing.Point(15, 177);
            this.txtTelefone.Mask = "(99) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(250, 26);
            this.txtTelefone.TabIndex = 2;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereço";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(15, 117);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(250, 26);
            this.txtEndereco.TabIndex = 1;
            this.txtEndereco.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(15, 57);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(250, 26);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnConcluir
            // 
            this.btnConcluir.Location = new System.Drawing.Point(826, 473);
            this.btnConcluir.Name = "btnConcluir";
            this.btnConcluir.Size = new System.Drawing.Size(95, 39);
            this.btnConcluir.TabIndex = 9;
            this.btnConcluir.Text = "Concluir";
            this.btnConcluir.UseVisualStyleBackColor = true;
            this.btnConcluir.Visible = false;
            this.btnConcluir.Click += new System.EventHandler(this.btnConcluir_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpf.Location = new System.Drawing.Point(39, 59);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(208, 26);
            this.txtCpf.TabIndex = 0;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpf.TextChanged += new System.EventHandler(this.txtCpf_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF do responsável";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Enabled = false;
            this.btnConsultar.Location = new System.Drawing.Point(253, 59);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(127, 26);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // tabExportacao
            // 
            this.tabExportacao.BackColor = System.Drawing.SystemColors.Control;
            this.tabExportacao.Controls.Add(this.pgExportacao);
            this.tabExportacao.Controls.Add(this.gvExportacao);
            this.tabExportacao.Controls.Add(this.btnExportar);
            this.tabExportacao.Location = new System.Drawing.Point(4, 27);
            this.tabExportacao.Name = "tabExportacao";
            this.tabExportacao.Padding = new System.Windows.Forms.Padding(3);
            this.tabExportacao.Size = new System.Drawing.Size(979, 526);
            this.tabExportacao.TabIndex = 1;
            this.tabExportacao.Text = "Lista de convites";
            // 
            // pgExportacao
            // 
            this.pgExportacao.Location = new System.Drawing.Point(39, 452);
            this.pgExportacao.Name = "pgExportacao";
            this.pgExportacao.Size = new System.Drawing.Size(895, 16);
            this.pgExportacao.TabIndex = 2;
            // 
            // gvExportacao
            // 
            this.gvExportacao.AllowUserToAddRows = false;
            this.gvExportacao.AllowUserToDeleteRows = false;
            this.gvExportacao.AllowUserToResizeColumns = false;
            this.gvExportacao.AllowUserToResizeRows = false;
            this.gvExportacao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvExportacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvExportacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNumCrianca,
            this.colNomeCrianca,
            this.colNomeResponsavel,
            this.colNumRoupa,
            this.colNumSapato,
            this.colSexo});
            this.gvExportacao.Location = new System.Drawing.Point(39, 91);
            this.gvExportacao.Name = "gvExportacao";
            this.gvExportacao.ReadOnly = true;
            this.gvExportacao.RowHeadersVisible = false;
            this.gvExportacao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvExportacao.Size = new System.Drawing.Size(895, 355);
            this.gvExportacao.TabIndex = 1;
            this.gvExportacao.TabStop = false;
            // 
            // colNumCrianca
            // 
            this.colNumCrianca.HeaderText = "Número";
            this.colNumCrianca.Name = "colNumCrianca";
            this.colNumCrianca.ReadOnly = true;
            // 
            // colNomeCrianca
            // 
            this.colNomeCrianca.HeaderText = "Nome da criança";
            this.colNomeCrianca.Name = "colNomeCrianca";
            this.colNomeCrianca.ReadOnly = true;
            // 
            // colNomeResponsavel
            // 
            this.colNomeResponsavel.HeaderText = "Nome do responsável";
            this.colNomeResponsavel.Name = "colNomeResponsavel";
            this.colNomeResponsavel.ReadOnly = true;
            // 
            // colNumRoupa
            // 
            this.colNumRoupa.HeaderText = "Número da roupa";
            this.colNumRoupa.Name = "colNumRoupa";
            this.colNumRoupa.ReadOnly = true;
            // 
            // colNumSapato
            // 
            this.colNumSapato.HeaderText = "Número do sapato";
            this.colNumSapato.Name = "colNumSapato";
            this.colNumSapato.ReadOnly = true;
            // 
            // colSexo
            // 
            this.colSexo.HeaderText = "Sexo da criança";
            this.colSexo.Name = "colSexo";
            this.colSexo.ReadOnly = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(39, 59);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(127, 26);
            this.btnExportar.TabIndex = 0;
            this.btnExportar.Text = "Exportar lista";
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(987, 557);
            this.Controls.Add(this.tcPrincipal);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recanto da vovó";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_principal_FormClosed);
            this.Load += new System.EventHandler(this.frm_principal_Load);
            this.Shown += new System.EventHandler(this.frm_principal_Shown);
            this.tcPrincipal.ResumeLayout(false);
            this.tabResponsaveis.ResumeLayout(false);
            this.tabResponsaveis.PerformLayout();
            this.gbCriancas.ResumeLayout(false);
            this.panelNovaCrianca.ResumeLayout(false);
            this.panelNovaCrianca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSapatoCrianca)).EndInit();
            this.panelCriancas.ResumeLayout(false);
            this.panelCriancas.PerformLayout();
            this.panelInfoCrianca.ResumeLayout(false);
            this.panelInfoCrianca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSapato)).EndInit();
            this.gbResponsavel.ResumeLayout(false);
            this.gbResponsavel.PerformLayout();
            this.tabExportacao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvExportacao)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tcPrincipal;
		private System.Windows.Forms.TabPage tabResponsaveis;
		private System.Windows.Forms.TabPage tabExportacao;
		private System.Windows.Forms.MaskedTextBox txtCpf;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnConsultar;
		private System.Windows.Forms.GroupBox gbCriancas;
		private System.Windows.Forms.GroupBox gbResponsavel;
		private System.Windows.Forms.CheckBox cbEditarInfoResponsavel;
		private System.Windows.Forms.Button btnSalvarResponsavel;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox txtTelefone;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtEndereco;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.Button btnConcluir;
		private System.Windows.Forms.Panel panelCriancas;
		private System.Windows.Forms.Button btnNovaCrianca;
		private System.Windows.Forms.Button btnSalvarCriancas;
		private System.Windows.Forms.ComboBox cbCriancas;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panelNovaCrianca;
		private System.Windows.Forms.DateTimePicker dtNascimentoCrianca;
		private System.Windows.Forms.NumericUpDown txtSapatoCrianca;
		private System.Windows.Forms.Button btnSalvarNovaCrianca;
		private System.Windows.Forms.ComboBox cbSexoCrianca;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtRoupaCrianca;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtNomeCrianca;
		private System.Windows.Forms.CheckBox cbGestando;
		private System.Windows.Forms.Button btnExportar;
		private System.Windows.Forms.ProgressBar pgExportacao;
		private System.Windows.Forms.DataGridView gvExportacao;
		private System.Windows.Forms.Panel panelInfoCrianca;
		private System.Windows.Forms.DateTimePicker dtNascimento;
		private System.Windows.Forms.NumericUpDown txtSapato;
		private System.Windows.Forms.CheckBox cbParticipacao;
		private System.Windows.Forms.CheckBox cbEditarInfoCriancas;
		private System.Windows.Forms.ComboBox cbSexo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtRoupa;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNumCrianca;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNomeCrianca;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNomeResponsavel;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNumRoupa;
		private System.Windows.Forms.DataGridViewTextBoxColumn colNumSapato;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSexo;
	}
}

