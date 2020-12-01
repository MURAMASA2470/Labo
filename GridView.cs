using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(this.DropDown.Items.Count == 0)
            {
                this.DropDown.Items.Add(new ListItem("全て", "0"));
                this.DropDown.Items.Add(new ListItem("果物", "1"));
                this.DropDown.Items.Add(new ListItem("野菜", "2"));
                this.DropDown.Items.Add(new ListItem("精肉", "3"));
            }

            var dt = new DataTable();
            dt.Columns.Add("DATE");
            dt.Columns.Add("BMCD");
            dt.Columns.Add("ORNM");

            dt.Rows.Add(new string[] { "202001", "1", "店１" });
            dt.Rows.Add(new string[] { "202002", "2", "店２" });
            dt.Rows.Add(new string[] { "202003", "3", "店３" });

            this.GridList.DataSource = dt;
            this.GridList.DataBind();
        }

        protected void DropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedId = int.Parse(this.DropDown.SelectedValue);

            } catch(Exception ex)
            {
                Response.Write(ex);
            }
        }

        private class Dto
        {
            public string DATE { get; set; }

            public string BMCD { get; set; }

            public string ORNM { get; set; }
        }
    }
}
