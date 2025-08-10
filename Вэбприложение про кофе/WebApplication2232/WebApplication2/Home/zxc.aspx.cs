using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.Home
{
    public partial class zxc : System.Web.UI.Page
    {

        public static MainMainCon context = new MainMainCon();
        public ObservableCollection<info> lists { get; set; }
        public List<info> fullList { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            fullList = context.infos.ToList();

            lists = new ObservableCollection<info>(fullList);
            taskList.DataSource = lists;
            taskList.DataBind();

        }
        protected void MoreInfo_Click(object sender, EventArgs e)
        {
           
            Response.Redirect("Credits.aspx");
        }

        protected void Admin_Click(object sender, EventArgs e)
        {

            PasswordTextBox.Visible = true;
            SubmitButton.Visible = true;
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string password = "123"; 
            string enteredPassword = PasswordTextBox.Text;

            if (enteredPassword == password)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Console.WriteLine("Не правильный пароль!");
            }
        }
    }
}