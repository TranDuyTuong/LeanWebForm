using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm_Learn.ConnectionDatabase;
using WebForm_Learn.Model;

namespace WebForm_Learn.View
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Infomation"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
            }
        }

        [System.Web.Services.WebMethod]
        public static List<ListCity_M> ListCity()
        {
            var Db = new ManagerMusicDatabaseEntities();
            var City = Db.Citys.ToList();
            List<ListCity_M> L_Data = new List<ListCity_M>();
            foreach(var item in City)
            {
                var Form_D = new ListCity_M()
                {
                    IdCity = item.IdCity,
                    NameCity = item.NameCity,
                    Dates = item.DateCreate.Date.ToShortDateString(),
                    Time = item.DateCreate.ToShortTimeString(),
                };
                L_Data.Add(Form_D);
            }
            return L_Data;
        }

        
    }
}