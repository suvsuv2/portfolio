<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details.aspx.cs" Inherits="WebApplication2.Home.Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <style>
    body {
        display: flex;
        justify-content: center;
        align-items: center;
        height: 100vh;
        margin: 0;
       
    }

    .center-container {
        text-align: center;
    }
</style>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="center-container">
             <img id="imgPicture" runat="server" />
            <h2>
                <asp:Label ID="lblName" runat="server"></asp:Label>
            </h2>
           
            <p>
                <asp:Label ID="lblDescriptionBig" runat="server"></asp:Label>
            </p>
        
        </div>
    </form>
</body>
</html>
