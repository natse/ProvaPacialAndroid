namespace PlanoDeSaudeDoFrancisco.Formularior
{
    partial class FormPlanoDeSaude
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
            this.groupListaPlanoPaciente = new System.Windows.Forms.GroupBox();
            this.dataListaPacientePlano = new System.Windows.Forms.DataGridView();
            this.textInformeNomePlanoPaciente = new System.Windows.Forms.TextBox();
            this.btnBuscarPlanoPaciente = new System.Windows.Forms.Button();
            this.groupAcoesPlanoPaciente = new System.Windows.Forms.GroupBox();
            this.btnSalvarPlanoPaciente = new System.Windows.Forms.Button();
            this.btnAlterarPlanoPaciente = new System.Windows.Forms.Button();
            this.btnExcluirPlanoPaciente = new System.Windows.Forms.Button();
            this.groupDadosPacientePlano = new System.Windows.Forms.GroupBox();
            this.textNomePlanoPaciente = new System.Windows.Forms.TextBox();
            this.labNomePlanoPaciente = new System.Windows.Forms.Label();
            this.groupListaPlanoPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPacientePlano)).BeginInit();
            this.groupAcoesPlanoPaciente.SuspendLayout();
            this.groupDadosPacientePlano.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupListaPlanoPaciente
            // 
            this.groupListaPlanoPaciente.Controls.Add(this.dataListaPacientePlano);
            this.groupListaPlanoPaciente.Controls.Add(this.textInformeNomePlanoPaciente);
            this.groupListaPlanoPaciente.Controls.Add(this.btnBuscarPlanoPaciente);
            this.groupListaPlanoPaciente.Location = new System.Drawing.Point(385, 56);
            this.groupListaPlanoPaciente.Name = "groupListaPlanoPaciente";
            this.groupListaPlanoPaciente.Size = new System.Drawing.Size(403, 272);
            this.groupListaPlanoPaciente.TabIndex = 5;
            this.groupListaPlanoPaciente.TabStop = false;
            this.groupListaPlanoPaciente.Text = "Efetuar Buscar";
            // 
            // dataListaPacientePlano
            // 
            this.dataListaPacientePlano.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListaPacientePlano.Location = new System.Drawing.Point(0, 66);
            this.dataListaPacientePlano.Name = "dataListaPacientePlano";
            this.dataListaPacientePlano.Size = new System.Drawing.Size(403, 193);
            this.dataListaPacientePlano.TabIndex = 3;
            // 
            // textInformeNomePlanoPaciente
            // 
            this.textInformeNomePlanoPaciente.Location = new System.Drawing.Point(6, 40);
            this.textInformeNomePlanoPaciente.Name = "textInformeNomePlanoPaciente";
            this.textInformeNomePlanoPaciente.Size = new System.Drawing.Size(234, 20);
            this.textInformeNomePlanoPaciente.TabIndex = 2;
            // 
            // btnBuscarPlanoPaciente
            // 
            this.btnBuscarPlanoPaciente.Location = new System.Drawing.Point(261, 37);
            this.btnBuscarPlanoPaciente.Name = "btnBuscarPlanoPaciente";
            this.btnBuscarPlanoPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPlanoPaciente.TabIndex = 0;
            this.btnBuscarPlanoPaciente.Text = "Buscar";
            this.btnBuscarPlanoPaciente.UseVisualStyleBackColor = true;
            // 
            // groupAcoesPlanoPaciente
            // 
            this.groupAcoesPlanoPaciente.Controls.Add(this.btnSalvarPlanoPaciente);
            this.groupAcoesPlanoPaciente.Controls.Add(this.btnAlterarPlanoPaciente);
            this.groupAcoesPlanoPaciente.Controls.Add(this.btnExcluirPlanoPaciente);
            this.groupAcoesPlanoPaciente.Location = new System.Drawing.Point(12, 322);
            this.groupAcoesPlanoPaciente.Name = "groupAcoesPlanoPaciente";
            this.groupAcoesPlanoPaciente.Size = new System.Drawing.Size(332, 73);
            this.groupAcoesPlanoPaciente.TabIndex = 4;
            this.groupAcoesPlanoPaciente.TabStop = false;
            this.groupAcoesPlanoPaciente.Text = "Ações";
            // 
            // btnSalvarPlanoPaciente
            // 
            this.btnSalvarPlanoPaciente.Location = new System.Drawing.Point(6, 29);
            this.btnSalvarPlanoPaciente.Name = "btnSalvarPlanoPaciente";
            this.btnSalvarPlanoPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarPlanoPaciente.TabIndex = 5;
            this.btnSalvarPlanoPaciente.Text = "Salvar";
            this.btnSalvarPlanoPaciente.UseVisualStyleBackColor = true;
            this.btnSalvarPlanoPaciente.Click += new System.EventHandler(this.btnSalvarPlanoPaciente_Click);
            // 
            // btnAlterarPlanoPaciente
            // 
            this.btnAlterarPlanoPaciente.Location = new System.Drawing.Point(119, 29);
            this.btnAlterarPlanoPaciente.Name = "btnAlterarPlanoPaciente";
            this.btnAlterarPlanoPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarPlanoPaciente.TabIndex = 6;
            this.btnAlterarPlanoPaciente.Text = "Alterar";
            this.btnAlterarPlanoPaciente.UseVisualStyleBackColor = true;
            this.btnAlterarPlanoPaciente.Click += new System.EventHandler(this.btnAlterarPlanoPaciente_Click);
            // 
            // btnExcluirPlanoPaciente
            // 
            this.btnExcluirPlanoPaciente.Location = new System.Drawing.Point(243, 29);
            this.btnExcluirPlanoPaciente.Name = "btnExcluirPlanoPaciente";
            this.btnExcluirPlanoPaciente.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirPlanoPaciente.TabIndex = 7;
            this.btnExcluirPlanoPaciente.Text = "Excluir";
            this.btnExcluirPlanoPaciente.UseVisualStyleBackColor = true;
            // groupDadosPacientePlano
            // 
            this.groupDadosPacientePlano.Controls.Add(this.textNomePlanoPaciente);
            this.groupDadosPacientePlano.Controls.Add(this.labNomePlanoPaciente);
            this.groupDadosPacientePlano.Location = new System.Drawing.Point(12, 56);
            this.groupDadosPacientePlano.Name = "groupDadosPacientePlano";
            this.groupDadosPacientePlano.Size = new System.Drawing.Size(332, 248);
            this.groupDadosPacientePlano.TabIndex = 3;
            this.groupDadosPacientePlano.TabStop = false;
            this.groupDadosPacientePlano.Text = "Dados ";
            // 
            // textNomePlanoPaciente
            // 
            this.textNomePlanoPaciente.Location = new System.Drawing.Point(94, 29);
            this.textNomePlanoPaciente.Name = "textNomePlanoPaciente";
            this.textNomePlanoPaciente.Size = new System.Drawing.Size(100, 20);
            this.textNomePlanoPaciente.TabIndex = 9;
            // 
            // labNomePlanoPaciente
            // 
            this.labNomePlanoPaciente.AutoSize = true;
            this.labNomePlanoPaciente.Location = new System.Drawing.Point(30, 32);
            this.labNomePlanoPaciente.Name = "labNomePlanoPaciente";
            this.labNomePlanoPaciente.Size = new System.Drawing.Size(35, 13);
            this.labNomePlanoPaciente.TabIndex = 0;
            this.labNomePlanoPaciente.Text = "Nome";
            // 
            // FormPlanoDeSaude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupListaPlanoPaciente);
            this.Controls.Add(this.groupAcoesPlanoPaciente);
            this.Controls.Add(this.groupDadosPacientePlano);
            this.Name = "FormPlanoDeSaude";
            this.Text = "PlanoDeSaude";
            this.groupListaPlanoPaciente.ResumeLayout(false);
            this.groupListaPlanoPaciente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListaPacientePlano)).EndInit();
            this.groupAcoesPlanoPaciente.ResumeLayout(false);
            this.groupDadosPacientePlano.ResumeLayout(false);
            this.groupDadosPacientePlano.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupListaPlanoPaciente;
        private System.Windows.Forms.DataGridView dataListaPacientePlano;
        private System.Windows.Forms.TextBox textInformeNomePlanoPaciente;
        private System.Windows.Forms.Button btnBuscarPlanoPaciente;
        private System.Windows.Forms.GroupBox groupAcoesPlanoPaciente;
        private System.Windows.Forms.Button btnSalvarPlanoPaciente;
        private System.Windows.Forms.Button btnAlterarPlanoPaciente;
        private System.Windows.Forms.Button btnExcluirPlanoPaciente;
        private System.Windows.Forms.GroupBox groupDadosPacientePlano;
        private System.Windows.Forms.TextBox textNomePlanoPaciente;
        private System.Windows.Forms.Label labNomePlanoPaciente;
    }
}