namespace PlanoDeSaudeDoFrancisco.Formularior
{
    partial class FormPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupDadosPessoasPaciente = new System.Windows.Forms.GroupBox();
            this.comboPaciente = new System.Windows.Forms.ComboBox();
            this.dateTimePaciente = new System.Windows.Forms.DateTimePicker();
            this.radBtnDependente = new System.Windows.Forms.RadioButton();
            this.radBtnTitulo = new System.Windows.Forms.RadioButton();
            this.textNomePaciente = new System.Windows.Forms.TextBox();
            this.labPaciente = new System.Windows.Forms.Label();
            this.labDataPaciente = new System.Windows.Forms.Label();
            this.labTipo = new System.Windows.Forms.Label();
            this.labNomePaciente = new System.Windows.Forms.Label();
            this.btnSalvarPaciente = new System.Windows.Forms.Button();
            this.btnAlterarPaciente = new System.Windows.Forms.Button();
            this.btnExcluirPaciente = new System.Windows.Forms.Button();
            this.btnNovoPaciente = new System.Windows.Forms.Button();
            this.groupAcoesPaciente = new System.Windows.Forms.GroupBox();
            this.groupListaPaciente = new System.Windows.Forms.GroupBox();
            this.dataListaPaciente = new System.Windows.Forms.DataGridView();
            this.textInformeNomePaciente = new System.Windows.Forms.TextBox();
            this.labInformeNomePaciente = new System.Windows.Forms.Label();
            this.btnBuscarPaciente = new System.Windows.Forms.Button();
            this.groupDadosPessoasPaciente.SuspendLayout();
            this.groupAcoesPaciente.SuspendLayout();
            this.groupListaPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDadosPessoasPaciente
            // 
            this.groupDadosPessoasPaciente.Controls.Add(this.comboPaciente);
            this.groupDadosPessoasPaciente.Controls.Add(this.dateTimePaciente);
            this.groupDadosPessoasPaciente.Controls.Add(this.radBtnDependente);
            this.groupDadosPessoasPaciente.Controls.Add(this.radBtnTitulo);
            this.groupDadosPessoasPaciente.Controls.Add(this.textNomePaciente);
            this.groupDadosPessoasPaciente.Controls.Add(this.labPaciente);
            this.groupDadosPessoasPaciente.Controls.Add(this.labDataPaciente);
            this.groupDadosPessoasPaciente.Controls.Add(this.labTipo);
            this.groupDadosPessoasPaciente.Controls.Add(this.labNomePaciente);
            this.groupDadosPessoasPaciente.Location = new System.Drawing.Point(12, 12);
            this.groupDadosPessoasPaciente.Name = "groupDadosPessoasPaciente";
            this.groupDadosPessoasPaciente.Size = new System.Drawing.Size(332, 248);
            this.groupDadosPessoasPaciente.TabIndex = 0;
            this.groupDadosPessoasPaciente.TabStop = false;
            this.groupDadosPessoasPaciente.Text = "Dados Pessoas";
            // 
            // comboPaciente
            // 
            this.comboPaciente.FormattingEnabled = true;
            this.comboPaciente.Location = new System.Drawing.Point(138, 208);
            this.comboPaciente.Name = "comboPaciente";
            this.comboPaciente.Size = new System.Drawing.Size(121, 21);
            this.comboPaciente.TabIndex = 13;
            // 
            // dateTimePaciente
            // 
            this.dateTimePaciente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePaciente.Location = new System.Drawing.Point(138, 142);
            this.dateTimePaciente.Name = "dateTimePaciente";
            this.dateTimePaciente.Size = new System.Drawing.Size(94, 20);
            this.dateTimePaciente.TabIndex = 12;
            // 
            // radBtnDependente
            // 
            this.radBtnDependente.AutoSize = true;
            this.radBtnDependente.Location = new System.Drawing.Point(243, 84);
            this.radBtnDependente.Name = "radBtnDependente";
            this.radBtnDependente.Size = new System.Drawing.Size(84, 17);
            this.radBtnDependente.TabIndex = 11;
            this.radBtnDependente.TabStop = true;
            this.radBtnDependente.Text = "Dependente";
            this.radBtnDependente.UseVisualStyleBackColor = true;
            // 
            // radBtnTitulo
            // 
            this.radBtnTitulo.AutoSize = true;
            this.radBtnTitulo.Location = new System.Drawing.Point(138, 84);
            this.radBtnTitulo.Name = "radBtnTitulo";
            this.radBtnTitulo.Size = new System.Drawing.Size(54, 17);
            this.radBtnTitulo.TabIndex = 10;
            this.radBtnTitulo.TabStop = true;
            this.radBtnTitulo.Text = "Titulor";
            this.radBtnTitulo.UseVisualStyleBackColor = true;
            // 
            // textNomePaciente
            // 
            this.textNomePaciente.Location = new System.Drawing.Point(94, 29);
            this.textNomePaciente.Name = "textNomePaciente";
            this.textNomePaciente.Size = new System.Drawing.Size(100, 20);
            this.textNomePaciente.TabIndex = 9;
            // 
            // labPaciente
            // 
            this.labPaciente.AutoSize = true;
            this.labPaciente.Location = new System.Drawing.Point(28, 211);
            this.labPaciente.Name = "labPaciente";
            this.labPaciente.Size = new System.Drawing.Size(86, 13);
            this.labPaciente.TabIndex = 3;
            this.labPaciente.Text = "Plano  de Saude";
            // 
            // labDataPaciente
            // 
            this.labDataPaciente.AutoSize = true;
            this.labDataPaciente.Location = new System.Drawing.Point(28, 148);
            this.labDataPaciente.Name = "labDataPaciente";
            this.labDataPaciente.Size = new System.Drawing.Size(99, 13);
            this.labDataPaciente.TabIndex = 2;
            this.labDataPaciente.Text = "Data de Nacimento";
            // 
            // labTipo
            // 
            this.labTipo.AutoSize = true;
            this.labTipo.Location = new System.Drawing.Point(22, 84);
            this.labTipo.Name = "labTipo";
            this.labTipo.Size = new System.Drawing.Size(76, 13);
            this.labTipo.TabIndex = 1;
            this.labTipo.Text = "Tipo Convenio";
            // 
            // labNomePaciente
            // 
            this.labNomePaciente.AutoSize = true;
            this.labNomePaciente.Location = new System.Drawing.Point(30, 32);
            this.labNomePaciente.Name = "labNomePaciente";
            this.labNomePaciente.Size = new System.Drawing.Size(35, 13);
            this.labNomePaciente.TabIndex = 0;
            this.labNomePaciente.Text = "Nome";
            // 
            // btnSalvarPaciente
            // 
            this.btnSalvarPaciente.Location = new System.Drawing.Point(6, 29);
            this.btnSalvarPaciente.Name = "btnSalvarPaciente";
            this.btnSalvarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPaciente.TabIndex = 5;
            this.btnSalvarPaciente.Text = "Salvar";
            this.btnSalvarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnAlterarPaciente
            // 
            this.btnAlterarPaciente.Location = new System.Drawing.Point(119, 29);
            this.btnAlterarPaciente.Name = "btnAlterarPaciente";
            this.btnAlterarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarPaciente.TabIndex = 6;
            this.btnAlterarPaciente.Text = "Alterar";
            this.btnAlterarPaciente.UseVisualStyleBackColor = true;
            // 
            // btnExcluirPaciente
            // 
            this.btnExcluirPaciente.Location = new System.Drawing.Point(243, 29);
            this.btnExcluirPaciente.Name = "btnExcluirPaciente";
            this.btnExcluirPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirPaciente.TabIndex = 7;
            this.btnExcluirPaciente.Text = "Excluir";
            this.btnExcluirPaciente.UseVisualStyleBackColor = true;
            // 
            // btnNovoPaciente
            // 
            this.btnNovoPaciente.Location = new System.Drawing.Point(355, 29);
            this.btnNovoPaciente.Name = "btnNovoPaciente";
            this.btnNovoPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnNovoPaciente.TabIndex = 8;
            this.btnNovoPaciente.Text = "Novo";
            this.btnNovoPaciente.UseVisualStyleBackColor = true;
            // 
            // groupAcoesPaciente
            // 
            this.groupAcoesPaciente.Controls.Add(this.btnSalvarPaciente);
            this.groupAcoesPaciente.Controls.Add(this.btnAlterarPaciente);
            this.groupAcoesPaciente.Controls.Add(this.btnExcluirPaciente);
            this.groupAcoesPaciente.Controls.Add(this.btnNovoPaciente);
            this.groupAcoesPaciente.Location = new System.Drawing.Point(12, 278);
            this.groupAcoesPaciente.Name = "groupAcoesPaciente";
            this.groupAcoesPaciente.Size = new System.Drawing.Size(432, 73);
            this.groupAcoesPaciente.TabIndex = 1;
            this.groupAcoesPaciente.TabStop = false;
            this.groupAcoesPaciente.Text = "Ações";
            // 
            // groupListaPaciente
            // 
            this.groupListaPaciente.Controls.Add(this.dataListaPaciente);
            this.groupListaPaciente.Controls.Add(this.textInformeNomePaciente);
            this.groupListaPaciente.Controls.Add(this.labInformeNomePaciente);
            this.groupListaPaciente.Controls.Add(this.btnBuscarPaciente);
            this.groupListaPaciente.Location = new System.Drawing.Point(385, 25);
            this.groupListaPaciente.Name = "groupListaPaciente";
            this.groupListaPaciente.Size = new System.Drawing.Size(403, 259);
            this.groupListaPaciente.TabIndex = 2;
            this.groupListaPaciente.TabStop = false;
            this.groupListaPaciente.Text = "Lista Paciente";
            // 
            // dataListaPaciente
            // 
            this.dataListaPaciente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaPaciente.Location = new System.Drawing.Point(0, 71);
            this.dataListaPaciente.Name = "dataListaPaciente";
            this.dataListaPaciente.Size = new System.Drawing.Size(403, 188);
            this.dataListaPaciente.TabIndex = 3;
            // 
            // textInformeNomePaciente
            // 
            this.textInformeNomePaciente.Location = new System.Drawing.Point(96, 40);
            this.textInformeNomePaciente.Name = "textInformeNomePaciente";
            this.textInformeNomePaciente.Size = new System.Drawing.Size(170, 20);
            this.textInformeNomePaciente.TabIndex = 2;
            // 
            // labInformeNomePaciente
            // 
            this.labInformeNomePaciente.AutoSize = true;
            this.labInformeNomePaciente.Location = new System.Drawing.Point(17, 40);
            this.labInformeNomePaciente.Name = "labInformeNomePaciente";
            this.labInformeNomePaciente.Size = new System.Drawing.Size(73, 13);
            this.labInformeNomePaciente.TabIndex = 1;
            this.labInformeNomePaciente.Text = "Informe Nome";
            // 
            // btnBuscarPaciente
            // 
            this.btnBuscarPaciente.Location = new System.Drawing.Point(272, 38);
            this.btnBuscarPaciente.Name = "btnBuscarPaciente";
            this.btnBuscarPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPaciente.TabIndex = 0;
            this.btnBuscarPaciente.Text = "Buscar";
            this.btnBuscarPaciente.UseVisualStyleBackColor = true;
            // 
            // FormPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupListaPaciente);
            this.Controls.Add(this.groupAcoesPaciente);
            this.Controls.Add(this.groupDadosPessoasPaciente);
            this.Name = "FormPaciente";
            this.Text = "Paciente";
            this.groupDadosPessoasPaciente.ResumeLayout(false);
            this.groupDadosPessoasPaciente.PerformLayout();
            this.groupAcoesPaciente.ResumeLayout(false);
            this.groupListaPaciente.ResumeLayout(false);
            this.groupListaPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPaciente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDadosPessoasPaciente;
        private System.Windows.Forms.Button btnNovoPaciente;
        private System.Windows.Forms.Button btnExcluirPaciente;
        private System.Windows.Forms.Button btnAlterarPaciente;
        private System.Windows.Forms.Button btnSalvarPaciente;
        private System.Windows.Forms.Label labPaciente;
        private System.Windows.Forms.Label labDataPaciente;
        private System.Windows.Forms.Label labTipo;
        private System.Windows.Forms.Label labNomePaciente;
        private System.Windows.Forms.ComboBox comboPaciente;
        private System.Windows.Forms.DateTimePicker dateTimePaciente;
        private System.Windows.Forms.RadioButton radBtnDependente;
        private System.Windows.Forms.RadioButton radBtnTitulo;
        private System.Windows.Forms.TextBox textNomePaciente;
        private System.Windows.Forms.GroupBox groupAcoesPaciente;
        private System.Windows.Forms.GroupBox groupListaPaciente;
        private System.Windows.Forms.DataGridView dataListaPaciente;
        private System.Windows.Forms.TextBox textInformeNomePaciente;
        private System.Windows.Forms.Label labInformeNomePaciente;
        private System.Windows.Forms.Button btnBuscarPaciente;
    }
}