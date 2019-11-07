using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanoDeSaudeDoFrancisco.Model
{
    public class Atendimento
    {
        private DateTime dataAtendimento;
        private int id;
        private string status;
        private double valorPagar;
        private Paciente objPacinte;
        private IList<ExamesDoAtendimento> examesDoAtendimentos = new List<ExamesDoAtendimento>();
        
        

        public DateTime DataAtendimento
        {
            get { return dataAtendimento; }
            set { dataAtendimento = value; }
        }
        public int Id
        {
            get { return id; }
            set { value = id; }
        }
        public string Status
        {
            get { return status; }
            set { value = status; }
        }
        public double ValorPagar
        {
            get { return valorPagar; }
            set { valorPagar = value; }
        }
        public Paciente ObjPaciente
        {
            get { return objPacinte; }
            set { objPacinte = value; }
        }

        public IList<ExamesDoAtendimento> ExamesDoAtendimentos
        {
            get { return examesDoAtendimentos; }
            set { examesDoAtendimentos = value; }
        }
        
    }
}
