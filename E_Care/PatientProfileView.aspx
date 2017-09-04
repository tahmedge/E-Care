<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PatientProfileView.aspx.cs" inherits="E_Care.PatientProfileView" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">



<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">

 <head>

 <style type="text/css">
     .style5
     {
         width:750px;
         height:
     }
 </style>

    </head>
 

 <body style="background-color:ghostwhite">


 <h1 style="color: #FFFFFF; background-color: #3366CC;  width:  100%; text-align:center;border-radius:15px">
            Patients Information</h1>

  <form id="form1" runat="server" >
  
  <div style="margin-left:5px;display:inline-block;height:auto;font-size:x-large;width:50%;text-align:left;vertical-align:top">                                                                                   
                                                                             
   <ul style="text-align:left;margin-top:129px"> 
    <li style="margin-bottom: 15px; width: 520px; margin-left: 118px;">
        Accept appointment online</li>
        <li style="margin-bottom: 15px; margin-left: 118px; width: 503px;">Verify your patient </li>
        <li style="margin-bottom: 15px; margin-left: 117px; width: 503px;">Send message to your patient</li>
        <li style="width: 504px; margin-bottom: 15px; margin-left: 117px;">Get Access to your patients health records</li>
        <li style="margin-bottom: 15px; width: 516px; margin-left: 118px;">Send Prescription to your patient account</ul>
     </div> 
      
        
      <div style="margin-left:55px;display:inline-block;height:auto;font-size:large;width:45%;text-align:left">
          <div>
        <fieldset style="width: 90%;  border-radius: 15px;border:1px solid green;">
  <legend style="color: #009999; font-size: large;">Patient Information</legend>
          <br />
      <asp:Label ID="Label1" runat="server" Text="Full Name" Width="169px"></asp:Label>
         <asp:Label ID="NM" runat="server" Text=" Name" Width="164px" ForeColor="#006699"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Contact Number" Width="169px"></asp:Label>
         <asp:Label ID="CN" runat="server" Text=" Blood Group" Width="164px" ForeColor="#006699"></asp:Label>
        <br />
        <br/>

             <asp:Label ID="Label16" runat="server" Text="Email" Width="169px"></asp:Label>
         <asp:Label ID="EM" runat="server" Text=" Blood Group" Width="164px" ForeColor="#006699"></asp:Label>
        <br />
            <br />
     <asp:Label ID="Label17" runat="server" Text=" Sex" Width="165px"></asp:Label>
       <asp:Label ID="SEX" runat="server" Width="69px" ForeColor="#006699">Male</asp:Label>
        <br/>
            <br />
                  <asp:Label ID="Label19" runat="server" Text=" District" Width="165px"></asp:Label>
         <asp:Label ID="DS" runat="server" Text=" Blood Group" Width="164px" ForeColor="#006699"></asp:Label>
            <br />
            <br />
         <asp:Label ID="Label2" runat="server" Text=" Blood Group" Width="164px"></asp:Label>
         <asp:Label ID="BG" runat="server" Text=" Blood Group" Width="164px" ForeColor="#006699"></asp:Label>
            
        <br />
 </fieldset>
              </div>
          <div style="margin-top:10px;margin-left:10px">
              <div style="display:inline-block">
              <asp:Button ID="Button1" runat="server" Text="Send Message" Width="128px" BackColor="#CC0066" ForeColor="White" Height="44px" OnClick="Button1_Click" />
                  </div>
                <div style="display:inline-block;margin-left:10px">
              <asp:Button ID="Button2" runat="server" Text="Check Health Records" BackColor="#006666" ForeColor="White" Height="44px" OnClick="Button2_Click" />
                     </div>
                <div style="display:inline-block;margin-left:10px">
              <asp:Button ID="Button3" runat="server" Text="Send Prescription" BackColor="#006699" ForeColor="White" Height="44px" OnClick="Button3_Click" />
                     </div>
          </div>
          <br />
          <br />
          <br />
</div>
      
     <hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
</form>
 </body>
</html>

