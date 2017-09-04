<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="BloodGroup.aspx.cs" Inherits="E_Care.BloodGroup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div class="heads" style="background-color:#C0C0C0; height:50px; ">
        <ul class="ull">
<li class="lli"><a href="BloodGroup.aspx" style="color: #006699; text-decoration:none" >Blood Bank</a></li>
<li class="lli"><a href="MessageInboxList.aspx"style="color: #006699;text-decoration:none">Inbox</a></li>
<li class="lli"><a href="NotificationsList.aspx"style="color: #006699;text-decoration:none">Notifications</a></li>
<li class="lli"><a href="PrescriptionHistory.aspx"style="color: #006699;text-decoration:none">My Prescriptions</a></li>
               <li class="lli"><a href="PrescriptionRequestList.aspx"style="color: #006699;text-decoration:none">Prescription Request</a></li>
 <li class="lli"><a href="EditPatient.aspx"style="color: #006699;text-decoration:none">Edit Information</a></li>
<li class="lli"><a href="AskQuestions.aspx"style="color: #006699;text-decoration:none">Ask Questions</a></li>
<li class="lli"><a href="ArticleList.aspx"style="color: #006699;text-decoration:none">Articles</a></li>
         
</ul>
    </div>
    <div style="margin-left:129px;margin-right:129px;background-color:ghostwhite;" >
  <h1 style="text-align:center;color:crimson">GIVE BLOOD AND SAVE LIFE</h1>
        <p style="font-size:x-large">
            Give Blood and save life. Find the people around you who need blood urgently and help them if their needed blood group is matched with your one.Click on the follwing button to find out today's necessary blood of people around you.
        </p>
  <div style="text-align:center">
        <asp:Label ID="Label9" runat="server" Text="Blood Group" Font-Size="Large" Height="26px" Width="204px" ForeColor="#006666"></asp:Label>
        <asp:DropDownList ID="DropDownList5" runat="server" Width="250px" Height="26px">
            <asp:ListItem> A+ </asp:ListItem>
              <asp:ListItem> A- </asp:ListItem>
             <asp:ListItem> B+ </asp:ListItem>
             <asp:ListItem> B- </asp:ListItem>
             <asp:ListItem> O+ </asp:ListItem>
             <asp:ListItem> O- </asp:ListItem>
             <asp:ListItem> AB+ </asp:ListItem>
             <asp:ListItem> AB- </asp:ListItem>
        </asp:DropDownList>
           <asp:Label ID="Label10" runat="server" Text=" near " Font-Size="Large" Height="26px" Width="96px" ForeColor="#006666"></asp:Label>
          <asp:DropDownList ID="DropDownList6" runat="server" Width="250px" Height="26px">
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
         <asp:Label ID="Label11" runat="server" Text=" " Font-Size="Large" Height="26px" Width="30px" ForeColor="White"></asp:Label>
         <asp:Button ID="Button4" runat="server" Text="Search" Width="75px" Height="26px" BackColor="#666699" ForeColor="White" OnClick="Button4_Click" />
  </div>
        <hr />
         <h1 style="text-align:center;color:crimson">NEED BLOOD URGENTLY</h1>
             <p style="font-size:x-large">
                 Are you in trouble ? You needed blood for your relatives or friends urgently. Then Physician Directory is the place. Search for the Blood group that you need from the people around you who have an account on Physician Directory.</p>
  <div style="text-align:center">
        <asp:Label ID="Label12" runat="server" Text="I need Blood of Group" Font-Size="Large" Height="26px" Width="209px" ForeColor="#006666"></asp:Label>
        <asp:DropDownList ID="DropDownList7" runat="server" Width="250px" Height="26px">
              <asp:ListItem> A+ </asp:ListItem>
              <asp:ListItem> A- </asp:ListItem>
             <asp:ListItem> B+ </asp:ListItem>
             <asp:ListItem> B- </asp:ListItem>
             <asp:ListItem> O+ </asp:ListItem>
             <asp:ListItem> O- </asp:ListItem>
             <asp:ListItem> AB+ </asp:ListItem>
             <asp:ListItem> AB- </asp:ListItem>
        </asp:DropDownList>
           <asp:Label ID="Label13" runat="server" Text=" near " Font-Size="Large" Height="26px" Width="96px" ForeColor="#006666"></asp:Label>
          <asp:DropDownList ID="DropDownList8" runat="server" Width="250px" Height="26px">
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
         <asp:Label ID="Label14" runat="server" Text=" " Font-Size="Large" Height="26px" Width="30px" ForeColor="White"></asp:Label>
         <asp:Button ID="Button5" runat="server" Text="Search" Width="75px" Height="26px" BackColor="#666699" ForeColor="White" OnClick="Button5_Click" />
  </div>
        <hr />
        <h1 style="text-align:center;color:crimson">POST A STATUS FOR BLOOD</h1>
                     <p style="font-size:x-large">
                         You need Blood? You need to tell people around you to be notified as shortly as possible. Then post on our website about the blood group you need. You should have an account on Physician Directory to get this feature.</p>
  <div style="text-align:center">
        <asp:Label ID="Label15" runat="server" Text="I need Blood of Group" Font-Size="Large" Height="26px" Width="209px" ForeColor="#006666"></asp:Label>
        <asp:DropDownList ID="DropDownList9" runat="server" Width="250px" Height="26px">
              <asp:ListItem> A+ </asp:ListItem>
              <asp:ListItem> A- </asp:ListItem>
             <asp:ListItem> B+ </asp:ListItem>
             <asp:ListItem> B- </asp:ListItem>
             <asp:ListItem> O+ </asp:ListItem>
             <asp:ListItem> O- </asp:ListItem>
             <asp:ListItem> AB+ </asp:ListItem>
             <asp:ListItem> AB- </asp:ListItem>
        </asp:DropDownList>
           <asp:Label ID="Label16" runat="server" Text=" near " Font-Size="Large" Height="26px" Width="96px" ForeColor="#006666"></asp:Label>
          <asp:DropDownList ID="DropDownList10" runat="server" Width="250px" Height="26px">
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
         <asp:Label ID="Label17" runat="server" Text=" " Font-Size="Large" Height="26px" Width="30px" ForeColor="White"></asp:Label>
         <asp:Button ID="Button6" runat="server" Text="Post" Width="75px" Height="26px" BackColor="#666699" ForeColor="White" OnClick="Button6_Click" />
  </div>
        <hr />
    </div>
         <div  >
  
    </div>
    <hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
        
</asp:Content>


