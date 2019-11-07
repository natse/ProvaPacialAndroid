using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanoDeSaudeDoFrancisco.Formularior
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPaciente paciente = new FormPaciente();
            paciente.MdiParent = this;
            paciente.Show();
        }

        private void planoDeSaudeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPlanoDeSaude planoDeSaude = new FormPlanoDeSaude();
            planoDeSaude.MdiParent = this;
            planoDeSaude.Show();
        }

        private void atedimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAtendimento atendimento = new FormAtendimento();
            atendimento.MdiParent = this;
            atendimento.Show();
        }

        private void exameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExame exame = new FormExame();
            exame.MdiParent = this;
            exame.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
