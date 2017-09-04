<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="MessageInbox.aspx.cs" Inherits="E_Care.MessageInbox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      

        <div class="style2" style="margin-left:129px;margin-right:129px;width:796px; height:927px;background-color:whitesmoke" >

            <div style="border-bottom-style:outset;border-radius:5px;border-color:ghostwhite">
                <div style="height:25px;margin:30px; width: 74px;display:inline-block">
                    <asp:Label ID="Label1" runat="server" Text="From:" ></asp:Label>
                </div>
            <div style="height:25px;width: 517px; display:inline-block; margin-left: 30px; margin-right: 30px; margin-top: 30px;">
                   <asp:LinkButton ID="LinkButtonSender" runat="server" ForeColor="#006666" OnClick="LinkButton1_Click">Tahmid Rahman</asp:LinkButton></div>
            
                <asp:Label ID="Label4" runat="server" Text="LabelDate"></asp:Label>
            
           </div>
            <div style="border-bottom-style:outset;border-radius:10px;border-color:ghostwhite">
               <div style="height:25px;margin:30px; width: 74px;display:inline-block">
                    <asp:Label ID="Label2" runat="server" Text="Subject:" ></asp:Label>
                </div>
                   <div style="height:25px;margin:30px; width: 519px; display:inline-block">
                    <asp:Label ID="LabelSubject" runat="server" Text="ISLAMIC UNIVERSITY OF TECHNOLOGY" ></asp:Label>
                </div>
                 </div>
                <div style="height:550px; margin:30px; width: 700px;">
                    <asp:Label ID="Label3" runat="server" Text="Body" ></asp:Label>
                         <asp:TextBox ID="TextBoxBody" runat="server" Height="500px"  TextMode="multiline" Width="688px" OnTextChanged="TextBox3_TextChanged" Enabled="False"></asp:TextBox>  
                </div>
          
            <div style="text-align:center">
          
            <asp:Button ID="Button1" runat="server" Text="View Sender's Profile" Height="50px" Width="150px" BackColor="#003366" ForeColor="White" OnClick="Button1_Click" />
                <br />
              
                </div>
  </div>
<hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
   
</asp:Content>
