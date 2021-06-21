using System;

namespace Evaluacion_3
{
    public partial class Principal : System.Web.UI.MasterPage
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.body == null)
            {

            }
            else
            {
                DateTime now = DateTime.Now;
                int hour = now.Hour;
                this.text.InnerText = "today is: " + MyHour(hour);
                switch (MyHour(hour)) {
                    case "day":
                        this.body.Style["background-image"] = "../Assets/bkg.png";
                        break;
                    case "evening":
                        this.body.Style["background-image"] = "../Assets/bkgEvening.png";
                        break;
                    case "night":
                        this.body.Style["background-image"] = "../Assets/bkgNight.png";
                        break;

                }

            }


        }

        public string MyHour(int actual)
        {
            if (actual >= 5 && actual < 18)
            {
                return "day";
            }
            else if (actual >= 18 && actual < 20)
            {
                return "evening";
            }
            else
            {
                return "night";
            }

        }
    }
}