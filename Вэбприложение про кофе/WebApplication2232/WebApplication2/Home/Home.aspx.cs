using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using WebApplication2.Home;
using System.Collections.ObjectModel;

namespace WebApplication1.Home
{
    public partial class Home : System.Web.UI.Page
    {
        List<info> infoList = new List<info>();
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
        //protected void DeleteInfo(object sender, EventArgs e)
        //{
        //    string deleteName = txtDeleteName.Value; // Получаем введенное имя для удаления

        //    var dbContext = new MainMainCon();

        //    // Находим информацию, у которой Name совпадает с введенным значением
        //    var deleteInfo = dbContext.infos.FirstOrDefault(i => i.Name == deleteName);

        //    if (deleteInfo != null)
        //    {
        //        // Удаляем найденный объект info из базы данных
        //        dbContext.infos.Remove(deleteInfo);
        //        dbContext.SaveChanges();

        //        //// Возвращаем информацию об успешном удалении
        //        //Response.Clear();
        //        //Response.Write("Удаление прошло успешно");
        //        //Response.End();
        //    }
        //}

        //protected void AddInfo(object sender, EventArgs e)
        //{
        //    string fileName = Path.GetFileName(filePicture.PostedFile.FileName);
        //    string filePath = Path.Combine(Server.MapPath("~/Images/"), fileName);
        //    filePicture.PostedFile.SaveAs(filePath);
        //    string Picture = fileName;
        //    info infos = new info
        //    {
        //        Name = txtName.Value,
        //        Picture = fileName,
        //        Description = txtDescription.Value,
        //        Type = txtType.Value,
        //        DescriptionBig = txtDescriptionBig.Value
        //    };
        //    var dbContext = new MainMainCon();
        //    dbContext.infos.Add(infos);

        //    dbContext.SaveChanges();



        protected void DeleteInfo(object sender, EventArgs e) //работает но с обновлением страницы
        {
            string deleteName = txtDeleteName.Value; // Получаем введенное имя для удаления

            var dbContext = new MainMainCon();

            // Находим информацию, у которой Name совпадает с введенным значением
            var deleteInfo = dbContext.infos.FirstOrDefault(i => i.Name == deleteName);

            if (deleteInfo != null)
            {
                // Удаляем найденный объект info из базы данных
                dbContext.infos.Remove(deleteInfo);
                dbContext.SaveChanges();
                Response.Redirect(Request.Url.AbsoluteUri);
            }
        }
        protected void AddInfo(object sender, EventArgs e)
        {
            string fileName = Path.GetFileName(filePicture.PostedFile.FileName);
            string filePath = Path.Combine(Server.MapPath("~/Images/"), fileName);
            filePicture.PostedFile.SaveAs(filePath);
            string Picture = fileName;
            info infos = new info
            {
                Name = txtName.Value,
                Picture = fileName,
                Description = txtDescription.Value,
                Type = txtType.Value,
                DescriptionBig = txtDescriptionBig.Value
            };
            var dbContext = new MainMainCon();
            dbContext.infos.Add(infos);

            dbContext.SaveChanges();
            ClearInputFields();
            Response.Redirect(Request.Url.AbsoluteUri);
        }
      
        private void ClearInputFields()
        {
            txtName.Value = string.Empty;
            txtDescription.Value = string.Empty;
            txtType.Value = string.Empty;
            txtDescriptionBig.Value = string.Empty;
        }
        protected void UpdateInfo(object sender, EventArgs e)
        {

            string elementName = Text5.Value;

            var dbContext = new MainMainCon();
            var element = dbContext.infos.FirstOrDefault(x => x.Name == elementName);

            if (element != null)
            {
                string name = Text1.Value;
                element.Name = name;

                if (file1.PostedFile != null && file1.PostedFile.ContentLength > 0)
                {
                    string fileName = Path.GetFileName(file1.PostedFile.FileName);
                    string filePath = Path.Combine(Server.MapPath("~/Images/"), fileName);
                    file1.PostedFile.SaveAs(filePath);
                    element.Picture = fileName;
                }

                string description = Text2.Value;
                string type = Text3.Value;
                string descriptionBig = Text4.Value;

                element.Description = description;
                element.Type = type;
                element.DescriptionBig = descriptionBig;

                dbContext.SaveChanges();
                Response.Redirect(Request.Url.AbsoluteUri);
            }

        }
    }
}

//// Возвращаем информацию об успешном добавлении
//Response.Clear();
//    Response.Write("Добавление прошло успешно");
//    Response.End();
//}
////// Обновляем список после удаления надо будет сразу обновление всего сделать
//lists = new ObservableCollection<info>(infoList);
//taskList.DataSource = lists;
//taskList.DataBind();