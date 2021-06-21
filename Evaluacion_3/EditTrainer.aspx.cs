using Evaluacion_3.DAL;
using System;
using System.Collections;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluacion_3
{
    public partial class EditTrainer : System.Web.UI.Page
    {
        Pokemon p = new Pokemon();
        ArrayList pokemonArray = new ArrayList();
        ArrayList arrayList = new ArrayList(new TrainerDAL().GetAll());
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                //Cargar codigo solo en la primera carga
                if (Request.QueryString["index"] != null)
                {
                    string index = Request.QueryString["index"].ToString();
                    int i = Convert.ToInt32(index);

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
                    foreach (PkmTrainer t in arrayList)
                    {
                        if (arrayList.IndexOf(t).Equals(i))
                        {
                            this.trainerName.Text = t.Nombre;
                            this.RadioButton1.Items.FindByValue(t.Sexo.ToString()).Selected = true;
                            this.teamName.Text = t.NombreTeam;
                            this.pokemonTeam1.Items.FindByValue(t.Pkm_1.ToString()).Selected = true;
                            this.pokemonTeam2.Items.FindByValue(t.Pkm_2.ToString()).Selected = true;
                            this.pokemonTeam3.Items.FindByValue(t.Pkm_3.ToString()).Selected = true;
                            this.pokemonTeam4.Items.FindByValue(t.Pkm_4.ToString()).Selected = true;
                            this.pokemonTeam5.Items.FindByValue(t.Pkm_5.ToString()).Selected = true;
                            this.pokemonTeam6.Items.FindByValue(t.Pkm_6.ToString()).Selected = true;
                        }

                    }
                }
                else
                {

                }


            }
        }

        protected void EditTrainerBtn_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["index"] != null)
            {
                int index = Convert.ToInt32(Request.QueryString["index"].ToString());
                String trainerName = this.trainerName.Text.Trim();
                int trainerSex = Convert.ToInt32(this.RadioButton1.SelectedValue);
                String teamName = this.teamName.Text;
                int pkm_1 = Convert.ToInt32(this.pokemonTeam1.SelectedValue);
                int pkm_2 = Convert.ToInt32(this.pokemonTeam2.SelectedValue);
                int pkm_3 = Convert.ToInt32(this.pokemonTeam3.SelectedValue);
                int pkm_4 = Convert.ToInt32(this.pokemonTeam4.SelectedValue);
                int pkm_5 = Convert.ToInt32(this.pokemonTeam5.SelectedValue);
                int pkm_6 = Convert.ToInt32(this.pokemonTeam6.SelectedValue);

                new TrainerDAL().EditList(index, trainerName, trainerSex, teamName, pkm_1, pkm_2, pkm_3, pkm_4, pkm_5, pkm_6);
                Response.Redirect("./Trainer.aspx?edit=true");
            }

        }
    }
}