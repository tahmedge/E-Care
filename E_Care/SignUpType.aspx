<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpType.aspx.cs" Inherits="E_Care.SignUpType" %>

<!DOCTYPE html>
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


 <h1 style="color: #FFFFFF; background-color: #808080;  width:  100%; text-align:center;border-radius:15px">
            E-Care : Registration</h1>
  <form id="form1" runat="server" >
  
  <div style="margin-left:5px;display:inline-block;height:900px;font-size:x-large;width:53%;text-align:left;vertical-align:top;">                                                                                   
        <div style="text-align:center;font-size:xx-large;color:darkgreen;vertical-align:middle;text-decoration:underline">
            Sign Up Patient
            <br />
            <br />
        </div>                                                                     
   <ul style="text-align:left;margin-top:12px;font-size:large"> 
    <li style="margin-bottom: 15px; width: 481px; margin-left: 80px;">
    Contact with your doctor by sending him message 
   </li>
        <li style="margin-bottom: 15px; margin-left: 80px; width: 465px;">Book appointement online</li>
        <li style="margin-bottom: 15px; margin-left:  80px; width: 509px;">Ask questions on our forum by category 
    </li>
        <li style="width: 501px; margin-bottom: 15px; margin-left:  80px;">Get your health records information anytime 
    you want 
     </li>
        <li style="margin-bottom: 15px; width: 472px; margin-left: 80px;">Read all new health related articles</li>
      
</ul>
       <br />
      <div style="text-align:center">
                            <asp:Button ID="Button1" runat="server" Text="Sign Up Patient" Height="47px" BackColor="#006699" ForeColor="White" Font-Size="Large" Width="176px" OnClick="Button1_Click" />
      </div>
     </div> 
      <div style="margin-left:5px;display:inline-block;height:900px;font-size:x-large;width:44%;text-align:left;vertical-align:top;">                                                                                   
        <div style="text-align:center;font-size:xx-large;color:darkgreen;vertical-align:middle;text-decoration:underline">
            Sign Up Doctor
            <br />
            <br />
        </div>                                                                     
   <ul style="text-align:left;margin-top:12px;font-size:large"> 
    <li style="margin-bottom: 15px; width: 469px; margin-left: 20px;">
    Contact with your doctor by sending him message 
   </li>
        <li style="margin-bottom: 15px; margin-left: 20px; width: 470px;">Book appointement online</li>
        <li style="margin-bottom: 15px; margin-left:  20px; width: 468px;">Ask questions on our forum by category 
    </li>
        <li style="width: 468px; margin-bottom: 15px; margin-left:  20px;">Get your health records information anytime 
    you want 
     </li>
        <li style="margin-bottom: 15px; width: 468px; margin-left: 20px;">Read all new health related articles</li>

</ul>
          <br />
            <div style="text-align:center">
                            <asp:Button ID="Button2" runat="server" Text="Sign Up Doctor" Height="47px" BackColor="#006699" ForeColor="White" Font-Size="Large" Width="176px" OnClick="Button2_Click" />
                            <br />
                </div>
     </div>
      <hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
</form>
 
</html>

