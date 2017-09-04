<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="DoctorProfileOwn.aspx.cs" Inherits="E_Care.DoctorProfileOwn" %>

<script runat="server">

</script>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
      <div class="heads" style="background-color:#C0C0C0; height:50px; ">
        <ul class="ull">
<li class="lli"><a href="DoctorProfileOwn.aspx" style="color: #006699; text-decoration:none" >Home</a></li>
<li class="lli"><a href="MessageInboxList.aspx"style="color: #006699;text-decoration:none">Inbox</a></li>
<li class="lli"><a href="NotificationsListDoctor.aspx"style="color: #006699;text-decoration:none">Notifications</a></li>
 <li class="lli"><a href="EditDoctorInformation.aspx"style="color: #006699;text-decoration:none">Edit Information</a></li>
<li class="lli"><a href="AskQuestions.aspx"style="color: #006699;text-decoration:none">Ask Questions</a></li>
<li class="lli"><a href="ArticleList.aspx"style="color: #006699;text-decoration:none">Articles</a></li>
</ul>
    </div>
    <div style="margin-bottom:0px;margin-left:129px;margin-right:129px;height:445px; background-color:ghostwhite" >
           <div style="width:35%;display:inline-block;margin-top:10px">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Photo/Doctor_with_Patient_RGB.jpg" Width="100%" Height="336px"  />
               <br />
       <asp:FileUpload ID="FileUploadControl" runat="server" />
               <br />
              
       <asp:Button ID="UploadButton" runat="server" OnClick="UploadButton_Click" Text="Save" Width="87px" />
       <br />
       <asp:Label ID="StatusLabel" runat="server"></asp:Label>
               </div>
         <div style="width:59%; text-align:left;margin-left:20px;margin-right:0px;margin-top:5px;display:inline-block;vertical-align:top; height: 415px;">
             <div style="margin-top:10px">
               <asp:Label ID="Label16" runat="server" Text=" Name: " Font-Size="Large" Height="26px" Width="200px" ForeColor="#89919c"></asp:Label>
      <asp:Label ID="Labelname" runat="server" Text=" Dr.Md.Aminur Rahman Laskar " Font-Size="X-Large" Height="26px" Width="361px" ForeColor="#004498"></asp:Label>
             <br />
                 </div>
              <div style="margin-top:10px">
               <asp:Label ID="Label17" runat="server" Text=" Degree: " Font-Size="Large" Height="26px" Width="200px" ForeColor="#89919c"></asp:Label>
                 <asp:Label ID="Labeldegree" runat="server" Text=" MBBS,D.Card " Font-Size="Large" Height="26px" Width="361px" ForeColor="#3D9FF1"></asp:Label><br /></div>
                   <div style="margin-top:10px">
               <asp:Label ID="Label18" runat="server" Text=" Speciality: " Font-Size="Large" Height="26px" Width="200px" ForeColor="#89919c"></asp:Label>
             <asp:Label ID="Labelspeciality" runat="server" Text=" Cardiologyst " Font-Size="Large" Height="26px" Width="361px" ForeColor="#CC0066"></asp:Label>
             <br /></div>
                        <div style="margin-top:10px;vertical-align:top">
                            <span style="margin-top:0px;vertical-align:top;display:inline-block">
               <asp:Label ID="Label19" runat="server" Text=" Professional Details: " Font-Size="Large" Height="70px" Width="200px" ForeColor="#89919C"></asp:Label>
                                </span>
                                 <span style="margin-top:0px;vertical-align:top;display:inline-block">
                 <asp:Label ID="Labelworkingon" runat="server" Text=" Associate Professor and Head Department of Cardiology at Sylhet Osmani Medical College and hospital  " Font-Size="Large" Height="70px" Width="400px" ForeColor="#006666"></asp:Label>
                  </span>
                                     
             <br /></div>
                             <div style="margin-top:10px;vertical-align:top">
                                     <span style="margin-top:0px;vertical-align:top;display:inline-block">
               <asp:Label ID="Label20" runat="server" Text=" Chamber Address: " Font-Size="Large" Height="50px" Width="200px" ForeColor="#89919c"></asp:Label>
                                                     </span>
                                             <span style="margin-top:0px;vertical-align:top;display:inline-block">
             <asp:Label ID="Labelchamberaddress" runat="server" Text=" Royal Hospital, Ground Floor, Zindabazar, Sylhet" Font-Size="Large" Height="50px" Width="361px" ForeColor="#333333"></asp:Label>
            </span>
             

             <br /></div>
                                  <div style="margin-top:10px">
                  <asp:Label ID="Label21" runat="server" Text="Contact Number: " Font-Size="Large" Height="26px" Width="200px" ForeColor="#89919c"></asp:Label>
         <asp:Label ID="Labelcontactnumber" runat="server" Text=" +8801711355134" Font-Size="Large" Height="26px" Width="361px" ForeColor="#333333"></asp:Label>
               </div>
           <br />
             <asp:Label ID="Label23" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="#009933"></asp:Label>
           
  </div>  <hr/> 
</div>
    <div style="background-color:ghostwhite; text-align:center; height: 292px; margin-top:0px;margin-left:129px;margin-right:129px;text-align:left;">
        <br />
        <div style="margin-top:0px;vertical-align:top;text-align:left;margin-left:20px;display:inline-block; width: 351px;">
             
               <asp:Label ID="Label1" runat="server" Text="(My Practice Hours: 5:30pm to 8:30pm) " Font-Size="Large" Height="50px" Width="367px" ForeColor="#336699"></asp:Label>
                                             
        </div>
        <div style="margin-left:200px;display:inline-block">
             <div style="margin-left:20px;display:inline-block">
                <asp:Button ID="Button8" runat="server" Text="My Inbox" Height="35px" Width="119px" ForeColor="White" BackColor="#CC0066" OnClick="Button8_Click" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                <asp:Button ID="Button9" runat="server" Text="Send Prescription" Height="35px" Width="119px" ForeColor="White" BackColor="#3366CC" OnClick="Button9_Click" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                <asp:Button ID="Button10" runat="server" Text="My Patients" Height="35px" Width="119px" ForeColor="White" BackColor="#009999" OnClick="Button10_Click" />
            </div>
        </div>
        <br />
        <br />
        <div style="vertical-align:middle;margin-left:20px">    
               <asp:Label ID="Label8" runat="server" Text="Check Appointments on following days: "  Font-Size="Large" Height="31px" Width="367px" ForeColor="#333333"></asp:Label></div>
                                     <span style="margin-top:0px;vertical-align:top;text-align:left;margin-left:20px">
             
                                                     </span>
                <div class="days" style="margin-top:0px">
            <div style="margin-left:20px;display:inline-block;text-align:center">
                 <asp:Label ID="Day1" runat="server" Text=" April 1 " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
                   <asp:Label ID="Day2" runat="server" Text=" April 2 " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
                <asp:Label ID="Day3" runat="server" Text=" April 3 " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
           <asp:Label ID="Day4" runat="server" Text=" April 4 " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
                 <asp:Label ID="Day5" runat="server" Text=" April 5 " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
        <asp:Label ID="Day6" runat="server" Text=" April 6 " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
                  <asp:Label ID="Day7" runat="server" Text=" April 7 " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>

    </div>
        <div class="prescription";>
            <div style="margin-left:20px;display:inline-block;">
                <asp:Button ID="Button1" runat="server" Text="Saturday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" OnClick="Button1_Click" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button2" runat="server" Text="Sunday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" OnClick="Button2_Click" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button3" runat="server" Text="Monday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" OnClick="Button3_Click" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button4" runat="server" Text="Tuesday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" OnClick="Button4_Click" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button5" runat="server" Text="Wednesday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" OnClick="Button5_Click" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button6" runat="server" Text="Thursday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" OnClick="Button6_Click"/>
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button7" runat="server" Text="Friday(Closed)" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" Enabled="False" OnClick="Button7_Click" />
            </div>

    </div>
    </div>
    
         <div  >
  
    </div>
    <hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
    
</asp:Content>

