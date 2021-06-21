using System;
using System.Collections.Generic;

namespace Evaluacion_3.DAL
{
    public class TrainerDAL
    {
        private static List<PkmTrainer> trainer = new List<PkmTrainer>();

        public void Add(PkmTrainer t)
        {
            trainer.Add(t);
        }

        public List<PkmTrainer> GetAll()
        {

            return trainer;
        }

        public void EditList(int index, String nombre, int sexo, String nombreTeam, int pkm_1, int pkm_2, int pkm_3, int pkm_4, int pkm_5, int pkm_6)
        {
            PkmTrainer pt = new PkmTrainer();
            trainer.RemoveAt(index);
            trainer.Insert(index, pt.addPkmTrainer(nombre, sexo, nombreTeam, pkm_1, pkm_2, pkm_3, pkm_4, pkm_5, pkm_6));
        }
        public void RemoveList(int index)
        {
            trainer.RemoveAt(index);
        }
    }
}