<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="HomePageUser.aspx.cs" Inherits="E_Care.HomePageUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
   <div class="heads" style="background-color:#C0C0C0; height:50px; ">
        <ul class="ull">
<li class="lli"><a href="BloodGroupSearchResult.aspx" style="color: #006699; text-decoration:none" >Blood Bank</a></li>
<li class="lli" runat="server" id="m"> <a href="MessageInboxList.aspx"style="color: #006699;text-decoration:none" >Inbox</a></li>
<li class="lli"  runat="server" id="n"><a href="NotificationsList.aspx"style="color: #006699;text-decoration:none">Notifications</a></li>
<li class="lli"><a href="PrescriptionHistory.aspx"style="color: #006699;text-decoration:none">My Prescriptions</a></li>
<li class="lli" runat="server"  id="p"><a href="PrescriptionRequestList.aspx"style="color: #006699;text-decoration:none">Prescription Request</a></li>
<li class="lli"><a href="EditPatient.aspx"style="color: #006699;text-decoration:none">Edit Information</a></li>
<li class="lli"><a href="AskQuestionsList.aspx"style="color: #006699;text-decoration:none">Ask Questions</a></li>
<li class="lli"><a href="ArticleList.aspx"style="color: #006699;text-decoration:none">Articles</a></li>
         
</ul>
    </div>
  <div style="text-align:center;margin-top:5px;margin-bottom:5px">
        <asp:Image ID="Image1" runat="server" Height="400px" ImageUrl="~/Photo/physician-website-patients-relationship-1.jpg" Width="50%" />
  
    </div>
    <div style="background-color:#006699; text-align:center; height: auto;margin-top:-10px">
        <br />
        <asp:Label ID="Label1" runat="server" Text="I need a physician specialize in" Font-Size="X-Large" Height="26px" Width="381px" ForeColor="White"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Width="250px" Height="26px">
             <asp:ListItem>Allergy and Immunology</asp:ListItem>
 <asp:ListItem>Anaesthetics</asp:ListItem>
 <asp:ListItem>Pathology</asp:ListItem>
 <asp:ListItem>Cardiology</asp:ListItem>
 <asp:ListItem>Paediatric cardiology</asp:ListItem>
 <asp:ListItem>Cardiothoracic surgery</asp:ListItem>
 <asp:ListItem>Child and adolescent psychiatry and sychotherapy</asp:ListItem>
<asp:ListItem>Clinical neurophysiology</asp:ListItem>
<asp:ListItem>Dermato-Venereology</asp:ListItem>
<asp:ListItem>Emergency Medicine</asp:ListItem>
<asp:ListItem>Endocrinology</asp:ListItem>
<asp:ListItem>Gastroenterology</asp:ListItem>
<asp:ListItem>General Practice</asp:ListItem>
<asp:ListItem>Geriatrics</asp:ListItem>
<asp:ListItem>Gynaecology and obstetrics</asp:ListItem>
<asp:ListItem>Health Informatics</asp:ListItem>
<asp:ListItem>Infectious diseases</asp:ListItem>
<asp:ListItem>Internal Medicine</asp:ListItem>
<asp:ListItem>Interventional Radiology</asp:ListItem>
<asp:ListItem>Vascular medicine</asp:ListItem>
<asp:ListItem>Microbiology</asp:ListItem>
<asp:ListItem>Nephrology</asp:ListItem>
<asp:ListItem>Neurology</asp:ListItem>
<asp:ListItem>Neurosurgery</asp:ListItem>
<asp:ListItem>Nuclear medicine</asp:ListItem>
<asp:ListItem>Occupational medicine</asp:ListItem>
<asp:ListItem>Ophthalmology</asp:ListItem>
<asp:ListItem>Orthopaedics</asp:ListItem>
<asp:ListItem>Oral and Maxillofacial Surgery</asp:ListItem>
<asp:ListItem>Otorhinolaryngology</asp:ListItem>
<asp:ListItem>Paediatrics</asp:ListItem>
<asp:ListItem>Paediatric allergology</asp:ListItem>
<asp:ListItem>Paediatric endocrinology and diabetes</asp:ListItem>
<asp:ListItem>Paediatric gastroenterology, hepatology and nutrition</asp:ListItem>
<asp:ListItem>Paediatric haematology and oncology</asp:ListItem>
<asp:ListItem>Paediatric infectious diseases</asp:ListItem>
<asp:ListItem>Neonatology</asp:ListItem>
<asp:ListItem>Paediatric Nephrology</asp:ListItem>
<asp:ListItem>Paediatric respiratory medicine</asp:ListItem>
<asp:ListItem>Paediatric rheumatology</asp:ListItem>
<asp:ListItem>Paediatric surgery</asp:ListItem>
<asp:ListItem>Physical and Rehabilitation Medicine</asp:ListItem>
<asp:ListItem>Plastic, Reconstructive and Aesthetic Surgery</asp:ListItem>
<asp:ListItem>Pneumology</asp:ListItem>
<asp:ListItem>Psychiatry</asp:ListItem>
<asp:ListItem>Public Health</asp:ListItem>
<asp:ListItem>Radiology</asp:ListItem>
<asp:ListItem>Neuroradiology</asp:ListItem>
<asp:ListItem>Radiotherapy</asp:ListItem>
<asp:ListItem>General surgery</asp:ListItem>
<asp:ListItem>Urology</asp:ListItem>
<asp:ListItem>Vascular surgery</asp:ListItem>

        </asp:DropDownList>
           <asp:Label ID="Label2" runat="server" Text=" near " Font-Size="X-Large" Height="26px" Width="96px" ForeColor="White"></asp:Label>
          <asp:DropDownList ID="DropDownList2" runat="server" Width="250px" Height="26px">
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
         <asp:Label ID="Label7" runat="server" Text=" " Font-Size="X-Large" Height="26px" Width="30px" ForeColor="White"></asp:Label>
        <asp:Button ID="Button1" runat="server" Text="Search" Width="75px" Height="26px" BackColor="#669999" ForeColor="White" OnClick="Button1_Click" />
        <br />
      <br />
        <asp:Label ID="Label4" runat="server" Text="I need a Blood of Group" Font-Size="X-Large" Height="26px" Width="286px" ForeColor="White"></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server" Width="162px" Height="26px">
                         <asp:ListItem> A+ </asp:ListItem>
             <asp:ListItem> A- </asp:ListItem>
             <asp:ListItem> B+ </asp:ListItem>
             <asp:ListItem> B- </asp:ListItem>
             <asp:ListItem> O+ </asp:ListItem>
             <asp:ListItem> O- </asp:ListItem>
             <asp:ListItem> AB+ </asp:ListItem>
             <asp:ListItem> AB- </asp:ListItem>
        </asp:DropDownList>
           <asp:Label ID="Label5" runat="server" Text=" near " Font-Size="X-Large" Height="26px" Width="96px" ForeColor="White"></asp:Label>
          <asp:DropDownList ID="DropDownList4" runat="server" Width="250px" Height="26px">
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
         <asp:Label ID="Label8" runat="server" Text=" " Font-Size="X-Large" Height="26px" Width="30px" ForeColor="White"></asp:Label>
         <asp:Button ID="Button3" runat="server" Text="Search" Width="75px" Height="26px" BackColor="#666699" ForeColor="White" OnClick="Button3_Click" />
        <br />
        <br />
    </div>
         <div  >
  
    </div>
    <hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved./div>
</asp:Content>

