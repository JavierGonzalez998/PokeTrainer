using System;

namespace Evaluacion_3
{
    public class PkmTrainer
    {
        private String nombre;
        private int sexo;
        private String nombreTeam;
        private int pkm_1;
        private int pkm_2;
        private int pkm_3;
        private int pkm_4;
        private int pkm_5;
        private int pkm_6;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Sexo { get => sexo; set => sexo = value; }
        public string NombreTeam { get => nombreTeam; set => nombreTeam = value; }
        public int Pkm_1 { get => pkm_1; set => pkm_1 = value; }
        public int Pkm_2 { get => pkm_2; set => pkm_2 = value; }
        public int Pkm_3 { get => pkm_3; set => pkm_3 = value; }
        public int Pkm_4 { get => pkm_4; set => pkm_4 = value; }
        public int Pkm_5 { get => pkm_5; set => pkm_5 = value; }
        public int Pkm_6 { get => pkm_6; set => pkm_6 = value; }

        public PkmTrainer()
        {

        }

        public PkmTrainer addPkmTrainer(String nombre, int sexo, String nombreTeam, int pkm_1, int pkm_2, int pkm_3, int pkm_4, int pkm_5, int pkm_6)
        {
            PkmTrainer pkmT = new PkmTrainer();

            pkmT.Nombre = nombre;
            pkmT.Sexo = sexo;
            pkmT.NombreTeam = nombreTeam;
            pkmT.Pkm_1 = pkm_1;
            pkmT.Pkm_2 = pkm_2;
            pkmT.Pkm_3 = pkm_3;
            pkmT.Pkm_4 = pkm_4;
            pkmT.Pkm_5 = pkm_5;
            pkmT.Pkm_6 = pkm_6;
            return pkmT;
        }

    }
}