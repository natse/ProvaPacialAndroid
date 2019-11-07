using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanoDeSaudeDoFrancisco.Model
{
    public class Paciente
    {
        private int id;
        private DateTime dataNacimento;
        private string nome;
        private int tipoCoveniado;
        private PlanoSaude objPlanoSaude;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime DataNacimento
        {
            get { return dataNacimento; }
            set { dataNacimento = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int TipoConveniado
        {
            get { return tipoCoveniado; }
            set { tipoCoveniado = value; }
        }
        public PlanoSaude ObjPlanoSaude
        {
            get { return objPlanoSaude; }
            set { objPlanoSaude = value; }
        }

    }
}
