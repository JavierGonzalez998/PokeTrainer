using Evaluacion_3.DAL;
using System;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluacion_3
{
    public partial class AddTrainer : System.Web.UI.Page
    {
        Pokemon p = new Pokemon();
        ArrayList pokemonArray = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                //Cargar codigo solo en la primera carga

                pokemonArray = p.initialPokemon();

                ListItem li;
                foreach (Pokemon pkm in pokemonArray)
                {
                    li = new ListItem(pkm.getNombre(), pkm.getNum().ToString());
                    li.Text = pkm.getNum().ToString() + " - " + pkm.getNombre();
                    this.pokemonTeam1.Items.Add(li);
                }
                foreach (Pokemon pkm in pokemonArray)
                {
                    li = new ListItem(pkm.getNombre(), pkm.getNum().ToString());
                    li.Text = pkm.getNum().ToString() + " - " + pkm.getNombre();
                    this.pokemonTeam2.Items.Add(li);
                }
                foreach (Pokemon pkm in pokemonArray)
                {
                    li = new ListItem(pkm.getNombre(), pkm.getNum().ToString());
                    li.Text = pkm.getNum().ToString() + " - " + pkm.getNombre();
                    this.pokemonTeam3.Items.Add(li);
                }
                foreach (Pokemon pkm in pokemonArray)
                {
                    li = new ListItem(pkm.getNombre(), pkm.getNum().ToString());
                    li.Text = pkm.getNum().ToString() + " - " + pkm.getNombre();
                    this.pokemonTeam4.Items.Add(li);
                }
                foreach (Pokemon pkm in pokemonArray)
                {
                    li = new ListItem(pkm.getNombre(), pkm.getNum().ToString());
                    li.Text = pkm.getNum().ToString() + " - " + pkm.getNombre();
                    this.pokemonTeam5.Items.Add(li);
                }
                foreach (Pokemon pkm in pokemonArray)
                {
                    li = new ListItem(pkm.getNombre(), pkm.getNum().ToString());
                    li.Text = pkm.getNum().ToString() + " - " + pkm.getNombre();
                    this.pokemonTeam6.Items.Add(li);
                }

            }

        }

        protected void addTrainerBtn_Click(object sender, EventArgs e)
        {
            String trainerName = this.trainerName.Text.Trim();
            int trainerSex = Convert.ToInt32(this.RadioButton1.SelectedValue);
            String teamName = this.teamName.Text;
            int pkm_1 = Convert.ToInt32(this.pokemonTeam1.SelectedValue);
            int pkm_2 = Convert.ToInt32(this.pokemonTeam2.SelectedValue);
            int pkm_3 = Convert.ToInt32(this.pokemonTeam3.SelectedValue);
            int pkm_4 = Convert.ToInt32(this.pokemonTeam4.SelectedValue);
            int pkm_5 = Convert.ToInt32(this.pokemonTeam5.SelectedValue);
            int pkm_6 = Convert.ToInt32(this.pokemonTeam6.SelectedValue);
            PkmTrainer t = new PkmTrainer();
            t.Nombre = trainerName;
            t.Sexo = trainerSex;
            t.NombreTeam = teamName;
            t.Pkm_1 = pkm_1;
            t.Pkm_2 = pkm_2;
            t.Pkm_3 = pkm_3;
            t.Pkm_4 = pkm_4;
            t.Pkm_5 = pkm_5;
            t.Pkm_6 = pkm_6;
            new TrainerDAL().Add(t);
            this.alertAdd.Attributes["class"] = "alert alert-success enb";

        }
    }
}