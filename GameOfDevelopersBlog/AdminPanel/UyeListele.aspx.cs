using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameOfDevelopersBlog.AdminPanel
{
    public partial class UyeListele : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lv_uyeler.DataSource = dm.uyeListele();
            lv_uyeler.DataBind();
        }

        protected void lv_uyeler_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "aski")
            {
                dm.uyeAskiyaAl(id);
            }
            if (e.CommandName == "askiKaldir")
            {
                dm.uyeAskiKaldir(id);
            }
            lv_uyeler.DataSource = dm.uyeListele();
            lv_uyeler.DataBind();
        }
    }
}