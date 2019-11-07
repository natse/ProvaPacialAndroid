namespace PlanoDeSaudeDoFrancisco.Formularior
{
    partial class FormAtendimento
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
            this.groupDadosAtedimento = new System.Windows.Forms.GroupBox();
            this.groupAtendimento = new System.Windows.Forms.GroupBox();
            this.btnBuscarAtedimento = new System.Windows.Forms.Button();
            this.textPlanoAtedimento = new System.Windows.Forms.TextBox();
            this.textNascidoAtedimento = new System.Windows.Forms.TextBox();
            this.textNomeAtedimento = new System.Windows.Forms.TextBox();
            this.labPlanoAtedimento = new System.Windows.Forms.Label();
            this.labNascidoAtendimento = new System.Windows.Forms.Label();
            this.labNomeAtendimento = new System.Windows.Forms.Label();
            this.labPacienteAtendimento = new System.Windows.Forms.Label();
            this.dateTimeAtendimento = new System.Windows.Forms.DateTimePicker();
            this.labDataAtendimento = new System.Windows.Forms.Label();
            this.btnFinalizarAtedimento = new System.Windows.Forms.Button();
            this.groupListaDeExamesAtedimento = new System.Windows.Forms.GroupBox();
            this.dataAtedimento = new System.Windows.Forms.DataGridView();
            this.btnAdicinarExameAtedimento = new System.Windows.Forms.Button();
            this.btnRemovarAtedimento = new System.Windows.Forms.Button();
            this.groupDadosAtedimento.SuspendLayout();
            this.groupAtendimento.SuspendLayout();
            this.groupListaDeExamesAtedimento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAtedimento)).BeginInit();
            this.SuspendLayout();
            // 
            // groupDadosAtedimento
            // 
            this.groupDadosAtedimento.Controls.Add(this.groupAtendimento);
            this.groupDadosAtedimento.Controls.Add(this.labPacienteAtendimento);
            this.groupDadosAtedimento.Controls.Add(this.dateTimeAtendimento);
            this.groupDadosAtedimento.Controls.Add(this.labDataAtendimento);
            this.groupDadosAtedimento.Location = new System.Drawing.Point(25, 26);
            this.groupDadosAtedimento.Name = "groupDadosAtedimento";
            this.groupDadosAtedimento.Size = new System.Drawing.Size(635, 176);
            this.groupDadosAtedimento.TabIndex = 0;
            this.groupDadosAtedimento.TabStop = false;
            this.groupDadosAtedimento.Text = "Dados de Atendimento";
            // 
            // groupAtendimento
            // 
            this.groupAtendimento.Controls.Add(this.btnBuscarAtedimento);
            this.groupAtendimento.Controls.Add(this.textPlanoAtedimento);
            this.groupAtendimento.Controls.Add(this.textNascidoAtedimento);
            this.groupAtendimento.Controls.Add(this.textNomeAtedimento);
            this.groupAtendimento.Controls.Add(this.labPlanoAtedimento);
            this.groupAtendimento.Controls.Add(this.labNascidoAtendimento);
            this.groupAtendimento.Controls.Add(this.labNomeAtendimento);
            this.groupAtendimento.Location = new System.Drawing.Point(99, 56);
            this.groupAtendimento.Name = "groupAtendimento";
            this.groupAtendimento.Size = new System.Drawing.Size(382, 100);
            this.groupAtendimento.TabIndex = 3;
            this.groupAtendimento.TabStop = false;
            // 
            // btnBuscarAtedimento
            // 
            this.btnBuscarAtedimento.Location = new System.Drawing.Point(272, 34);
            this.btnBuscarAtedimento.Name = "btnBuscarAtedimento";
            this.btnBuscarAtedimento.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAtedimento.TabIndex = 6;
            this.btnBuscarAtedimento.Text = "Buscar";
            this.btnBuscarAtedimento.UseVisualStyleBackColor = true;
            // 
            // textPlanoAtedimento
            // 
            this.textPlanoAtedimento.Location = new System.Drawing.Point(110, 74);
            this.textPlanoAtedimento.Name = "textPlanoAtedimento";
            this.textPlanoAtedimento.Size = new System.Drawing.Size(137, 20);
            this.textPlanoAtedimento.TabIndex = 5;
            // 
            // textNascidoAtedimento
            // 
            this.textNascidoAtedimento.Location = new System.Drawing.Point(110, 49);
            this.textNascidoAtedimento.Name = "textNascidoAtedimento";
            this.textNascidoAtedimento.Size = new System.Drawing.Size(137, 20);
            this.textNascidoAtedimento.TabIndex = 4;
            // 
            // textNomeAtedimento
            // 
            this.textNomeAtedimento.Location = new System.Drawing.Point(110, 16);
            this.textNomeAtedimento.Name = "textNomeAtedimento";
            this.textNomeAtedimento.Size = new System.Drawing.Size(137, 20);
            this.textNomeAtedimento.TabIndex = 3;
            // 
            // labPlanoAtedimento
            // 
            this.labPlanoAtedimento.AutoSize = true;
            this.labPlanoAtedimento.Location = new System.Drawing.Point(46, 73);
            this.labPlanoAtedimento.Name = "labPlanoAtedimento";
            this.labPlanoAtedimento.Size = new System.Drawing.Size(37, 13);
            this.labPlanoAtedimento.TabIndex = 2;
            this.labPlanoAtedimento.Text = "Plano:";
            // 
            // labNascidoAtendimento
            // 
            this.labNascidoAtendimento.AutoSize = true;
            this.labNascidoAtendimento.Location = new System.Drawing.Point(15, 49);
            this.labNascidoAtendimento.Name = "labNascidoAtendimento";
            this.labNascidoAtendimento.Size = new System.Drawing.Size(69, 13);
            this.labNascidoAtendimento.TabIndex = 1;
            this.labNascidoAtendimento.Text = "Nascido em :";
            // 
            // labNomeAtendimento
            // 
            this.labNomeAtendimento.AutoSize = true;
            this.labNomeAtendimento.Location = new System.Drawing.Point(46, 16);
            this.labNomeAtendimento.Name = "labNomeAtendimento";
            this.labNomeAtendimento.Size = new System.Drawing.Size(38, 13);
            this.labNomeAtendimento.TabIndex = 0;
            this.labNomeAtendimento.Text = "Nome:";
            // 
            // labPacienteAtendimento
            // 
            this.labPacienteAtendimento.AutoSize = true;
            this.labPacienteAtendimento.Location = new System.Drawing.Point(34, 90);
            this.labPacienteAtendimento.Name = "labPacienteAtendimento";
            this.labPacienteAtendimento.Size = new System.Drawing.Size(49, 13);
            this.labPacienteAtendimento.TabIndex = 2;
            this.labPacienteAtendimento.Text = "Paciente";
            // 
            // dateTimeAtendimento
            // 
            this.dateTimeAtendimento.Location = new System.Drawing.Point(160, 30);
            this.dateTimeAtendimento.Name = "dateTimeAtendimento";
            this.dateTimeAtendimento.Size = new System.Drawing.Size(88, 20);
            this.dateTimeAtendimento.TabIndex = 1;
            // 
            // labDataAtendimento
            // 
            this.labDataAtendimento.AutoSize = true;
            this.labDataAtendimento.Location = new System.Drawing.Point(34, 36);
            this.labDataAtendimento.Name = "labDataAtendimento";
            this.labDataAtendimento.Size = new System.Drawing.Size(107, 13);
            this.labDataAtendimento.TabIndex = 0;
            this.labDataAtendimento.Text = "Data de Atendimento";
            // 
            // btnFinalizarAtedimento
            // 
            this.btnFinalizarAtedimento.BackColor = System.Drawing.Color.Aqua;
            this.btnFinalizarAtedimento.Location = new System.Drawing.Point(585, 12);
            this.btnFinalizarAtedimento.Name = "btnFinalizarAtedimento";
            this.btnFinalizarAtedimento.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizarAtedimento.TabIndex = 1;
            this.btnFinalizarAtedimento.Text = "Finalizar";
            this.btnFinalizarAtedimento.UseVisualStyleBackColor = false;
            // 
            // groupListaDeExamesAtedimento
            // 
            this.groupListaDeExamesAtedimento.Controls.Add(this.dataAtedimento);
            this.groupListaDeExamesAtedimento.Location = new System.Drawing.Point(25, 264);
            this.groupListaDeExamesAtedimento.Name = "groupListaDeExamesAtedimento";
            this.groupListaDeExamesAtedimento.Size = new System.Drawing.Size(635, 158);
            this.groupListaDeExamesAtedimento.TabIndex = 2;
            this.groupListaDeExamesAtedimento.TabStop = false;
            this.groupListaDeExamesAtedimento.Text = "Lista de Exame";
            // 
            // dataAtedimento
            // 
            this.dataAtedimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAtedimento.Location = new System.Drawing.Point(6, 19);
            this.dataAtedimento.Name = "dataAtedimento";
            this.dataAtedimento.Size = new System.Drawing.Size(623, 128);
            this.dataAtedimento.TabIndex = 0;
            // 
            // btnAdicinarExameAtedimento
            // 
            this.btnAdicinarExameAtedimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdicinarExameAtedimento.Location = new System.Drawing.Point(31, 235);
            this.btnAdicinarExameAtedimento.Name = "btnAdicinarExameAtedimento";
            this.btnAdicinarExameAtedimento.Size = new System.Drawing.Size(136, 23);
            this.btnAdicinarExameAtedimento.TabIndex = 3;
            this.btnAdicinarExameAtedimento.Text = "Adicionar Exame";
            this.btnAdicinarExameAtedimento.UseVisualStyleBackColor = false;
            // 
            // btnRemovarAtedimento
            // 
            this.btnRemovarAtedimento.BackColor = System.Drawing.Color.Red;
            this.btnRemovarAtedimento.Location = new System.Drawing.Point(567, 235);
            this.btnRemovarAtedimento.Name = "btnRemovarAtedimento";
            this.btnRemovarAtedimento.Size = new System.Drawing.Size(87, 23);
            this.btnRemovarAtedimento.TabIndex = 4;
            this.btnRemovarAtedimento.Text = "Remover";
            this.btnRemovarAtedimento.UseVisualStyleBackColor = false;
            // 
            // FormAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.btnRemovarAtedimento);
            this.Controls.Add(this.btnAdicinarExameAtedimento);
            this.Controls.Add(this.groupListaDeExamesAtedimento);
            this.Controls.Add(this.btnFinalizarAtedimento);
            this.Controls.Add(this.groupDadosAtedimento);
            this.Name = "FormAtendimento";
            this.Text = "Atendimento";
            this.groupDadosAtedimento.ResumeLayout(false);
            this.groupDadosAtedimento.PerformLayout();
            this.groupAtendimento.ResumeLayout(false);
            this.groupAtendimento.PerformLayout();
            this.groupListaDeExamesAtedimento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataAtedimento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupDadosAtedimento;
        private System.Windows.Forms.GroupBox groupAtendimento;
        private System.Windows.Forms.Button btnBuscarAtedimento;
        private System.Windows.Forms.TextBox textPlanoAtedimento;
        private System.Windows.Forms.TextBox textNascidoAtedimento;
        private System.Windows.Forms.TextBox textNomeAtedimento;
        private System.Windows.Forms.Label labPlanoAtedimento;
        private System.Windows.Forms.Label labNascidoAtendimento;
        private System.Windows.Forms.Label labNomeAtendimento;
        private System.Windows.Forms.Label labPacienteAtendimento;
        private System.Windows.Forms.DateTimePicker dateTimeAtendimento;
        private System.Windows.Forms.Label labDataAtendimento;
        private System.Windows.Forms.Button btnFinalizarAtedimento;
        private System.Windows.Forms.GroupBox groupListaDeExamesAtedimento;
        private System.Windows.Forms.Button btnAdicinarExameAtedimento;
        private System.Windows.Forms.Button btnRemovarAtedimento;
        private System.Windows.Forms.DataGridView dataAtedimento;
    }
}