using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace Login1
{
    public partial class Carpetas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GmailLib gmailLib = new GmailLib();
            IList<Google.Apis.Gmail.v1.Data.Label> etiquetas = (IList <Google.Apis.Gmail.v1.Data.Label>)gmailLib.getCarpetas();
            foreach (Google.Apis.Gmail.v1.Data.Label label in etiquetas)
            {
                Etiquetas.Text += "<div>" +label.Name+ "</div>";
            }
        }
    }
}