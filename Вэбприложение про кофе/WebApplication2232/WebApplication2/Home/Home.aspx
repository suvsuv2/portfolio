<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Home.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Style.css"/>
<meta http-equiv="Content-Type" content="text/html;  charset=utf-8"/>
    <title></title>
</head>
<body>
   <form id="form1" runat="server" enctype="multipart/form-data">
                        <div class="container2" runat="server"> 
  <asp:ListView ID="taskList" runat="server"  DataKeyNames="Id"> 
    <ItemTemplate> 
      <div class="element" data-type='<%# Eval("Type") %>' runat="server"> 
        <div class="ImageElement"> 
          <img class="img2" src='<%# Eval("Picture") %>' /> 
        </div> 
        <div class="TextElement"> 
                      <p class="txt" onclick="window.location.href='Details.aspx?ID=<%# Eval("ID") %>'">
  <%# Eval("Name") %>
</p>
          <p class="description"> 
            <%# Eval("Description") %> 
          </p> 
           
        </div>      
      </div> 
    </ItemTemplate> 
  </asp:ListView> 
</div>
  <div style="border: 1px solid black; padding: 10px; width: 400px; margin: 0 auto; position:fixed; left: 10px;">
    <h3>Добавить кофе</h3>
    <div>
        <label for="txtName">Name:</label>
        <input type="text" id="txtName" runat="server" />
    </div>
    <div>
        <label for="filePicture">Picture:</label>
        <input type="file" id="filePicture" runat="server" />
    </div>
    <div>
        <label for="txtDescription">Description:</label>
        <input type="text" id="txtDescription" runat="server" />
    </div>
    <div>
        <label for="txtType">Type:</label>
        <input type="text" id="txtType" runat="server" />
    </div>
    <div>
        <label for="txtDescriptionBig">DescriptionBig:</label>
        <input type="text" id="txtDescriptionBig" runat="server" />
    </div>
    <div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="AddInfo" />

    </div>

      <div style="border: 1px solid black; padding: 10px; width: 400px; margin: 0 auto; position:fixed; left: 1100px; bottom: 16px;">
   <h3>Редактировать кофе</h3>
            <div>
      <label for="txtName">Имя элемента который нужно отредактировать:</label>
      <input type="text" id="Text5" runat="server" />
  </div>
   <div>
       <label for="txtName">Name:</label>
       <input type="text" id="Text1" runat="server" />
   </div>
   <div>
       <label for="filePicture">Picture:</label>
       <input type="file" id="file1" runat="server" />
   </div>
   <div>
       <label for="txtDescription">Description:</label>
       <input type="text" id="Text2" runat="server" />
   </div>
   <div>
       <label for="txtType">Type:</label>
       <input type="text" id="Text3" runat="server" />
   </div>
   <div>
       <label for="txtDescriptionBig">DescriptionBig:</label>
       <input type="text" id="Text4" runat="server" />
   </div>
   <div>
       <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="UpdateInfo" />
   </div>
</div>

      <div style="border: 1px solid black; padding: 10px; width: 400px; margin: 0 auto; position: fixed; left: 550px; bottom: 98px;">
    <h3>Удалить кофе</h3>
    <div>
        <label for="txtDeleteName">Name:</label>
        <input type="text" id="txtDeleteName" runat="server" />
    </div>
    <div>
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="DeleteInfo" />
    </div>
</div>
</div>
</form>
</body>
</html>
