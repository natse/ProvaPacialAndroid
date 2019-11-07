using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanoDeSaudeDoFrancisco.Model
{
    public class ExamesDoAtendimento
    {
        private DateTime dataExame;
        private int id;
        private string status;
        private Atendimento objAtendimento;
        private Exame objExame;


        public DateTime DataExame
        {
            get { return dataExame; }
            set { dataExame = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public Atendimento ObjAtendimento
        {
            get { return objAtendimento; }
            set { objAtendimento = value; }
        }
        public Exame ObjExame
        {
            get { return objExame; }
            set { objExame = value; }
        }
    }
}
