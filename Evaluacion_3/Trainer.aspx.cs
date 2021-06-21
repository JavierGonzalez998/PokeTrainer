using Evaluacion_3.DAL;
using System;
using System.Collections;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Evaluacion_3
{
    public partial class Trainer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["edit"] != null)
            {
                this.alert.Attributes["class"] = "alert alert-info mt-5";
                this.alert.Attributes["role"] = "alert";
                var text = new HtmlGenericControl("p");
                text.Attributes["class"] = "fw-bold";
                text.InnerText = "Trainer edited successfully!";
                this.alert.Controls.Add(text);

            }
            else if (Request.QueryString["delete"] != null)
            {
                this.alert.Attributes["class"] = "alert alert-warning mt-5";
                this.alert.Attributes["role"] = "alert";
                var text = new HtmlGenericControl("p");
                text.Attributes["class"] = "fw-bold";
                text.InnerText = "Trainer removed successfully!";
                this.alert.Controls.Add(text);

            }

            ArrayList arrayList = new ArrayList(new TrainerDAL().GetAll());
            if (arrayList.Count <= 0)
            {
                var div = new HtmlGenericControl("div");
                Header.Attributes["class"] = "card";
                this.test2.Controls.Add(div);

                var body = new HtmlGenericControl("div");
                body.Attributes["class"] = "card-body";
                div.Controls.Add(body);

                var text = new HtmlGenericControl("h3");
                text.InnerText = "You don't have any Trainer!";
                body.Controls.Add(text);

                var link = new HtmlGenericControl("a");
                link.Attributes["class"] = "btn btn-info mt-5";
                link.Attributes["href"] = "AddTrainer.aspx";
                link.InnerText = "Add Trainer";
                body.Controls.Add(link);


            }
            else
            {
                foreach (PkmTrainer pt in arrayList)
                {
                    //div header card
                    var header = new HtmlGenericControl("div");
                    header.Attributes["class"] = "card-header mt-5 bg-white";
                    this.test2.Controls.Add(header);
                    //p title card
                    var title = new HtmlGenericControl("p");
                    title.InnerText = pt.Nombre + "'s Team: " + pt.NombreTeam;
                    header.Controls.Add(title);
                    //div card body
                    var body = new HtmlGenericControl("div");
                    body.Attributes["class"] = "card-body";
                    this.test2.Controls.Add(body);
                    //Trainer's Sprite
                    var sprite = new HtmlGenericControl("img");
                    sprite.Attributes["src"] = "./Assets/trainer" + pt.Sexo + ".png";
                    sprite.Attributes["class"] = "trainer";
                    body.Controls.Add(sprite);
                    //Pokemon's Sprites
                    //1
                    var pkm1 = new HtmlGenericControl("img");
                    pkm1.Attributes["src"] = "./Assets/poke/" + pt.Pkm_1 + ".png";
                    pkm1.Attributes["class"] = "pkm";
                    body.Controls.Add(pkm1);
                    //2
                    var pkm2 = new HtmlGenericControl("img");
                    pkm2.Attributes["src"] = "./Assets/poke/" + pt.Pkm_2 + ".png";
                    pkm2.Attributes["class"] = "pkm";
                    body.Controls.Add(pkm2);
                    //3
                    var pkm3 = new HtmlGenericControl("img");
                    pkm3.Attributes["src"] = "./Assets/poke/" + pt.Pkm_3 + ".png";
                    pkm3.Attributes["class"] = "pkm";
                    body.Controls.Add(pkm3);
                    //4
                    var pkm4 = new HtmlGenericControl("img");
                    pkm4.Attributes["src"] = "./Assets/poke/" + pt.Pkm_4 + ".png";
                    pkm4.Attributes["class"] = "pkm";
                    body.Controls.Add(pkm4);
                    //5
                    var pkm5 = new HtmlGenericControl("img");
                    pkm5.Attributes["src"] = "./Assets/poke/" + pt.Pkm_5 + ".png";
                    pkm5.Attributes["class"] = "pkm";
                    body.Controls.Add(pkm5);
                    //6
                    var pkm6 = new HtmlGenericControl("img");
                    pkm6.Attributes["src"] = "./Assets/poke/" + pt.Pkm_6 + ".png";
                    pkm6.Attributes["class"] = "pkm";
                    body.Controls.Add(pkm6);

                    //Edit Trainer's Button
                    Button btnEdit = new Button();
                    btnEdit.Text = "Edit Trainer";
                    btnEdit.CssClass = "btn btn-info text-white";
                    btnEdit.Attributes["index"] = arrayList.IndexOf(pt).ToString();
                    btnEdit.Click += new EventHandler(this.EditTrainer);
                    body.Controls.Add(btnEdit);

                    //Delete Trainer's Button
                    System.Web.UI.HtmlControls.HtmlButton TrainerDelete = new System.Web.UI.HtmlControls.HtmlButton();
                    TrainerDelete.InnerText = "Delete Trainer";
                    TrainerDelete.Attributes["class"] = "btn btn-danger ms-3";
                    TrainerDelete.Attributes["type"] = "button";
                    TrainerDelete.Attributes["data-bs-toggle"] = "modal";
                    TrainerDelete.Attributes["data-bs-target"] = "#deleteTrainer" + arrayList.IndexOf(pt).ToString();
                    body.Controls.Add(TrainerDelete);

                    //Confirmation Modal
                    var modal = new HtmlGenericControl("div");
                    modal.Attributes["class"] = "modal fade";
                    modal.Attributes["id"] = "deleteTrainer" + arrayList.IndexOf(pt).ToString();
                    modal.Attributes["tabindex"] = "-1";
                    modal.Attributes["aria-labelledby"] = "Trainer" + arrayList.IndexOf(pt).ToString();
                    modal.Attributes["aria-hidden"] = "true";
                    this.test2.Controls.Add(modal);
                    //Modal Dialog
                    var modalDialog = new HtmlGenericControl("div");
                    modalDialog.Attributes["class"] = "modal-dialog";
                    modal.Controls.Add(modalDialog);
                    //Modal Content
                    var modalContent = new HtmlGenericControl("div");
                    modalContent.Attributes["class"] = "modal-content";
                    modalDialog.Controls.Add(modalContent);
                    //Modal Header
                    var modalHeader = new HtmlGenericControl("div");
                    modalHeader.Attributes["class"] = "modal-header";
                    modalContent.Controls.Add(modalHeader);
                    //DeleteTitle
                    var deleteTitle = new HtmlGenericControl("h5");
                    deleteTitle.Attributes["class"] = "modal-title";
                    deleteTitle.Attributes["id"] = "modalLabel" + arrayList.IndexOf(pt).ToString();
                    deleteTitle.InnerText = "Delete Trainer";
                    modalHeader.Controls.Add(deleteTitle);
                    //Close Button
                    System.Web.UI.HtmlControls.HtmlButton closeBtn = new System.Web.UI.HtmlControls.HtmlButton();
                    closeBtn.Attributes["class"] = "btn-close";
                    closeBtn.Attributes["data-bs-dismiss"] = "modal";
                    closeBtn.Attributes["aria-laber"] = "close";
                    modalHeader.Controls.Add(closeBtn);
                    //Modal Body
                    var modalBody = new HtmlGenericControl("div");
                    modalBody.Attributes["class"] = "modal-body";
                    modalContent.Controls.Add(modalBody);
                    //Content
                    var content = new HtmlGenericControl("p");
                    content.InnerText = "Are you sure? you will delete trainer " + pt.Nombre;
                    modalBody.Controls.Add(content);
                    //Modal Footer
                    var modalFooter = new HtmlGenericControl("div");
                    modalFooter.Attributes["class"] = "modal-footer";
                    modalContent.Controls.Add(modalFooter);
                    //Close Footer
                    System.Web.UI.HtmlControls.HtmlButton dismissBtn = new System.Web.UI.HtmlControls.HtmlButton();
                    dismissBtn.Attributes["class"] = "btn btn-secondary";
                    dismissBtn.Attributes["data-bs-dismiss"] = "modal";
                    dismissBtn.InnerText = "Close";
                    modalFooter.Controls.Add(dismissBtn);
                    //Delete Trainer
                    Button btnDelete = new Button();
                    btnDelete.Text = "Delete Trainer";
                    btnDelete.CssClass = "btn btn-danger";
                    btnDelete.ID = (arrayList.IndexOf(pt)).ToString();
                    btnDelete.Click += new EventHandler(this.DeleteTrainer);
                    modalFooter.Controls.Add(btnDelete);
                }
            }

        }

        protected void EditTrainer(object sender, EventArgs e)
        {
            Button btn_clic = sender as Button;
            var index = btn_clic.Attributes["index"];
            Response.Redirect("./EditTrainer.aspx?index=" + index);
        }

        protected void DeleteTrainer(object sender, EventArgs e)
        {
            TrainerDAL t = new TrainerDAL();
            Button btn_clic = sender as Button;
            var index = Convert.ToInt32(btn_clic.ID);
            t.RemoveList(index);
            Response.Redirect("./Trainer.aspx?delete=true");


        }
    }
}