<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditDoctorInformation.aspx.cs" Inherits="E_Care.EditDoctorInformation" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">

 <head runat="server">

 <style type="text/css">
     .style2
     {
         width: 5px;
         display:inline-block;
     }
     .style3
     {
         width: 30%;
         display:inline-block;
        margin-top:0px;
        height:810px;
        vertical-align: top;
     }
 </style>


 </head>

 <body style="background-color:ghostwhite">


 <h1 style="color: #FFFFFF; background-color: #3366CC;margin-top: -10px;width:  100%;">
     Doctor&#39;s Registration</h1>
  <form id="form1" runat="server" >
    
     <div style="border:0; width:100%;height:900px">

          <div class="style3">
   <fieldset style="width: 99%; ">
  <legend style="color: #009999; font-size: large;">Account Information</legend>
        <br />
        <asp:Label ID="Label9" runat="server" Text="Email" Width="200px"></asp:Label><asp:TextBox ID="TextBox_Email" 
            runat="server" Width="191px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        <br>
      <asp:Label ID="Label10" runat="server" Text="Password" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox_Password" runat="server" Width="191px" OnTextChanged="TextBox3_TextChanged" TextMode="Password"></asp:TextBox>
        <br />
        <br>
        <asp:Label ID="Label11" runat="server" Text="Confirm Password" Width="200px"></asp:Label>
        <asp:TextBox ID="TextBox_Confirmpassword" runat="server" Width="191px" OnTextChanged="TextBox4_TextChanged" TextMode="Password"></asp:TextBox>
        <br />
       <br />
        <br />
 </fieldset>
   
<br />
              
    <fieldset style="width:   99%"><legend style="color: #CC0066; font-size: large;">
        Personal Information</legend>
             <asp:Label ID="Label12" runat="server" Text=" Full Name" Width="200px" style="height: 19px"></asp:Label>
        <asp:TextBox ID="TextBox_Fullname" runat="server" Width="221px" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
        <br />
        <br />
        </fieldset>
    <fieldset style="width:   99%; height: 335px;">
     <legend style="color: #FF9933; font-size: large;">Chamber Information</legend>
        <br />
         <asp:Label ID="Label15" runat="server" Text=" District" Width="200px"></asp:Label>
            <asp:DropDownList ID="DropDownListDistrict" runat="server" Height="25px" Width="188px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                      <asp:ListItem>Dhaka</asp:ListItem>
         <asp:ListItem>Rajshahi</asp:ListItem>
         <asp:ListItem>Barishal</asp:ListItem>
         <asp:ListItem>Chittagong</asp:ListItem>
         <asp:ListItem>Sylhet</asp:ListItem>
               <asp:ListItem>Rangpur</asp:ListItem>
        <asp:ListItem>Tangail</asp:ListItem>
	 <asp:ListItem>Sherpur</asp:ListItem>
	 <asp:ListItem>Shariatpur</asp:ListItem>
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
        
          <asp:Label ID="Label16" runat="server" Text=" Chamber Address" Width="200px"></asp:Label>
    
           
       
        <asp:TextBox ID="TextBox_Chamberaddress" runat="server" Width="344px" Height="96px" OnTextChanged="TextBox_Chamberaddress_TextChanged" ></asp:TextBox>
       <br />
           <br />
           <br />
    </fieldset>  

          </div>


       <div class="style3" style="width:30%; margin-left:30px;margin-right:30px; margin-top:0px;height: 810px;">
       
        <fieldset style="width:   100%;  " >
     
        
  <legend style="color: #3366CC; font-size: large;">Professional Information</legend>
         <asp:Label ID="Label1" runat="server" Text="Speciality" Width="200px"></asp:Label>
 
    
            <asp:DropDownList ID="DropDownListSpeciality" runat="server" Height="22px" 
                onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
              Width="200px" style="margin-left: 0px">
                <asp:ListItem>Cardiology</asp:ListItem>
                <asp:ListItem>Medicine</asp:ListItem>
            </asp:DropDownList>
         
                <br />
            <br />
         
                <asp:Label ID="Label18" runat="server" Text="Degree" Width="200px"></asp:Label>
               
                <asp:TextBox ID="TextBox_Degree" runat="server" Width="200px" Height="48px" OnTextChanged="TextBox12_TextChanged"></asp:TextBox>
        

                <br />
            <br />
         
                <asp:Label ID="Label3" runat="server" Text="Working on " Width="200px" Height="21px"></asp:Label>
               
                <asp:TextBox ID="TextBox_Workingon" runat="server" Width="185px" OnTextChanged="TextBox7_TextChanged" TextMode="MultiLine"></asp:TextBox>
        

                <br />
            <br />
        

                <asp:Label ID="Label4" runat="server" Text="Working as" Width="200px"></asp:Label>
           
           
               
               
                <asp:TextBox ID="TextBox_Workingas" runat="server" Width="185px" OnTextChanged="TextBox7_TextChanged"></asp:TextBox>
        
                <br />
            <br />
           <asp:Label ID="Label2" runat="server" Text="Contact Number" Width="200px"></asp:Label>
 
        <asp:TextBox ID="TextBox_Contactnumber" runat="server" Width="200px" OnTextChanged="TextBox4_TextChanged" TextMode="Number"></asp:TextBox>
        

                <br />
            <br />
           
           
            <br />
           
           
                <asp:Label ID="Label17" runat="server" Text="Available on" Width="200px"></asp:Label>
              <br /> 
                 <div style="margin-left:210px">
           <asp:CheckBox ID="CheckBox_Monday" runat="server" 
                    oncheckedchanged="CheckBox1_CheckedChanged" Text="Monday" 
                    ForeColor="#3366CC" Width="200px" />
            
                             <br />              
         
           
                <asp:CheckBox ID="CheckBox_Tuesday" runat="server" Text="Tuesday" 
                    ForeColor="#3366CC" Width="200px" OnCheckedChanged="CheckBox2_CheckedChanged" />
                   <br />
                <asp:CheckBox ID="CheckBox_Wednesday" runat="server" Text="Wednesday" 
                    ForeColor="#3366CC" Width="200px" OnCheckedChanged="CheckBox_Wednesday_CheckedChanged" />
                       <br />   
                <asp:CheckBox ID="CheckBox_Thursday" runat="server" Text="Thursday" 
                    ForeColor="#3366CC" Width="200px" OnCheckedChanged="CheckBox4_CheckedChanged" />
                            <br />
                <asp:CheckBox ID="CheckBox_Friday" runat="server" Text="Friday" ForeColor="#3366CC" Width="200px" OnCheckedChanged="CheckBox5_CheckedChanged" />
                           <br />
               <asp:CheckBox ID="CheckBox_Saturday" runat="server" Text="Saturday" 
                    ForeColor="#3366CC" Width="200px" OnCheckedChanged="CheckBox6_CheckedChanged" />
                              <br />
       <asp:CheckBox ID="CheckBox_Sunday" runat="server" Text="Sunday" ForeColor="#3366CC" Width="200px" OnCheckedChanged="CheckBox7_CheckedChanged" />
                     <br />
                     
               </div>
            <div>
                         <asp:Label ID="Label7" runat="server" Text="Visiting fee(Optional)" Width="200px"></asp:Label>
             
                <asp:DropDownList ID="DropDownList3" runat="server" Width="200px" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                    <asp:ListItem>500</asp:ListItem>
                         </asp:DropDownList>
                     </div>
  </fieldset> 
           </div>
           <div class="style3" style="width:30%; height: 810px;">
        <fieldset style="width:   100%;">
     
        
  <legend style="color: #CC0066; font-size: large;">Online Ticket Appointment System</legend>
            <br />
               <div style="margin-left:65px">
         
                <asp:Label ID="Label8" runat="server"   Width="100%" Text="Would you like to allow online ticket appointment?" Height="41px"
                    ></asp:Label>
                         </div>

           
            <div style="margin-left:134px">
                <asp:RadioButton ID="RadioButton1" runat="server" ForeColor="#FF0066"  GroupName="String" 
                    Text="Yes" OnCheckedChanged="RadioButton1_CheckedChanged" Checked="True" />

                <asp:RadioButton ID="RadioButton2" runat="server" ForeColor="#FF0066"  GroupName="String" 
                    Text="No" OnCheckedChanged="RadioButton2_CheckedChanged" />
                <br />
                <br />
                </div>
              <div style="margin-top:5px">
                         <asp:Label ID="Label24" runat="server" Text="Maximum Ticket Appointment" Width="229px" Height="22px"></asp:Label>
             
                         <asp:TextBox ID="TextBox_Appointmentlimit" runat="server" TextMode="Number" Width="76px" MaxLength="2" OnTextChanged="TextBox_Appointmentlimit_TextChanged">20</asp:TextBox>
                     </div>
<br />
            
            <br />
          <br />
     

  </fieldset>

    <fieldset style="width:   100%;  font-size: medium;">
     
        
  <legend style="color: #996633; font-size: large;">Confirmation</legend>
            <br />
        
          <br />
        <asp:Button ID="Button2" runat="server" Text="Save" Width="124px" 
              BackColor="#006666" ForeColor="White" Height="48px" OnClick="Button2_Click" />
    
  </fieldset>
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

