<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="Contact.aspx.cs"  %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en">
<head id="Head1" runat="server">
    <title>Contact Us E-Care</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .style4
        {
            height: 10px;
            margin-top: -40px;     
             margin-left: -40px;      
         }
        .style5
        {
            width: 955px;
            height: 81px;
            margin-top: -40px;margin-left: -40px;
        }
        .style6
        {
            width: 100%;
            height: 500px;
          background-color:white;
        }
        .style7
        {
            height: 86px;background-color:#808080;text-align:center;border-radius:15px;
        }
        .style10
        {
            width: 955px;
            height: 42px;
            margin-top: -40px;margin-left: -40px;
        }
    </style>
   
</head>
<body style="background-color:floralwhite;margin-bottom:-10px;height:600px">
    <form id="Form1" runat="server">

               <h1 class="style7">Welcome to E-Care</h1>
        <div style="background-color:white; margin-left:250px;margin-right:250px;">
        <div >
            <div style="text-align:left;margin-left:250px;margin-right:250px;background-color:white">
                 <asp:Label ID="Label13" runat="server" Text="Corporate Office" Font-Size="x-large"></asp:Label>
                <hr style="width: 384px" />
            </div>
            <div style="margin-left:250px;margin-right:250px;background-color:white">
               <ul style="margin-left:45%;width:245px">
                  <li> <asp:Label ID="Label10" runat="server" Text="Tahmid Rahman"></asp:Label>  </li>  
                    <li>  <asp:Label ID="Label11" runat="server" Text="Contact Number-01737847721 "></asp:Label>  </li>  
                   <li>   <asp:Label ID="Label12" runat="server" Text="Hall-North"></asp:Label>  </li>  
                  <li>     <asp:Label ID="Label9" runat="server" Text="Room No-323"></asp:Label>  </li>   
                  <li>    <asp:Label ID="Label7" runat="server" Text="IUT"></asp:Label>  </li>  
                   <li>   <asp:Label ID="Label8" runat="server" Text="Board Bazar,Gajipur"></asp:Label>  </li>  
               </ul> 
                <hr style="width: 384px" />
            </div>
             <div style="margin-left:250px;margin-right:250px;background-color:white">
                    
             <ul style="margin-left:45%;width:245px">
                  <li> <asp:Label ID="Label1" runat="server" Text="Araf Farayez"></asp:Label>  </li>  
                    <li>  <asp:Label ID="Label2" runat="server" Text="Contact Number-01737847721 "></asp:Label>  </li>  
                   <li>   <asp:Label ID="Label3" runat="server" Text="Hall-North"></asp:Label>  </li>  
                  <li>    <asp:Label ID="Label4" runat="server" Text="Room No-214"></asp:Label>  </li>  
                  <li>    <asp:Label ID="Label5" runat="server" Text="IUT"></asp:Label>  </li>  
                   <li>   <asp:Label ID="Label6" runat="server" Text="Board Bazar,Gajipur"></asp:Label>  </li>  
               </ul> 
                <hr style="width: 384px"/>
            </div>
        </div>
    </div>
 <hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
    </form>
</body>
</html>
