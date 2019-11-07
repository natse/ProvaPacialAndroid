using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanoDeSaudeDoFrancisco.Model
{
    public class Exame
    {
        private string descricao;
        private int id;
        private double valor;
        IList<ExamesDoAtendimento> examesDoAtendimentos = new List<ExamesDoAtendimento>();
       

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        public IList<ExamesDoAtendimento> ExamesDoAtendimentos
        {
            get { return examesDoAtendimentos; }
            set { examesDoAtendimentos = value; }
        }
      

    }
}
