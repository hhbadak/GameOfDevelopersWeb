﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GameOfDevelopersWeb.AdminPanel
{
    public partial class AdminGiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lbtn_giris_Click(object sender, EventArgs e)
        {
            if (tb_mail.Text == "hhbadak@admin.com" && tb_sifre.Text == "15963")
            {
                Response.Redirect("Default.aspx");
            }
        }
    }
}