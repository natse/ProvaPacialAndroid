using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlanoDeSaudeDoFrancisco.Model;

namespace PlanoDeSaudeDoFrancisco.Formularior
{
    public partial class FormPlanoDeSaude : Form
    {
        public FormPlanoDeSaude()
        {
            InitializeComponent();
        }

        private void btnSalvarPlanoPaciente_Click(object sender, EventArgs e)
        {
            //colocar os Dados no Objeto
            PlanoSaude salvar = new PlanoSaude();
            //Preencher o objeto com os dados do FOrmularios 
            salvar.Nome = textNomePlanoPaciente.Text;
            MessageBox.Show("Sucesso");

          
        }

        private void btnAlterarPlanoPaciente_Click(object sender, EventArgs e)
        {
            PlanoSaude altera = new PlanoSaude();

            altera.Nome = textNomePlanoPaciente.Text;
            MessageBox.Show("Sucesso");

        }

        
    }
}
