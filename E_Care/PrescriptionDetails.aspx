<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="PrescriptionDetails.aspx.cs" Inherits="E_Care.PrescriptionDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    


        <div class="style2" style="margin-left:129px;margin-right:129px;width:796px; height:927px;background-color:whitesmoke" >

            <div style="border-bottom-style:outset;border-radius:5px;border-color:ghostwhite">
                <div style="height:25px;margin:30px; width: 74px;display:inline-block">
                    <asp:Label ID="Label1" runat="server" Text="From:" ></asp:Label>
                </div>
            <div style="height:25px;width: 517px; display:inline-block; margin-left: 30px; margin-right: 30px; margin-top: 30px;">
                   <asp:LinkButton ID="LinkButtonName" runat="server" ForeColor="#006666" OnClick="LinkButtonName_Click">Dr.Tahmid Rahman</asp:LinkButton></div>
            
           </div>
            <div style="border-bottom-style:outset;border-radius:10px;border-color:ghostwhite">
               <div style="height:25px;margin:30px; width: 74px;display:inline-block">
                    <asp:Label ID="Label2" runat="server" Text="Date:" ></asp:Label>
                </div>
                   <div style="height:25px;margin:30px; width: 519px; display:inline-block">
                    <asp:Label ID="LabelDate" runat="server" Text="07/04/2014" ></asp:Label>
                </div>
                 </div>
                <div style="height:423px; margin:30px; width: auto;">
                  <asp:Label ID="Label3" runat="server" Text="Suggetion" ></asp:Label>
                         <asp:TextBox ID="TextBoxBody" runat="server" Height="301px"  TextMode="multiline" Width="688px" OnTextChanged="TextBox3_TextChanged" Enabled="False"></asp:TextBox>  
                </div>
          
            <div style="text-align:center">
          
                <asp:Button ID="Button3" runat="server" Text="Accept" BackColor="#006666" ForeColor="White" Height="30px" Width="100px" OnClick="Button3_Click" />
                <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                  <asp:Button ID="Button4" runat="server" Text="Delete" BackColor="#990000" ForeColor="White" Height="30px" Width="100px" OnClick="Button4_Click"  />
                <br />
              
                </div>
  </div>
 <hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
   
</asp:Content>
