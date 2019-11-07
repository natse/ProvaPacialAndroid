﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanoDeSaudeDoFrancisco.DAO;

namespace PlanoDeSaudeDoFrancisco.Model
{
    public class PlanoSaude
    {
      private int id;
      private string nome;
        public int Id
        {
            get {return id;}
            set{id = value;}
        }
        public string Nome
        {
            get{return nome;}
            set{nome = value;}
        }
        public void Save()
        {
            PlanoSaudeDao dao = new PlanoSaudeDao();
            dao.Insert(this);
        }
            
    }
}
