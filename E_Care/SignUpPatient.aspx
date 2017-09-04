<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUpPatient.aspx.cs"  Inherits="E_Care.SignUpPatient" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<script runat="server">

 
</script>


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
            Patients Registration</h1>
  <form id="form1" runat="server" >
  
  <div style="margin-left:5px;display:inline-block;height:951px; font-size:x-large;width:60%;text-align:left;vertical-align:top">                                                                                   
                                                                             
   <ul style="text-align:left;margin-top:129px"> 
    <li style="margin-bottom: 15px; width: 612px; margin-left: 118px;">
    Contact with your doctor by sending him message 
   </li>
        <li style="margin-bottom: 15px; margin-left: 118px; width: 608px;">Book appointement online</li>
        <li style="margin-bottom: 15px; margin-left: 117px; width: 615px;">Ask questions on our forum by category 
    </li>
        <li style="width: 619px; margin-bottom: 15px; margin-left: 117px;">Get your health records information anytime 
    you want 
     </li>
        <li style="margin-bottom: 15px; width: 608px; margin-left: 118px;">Read all new health related articles

</ul>
     </div> 
      
        
      <div style="margin-left:5px;margin-bottom:5px;display:inline-block;height:auto; font-size:large;width:35%;text-align:left">
        <fieldset style="width: 90%;  border-radius: 15px;border:1px solid green;">
  <legend style="color: #009999; font-size: large;">Account Informationion</legend>
          <br />
      <asp:Label ID="Label1" runat="server" Text="Username" Width="200px"></asp:Label>
        <asp:TextBox ID="textbox_username" runat="server"  Width="191px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <br />
            <asp:Label ID="Label6" runat="server" Text="Contact Number" Width="200px"></asp:Label>
        <asp:TextBox ID="textbox_contactnumber" runat="server"  Width="191px" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <br />
            <br />
        <asp:Label ID="Label9" runat="server" Text="Email" Width="200px"></asp:Label><asp:TextBox ID="textbox_email" 
            runat="server" Width="191px"></asp:TextBox>
        <br />
        <br/>
      <asp:Label ID="Label10" runat="server" Text="Password" Width="200px"></asp:Label>
        <asp:TextBox ID="textbox_password" runat="server" Width="191px" TextMode="Password"></asp:TextBox>
        <br />
        <br/>
        <asp:Label ID="Label11" runat="server" Text="Confirm Password" Width="200px"></asp:Label>
        <asp:TextBox ID="textbox_confirmpassword" runat="server" Width="191px" TextMode="Password"></asp:TextBox>
        <br />
            
        <br />
 </fieldset>

    <fieldset style="width:   90%; font-size: medium; border-radius: 15px;">
     
        
  <legend style="color: #996633; font-size: large;">Personal Information</legend>

             <asp:Label ID="Label12" runat="server" Text=" Full Name" Width="165px"></asp:Label>
        <asp:TextBox ID="textbox_fullname" runat="server" Width="221px"></asp:TextBox>
        <br />
       <br />
         <asp:Label ID="Label4" runat="server" Text=" Born in" Width="165px"></asp:Label>
        <asp:TextBox ID="textbox_born_in" runat="server" Width="185px"></asp:TextBox>
        <br />
        <br />
     
     <asp:Label ID="Label13" runat="server" Text=" Sex" Width="165px"></asp:Label>
        <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="sex" Checked="True"/>
       <asp:Label ID="Label3" runat="server" Width="69px"></asp:Label>
         <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="sex" />

&nbsp;<br />
        <br />
         <asp:Label ID="Label15" runat="server" Text=" District" Width="165px"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server" Height="25px" Width="226px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem>Dhaka</asp:ListItem>
         <asp:ListItem>Rajshahi</asp:ListItem>
         <asp:ListItem>Barishal</asp:ListItem>
         <asp:ListItem>Chittagong</asp:ListItem>
         <asp:ListItem>Sylhet</asp:ListItem>
               <asp:ListItem>Rangpur</asp:ListItem>
        <asp:ListItem> Tangail</asp:ListItem>
	 <asp:ListItem>Sherpur </asp:ListItem>
	 <asp:ListItem> Shariatpur</asp:ListItem>
	 <asp:ListItem>Rajbari </asp:ListItem>
	 <asp:ListItem>	Netrokona </asp:ListItem>
	 <asp:ListItem> Narsingdi</asp:ListItem>
	 <asp:ListItem> Narayanganj</asp:ListItem>
	 <asp:ListItem>Mymensingh </asp:ListItem>
	 <asp:ListItem>Munshiganj </asp:ListItem>
	 <asp:ListItem> Manikganj</asp:ListItem>
	 <asp:ListItem>Madaripur </asp:ListItem>
	 <asp:ListItem> Kishoreganj</asp:ListItem>
	 <asp:ListItem> Jamalpur</asp:ListItem>
	 <asp:ListItem> Gopalganj</asp:ListItem>
	 <asp:ListItem> Gazipur</asp:ListItem>
	 <asp:ListItem> Faridpur</asp:ListItem>
	<asp:ListItem>  Barisal</asp:ListItem>
	 <asp:ListItem>  Barguna</asp:ListItem>
	 <asp:ListItem>  Bhola</asp:ListItem>
	 <asp:ListItem>  Jhalokati</asp:ListItem>
	 <asp:ListItem>  Patuakhali</asp:ListItem>
	 <asp:ListItem>  Pirojpur</asp:ListItem>
	 <asp:ListItem> Bagerhat </asp:ListItem>
	 <asp:ListItem> Chuadanga </asp:ListItem>
	 <asp:ListItem> Jessore </asp:ListItem>
	 <asp:ListItem> Jhenaidah </asp:ListItem>
	 <asp:ListItem> Khulna </asp:ListItem>
	 <asp:ListItem> Kushtia </asp:ListItem>
	 <asp:ListItem> Magura </asp:ListItem>
	 <asp:ListItem> Meherpur </asp:ListItem>
	 <asp:ListItem> Narail </asp:ListItem>
	 <asp:ListItem> Satkira </asp:ListItem>
	<asp:ListItem> Dinajpur </asp:ListItem>
	 <asp:ListItem> Gaibandha </asp:ListItem>
	 <asp:ListItem> Kurigram </asp:ListItem>
	 <asp:ListItem> Lalmonirhat </asp:ListItem>
	 <asp:ListItem> Nilphamari</asp:ListItem>
	 <asp:ListItem> Panchagarh </asp:ListItem>
	 <asp:ListItem> Rangpur </asp:ListItem>
	 <asp:ListItem> Thakurgaon </asp:ListItem>
	<asp:ListItem> Rajshahi </asp:ListItem>
	 <asp:ListItem> Nawabganj </asp:ListItem>
	 <asp:ListItem> Naogaon </asp:ListItem>
	 <asp:ListItem> Bogra </asp:ListItem>
	 <asp:ListItem> Natore </asp:ListItem>
	 <asp:ListItem> Joypurhat </asp:ListItem>
	 <asp:ListItem> Sirajganj </asp:ListItem>
	 <asp:ListItem> Pabna </asp:ListItem>
	 <asp:ListItem> Habiganj </asp:ListItem>
	 <asp:ListItem> Moulovibazar </asp:ListItem>
	 <asp:ListItem> Sunamganj </asp:ListItem>
	 <asp:ListItem> Sylhet </asp:ListItem>
	 <asp:ListItem> Brahmanbaria </asp:ListItem>
	 <asp:ListItem> Noakhali </asp:ListItem>
	 <asp:ListItem> Chandpur </asp:ListItem>
	 <asp:ListItem> Laxmipur </asp:ListItem>
	 <asp:ListItem> Comilla </asp:ListItem>
	 <asp:ListItem> Feni </asp:ListItem>
	 <asp:ListItem> Khagrachori </asp:ListItem>
	 <asp:ListItem> Rangamati </asp:ListItem>
	 <asp:ListItem> Chittagong </asp:ListItem>
	 <asp:ListItem> Bandarban </asp:ListItem>
	 <asp:ListItem> Cox's Bazar </asp:ListItem>
            </asp:DropDownList>
           <br />
        <br />
         <asp:Label ID="Label2" runat="server" Text=" Blood Group" Width="164px"></asp:Label>
            <asp:DropDownList ID="DropDownList3" runat="server" Height="25px" Width="226px" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                <asp:ListItem>A+</asp:ListItem>
                <asp:ListItem>A-</asp:ListItem>
                <asp:ListItem>AB+</asp:ListItem>
                <asp:ListItem>AB-</asp:ListItem>
                <asp:ListItem>B+</asp:ListItem>
                <asp:ListItem>B-</asp:ListItem>
                <asp:ListItem>O+</asp:ListItem>
                <asp:ListItem>O-</asp:ListItem>
            </asp:DropDownList>
   

  </fieldset>
    <fieldset style="width:   90%;  font-size: medium;border-radius: 15px;">
     
        
  <legend style="color: #3366CC; font-size: large;">Terms and Mailing</legend>

 
        <br />
          &nbsp;<asp:CheckBox ID="CheckBox1" runat="server" Text="My Contact Number will be visible to others" />
        <br />
        <br />
          <asp:CheckBox ID="CheckBox3" runat="server" Text="I have accepted the terms and condition of Physician Directory " />
            <br />
        
          <br />
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" Width="124px" 
              BackColor="#006666" ForeColor="White" Height="48px" OnClick="SubmitButton_Click"  />
    
  </fieldset>
</div>
       <hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
</form>
 
</html>

