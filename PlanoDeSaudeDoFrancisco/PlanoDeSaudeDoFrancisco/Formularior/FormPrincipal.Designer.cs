namespace PlanoDeSaudeDoFrancisco.Formularior
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planoDeSaudeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atedimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem,
            this.planoDeSaudeToolStripMenuItem,
            this.atedimentoToolStripMenuItem,
            this.exameToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // planoDeSaudeToolStripMenuItem
            // 
            this.planoDeSaudeToolStripMenuItem.Name = "planoDeSaudeToolStripMenuItem";
            this.planoDeSaudeToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.planoDeSaudeToolStripMenuItem.Text = "Plano de Saude";
            this.planoDeSaudeToolStripMenuItem.Click += new System.EventHandler(this.planoDeSaudeToolStripMenuItem_Click);
            // 
            // atedimentoToolStripMenuItem
            // 
            this.atedimentoToolStripMenuItem.Name = "atedimentoToolStripMenuItem";
            this.atedimentoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.atedimentoToolStripMenuItem.Text = "Atedimento";
            this.atedimentoToolStripMenuItem.Click += new System.EventHandler(this.atedimentoToolStripMenuItem_Click);
            // 
            // exameToolStripMenuItem
            // 
            this.exameToolStripMenuItem.Name = "exameToolStripMenuItem";
            this.exameToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exameToolStripMenuItem.Text = "Exame";
            this.exameToolStripMenuItem.Click += new System.EventHandler(this.exameToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planoDeSaudeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atedimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}