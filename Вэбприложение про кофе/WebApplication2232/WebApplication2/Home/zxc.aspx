<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zxc.aspx.cs" Inherits="WebApplication2.Home.zxc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Style.css"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
      #banner {
    position: fixed;
    top: 500px;
    right: 0;
    width: 385px;
    height: 300px;
    background-color: black;
  }

  #closeButton {
    position: absolute;
    top: 10px;
    right: 10px;
    width: 20px;
    height: 20px;
    color: white;
    font-size: 18px;
    cursor: pointer;
  }
  </style>
</head>
    
<body>
     <form id="form1" runat="server">
        <div class="Main"/>

           <div id="banner" onclick="window.open('https://ru.videoclub.net/?yclid=7072571992158502911', '_blank')">
  <video id="adVideo" width="100%" height="100%" controls autoplay>
    <source src="реклама.mp4" type="video/mp4">
  </video>
  <div id="closeButton">✖</div>
</div>

<script>
    document.getElementById('closeButton').addEventListener('click', function () {
        document.getElementById('banner').style.display = 'none';
    });
</script>



  <div class="container">
                <div class="header__title">
                <h1>Кофе</h1>
            </div>
                <div class="header__buttons" >
             
            </div>

            </div>
                 <div class="container2" runat="server" > 
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
 


          <div class="container3">
                <p class="title">Фильтры</p>
                <input type="text" class="border" id="searchInput" placeholder="Поиск" />
             <script>
                 document.getElementById("searchInput").addEventListener("input", function () {
                     var input, filter, ul, li, a, i, txtValue;
                     input = document.getElementById('searchInput');
                     filter = input.value.toUpperCase();
                     li = document.getElementsByClassName('element');
                     for (i = 0; i < li.length; i++) {
                         a = li[i].getElementsByClassName("txt")[0];
                         txtValue = a.textContent || a.innerText;
                         if (txtValue.toUpperCase().indexOf(filter) > -1) {
                             li[i].style.display = "";
                         } else {
                             li[i].style.display = "none";
                         }
                     }
                 });
             </script>
 <fieldset class="take">
  <legend>выберите тип кофе</legend>
  <div>
    <input type="radio" id="huey" name="drone" value="huey" data-type="Americano" />
    <label for="huey">Американо</label>
  </div>

  <div>
    <input type="radio" id="dewey" name="drone" value="dewey" data-type="Kapychino" />
    <label for="dewey">Капучино</label>
  </div>

  <div>
    <input type="radio" id="louie" name="drone" value="louie" data-type="Espresso" />
    <label for="louie">Эспрессо</label>
  </div>
  
  <div>
    <input type="radio" id="zzz" name="drone" value="zzz" data-type="All" />
    <label for="zzz">Все</label>
  </div>
</fieldset>


             
<script>
    
    var inputs = document.querySelectorAll('input[name="drone"]');


    inputs.forEach(function (input) {
        input.addEventListener('click', function () {
            var selectedType = this.getAttribute('data-type');

          
            var coffeeItems = document.querySelectorAll('.container2 .element');
            coffeeItems.forEach(function (item) {
               
                if (selectedType === 'All' || item.getAttribute('data-type') === selectedType) {
                    item.style.display = 'block';
                } else {
                    item.style.display = 'none';
                }
            });
        });
    });
</script>
              
            </div>
    <div class="container4">
               <asp:Button runat="server" CssClass="button1" ID="Admin" Text="Перейти на панель админа" OnClick="Admin_Click" />

<asp:TextBox runat="server" ID="PasswordTextBox" CssClass="TexttbOx" Visible="false"></asp:TextBox>
<asp:Button runat="server"  CssClass="TexttbOx2" ID="SubmitButton" Text="Подтвердить" OnClick="SubmitButton_Click" Visible="false" />

<script>
    document.getElementById("<%= Admin.ClientID %>").onclick = function () {
        document.getElementById("<%= PasswordTextBox.ClientID %>").style.display = 'block';
        document.getElementById("<%= SubmitButton.ClientID %>").style.display = 'block';
    };
</script>>
               <asp:Button runat="server" CssClass="button2" ID="MoreInfo" Text="Посмотреть информацию о сайте" OnClick="MoreInfo_Click" />

            </div>
        </form>
</body>
</html>
