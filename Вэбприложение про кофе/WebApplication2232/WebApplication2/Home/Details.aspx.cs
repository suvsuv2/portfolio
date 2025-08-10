using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace WebApplication2.Home
{
    public partial class Details : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["ID"] != null)
                {
                    int ID = Convert.ToInt32(Request.QueryString["ID"]);

                    info item = FetchDataByID(ID);

                    if (item != null)
                    {
                        string Name = item.Name;
                        //string Description = item.Description;
                        string DescriptionBig = item.DescriptionBig;
                        string Picture = item.Picture;

                        imgPicture.Src = Picture;
                        lblName.Text = Name;
                        //lblDescription.Text = Description;
                        lblDescriptionBig.Text = DescriptionBig;
                       
                    }
                    else
                    {
                        lblName.Text = "No data found for ID: " + ID;
                    }
                }
            }
        }
         //<p>
         //       <asp:Label ID = "lblDescription" runat="server"></asp:Label>
         //   </p>
        private info FetchDataByID(int ID)
        {
            using (var dbContext = new MainMainCon())
            {
              
                var item = dbContext.infos.Where(data => data.ID == ID).FirstOrDefault();

               
                return item;
            }

        }
    }
}