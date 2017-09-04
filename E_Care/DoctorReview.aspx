<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="DoctorReview.aspx.cs" Inherits="E_Care.DoctorReview"  %>



<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
  
   <div class="heads" style="background-color:#C0C0C0; height:50px; ">
        <ul class="ull">
<li class="lli"><a href="BloodGroup.aspx" style="color: #006699; text-decoration:none" >Blood Bank</a></li>
<li class="lli"><a href="MessageInboxList.aspx"style="color: #006699;text-decoration:none">Inbox</a></li>
<li class="lli"><a href="NotificationsList.aspx"style="color: #006699;text-decoration:none">Notifications</a></li>
<li class="lli"><a href="PrescriptionRequestList.aspx"style="color: #006699;text-decoration:none">My Prescriptions</a></li>
 <li class="lli"><a href="EditPatient.aspx"style="color: #006699;text-decoration:none">Edit Information</a></li>
<li class="lli"><a href="AskQuestions.aspx"style="color: #006699;text-decoration:none">Ask Questions</a></li>
<li class="lli"><a href="ArticleList.aspx"style="color: #006699;text-decoration:none">Articles</a></li>
</ul>
    </div>
    <div style="margin-bottom:0px;margin-left:129px;margin-right:129px;height:319px; background-color:ghostwhite" >
           <div style="width:35%;display:inline-block;margin-top:10px">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Photo/Doctor_with_Patient_RGB.jpg" Width="100%" Height="294px"  />
               </div>
         <div style="width:59%; text-align:left;margin-left:20px;margin-right:0px;margin-top:5px;display:inline-block;vertical-align:top; height: 316px;">
             <div style="margin-top:10px">
               <asp:Label ID="Label16" runat="server" Text=" Name: " Font-Size="Medium" Height="19px" Width="200px" ForeColor="#89919C"></asp:Label>
      <asp:Label ID="Label9" runat="server" Text=" Dr.Md.Aminur Rahman Laskar " Font-Size="Large" Height="19px" Width="361px" ForeColor="#004498"></asp:Label>
             <br />
                 </div>
              <div style="margin-top:10px">
               <asp:Label ID="Label17" runat="server" Text=" Degree: " Font-Size="medium" Height="19px" Width="200px" ForeColor="#89919c"></asp:Label>
             <asp:Label ID="Label14" runat="server" Text=" MBBS,D.Card " Font-Size="medium" Height="19px" Width="361px" ForeColor="#3d9ff1"></asp:Label>
             <br /></div>
                   <div style="margin-top:10px">
               <asp:Label ID="Label18" runat="server" Text=" Speciality: " Font-Size="medium" Height="19px" Width="200px" ForeColor="#89919c"></asp:Label>
             <asp:Label ID="Label10" runat="server" Text=" Cardiologyst " Font-Size="medium" Height="19px" Width="361px" ForeColor="#CC0066"></asp:Label>
             <br /></div>
                        <div style="margin-top:10px;vertical-align:top">
                            <span style="margin-top:0px;vertical-align:top;display:inline-block">
               <asp:Label ID="Label19" runat="server" Text=" Professional Details: " Font-Size="medium" Height="50px" Width="200px" ForeColor="#89919C"></asp:Label>
                                </span>
                                 <span style="margin-top:0px;vertical-align:top;display:inline-block">
                 <asp:Label ID="Label15" runat="server" Text=" Associate Professor and Head Department of Cardiology at Sylhet Osmani Medical College and hospital  " Font-Size="Medium" Height="50px" Width="400px" ForeColor="#006666"></asp:Label>
                  </span>
                                     
             <br /></div>
                             <div style="margin-top:10px;vertical-align:top">
                                     <span style="margin-top:0px;vertical-align:top;display:inline-block">
               <asp:Label ID="Label20" runat="server" Text=" Chamber Address: " Font-Size="Medium" Height="37px" Width="200px" ForeColor="#89919C"></asp:Label>
                                                     </span>
                                             <span style="margin-top:0px;vertical-align:top;display:inline-block">
             <asp:Label ID="Label11" runat="server" Text=" Royal Hospital, Ground Floor, Zindabazar, Sylhet" Font-Size="Medium" Height="37px" Width="361px" ForeColor="#333333"></asp:Label>
            </span>
             

             <br /></div>
                                  <div style="margin-top:10px">
                  <asp:Label ID="Label21" runat="server" Text="Contact Number: " Font-Size="Medium" Height="19px" Width="200px" ForeColor="#89919C"></asp:Label>
         <asp:Label ID="Label13" runat="server" Text=" +8801711355134" Font-Size="Medium" Height="19px" Width="361px" ForeColor="#333333"></asp:Label>
               </div>
           
  </div>  <hr/> 
</div>
    <div style="background-color:ghostwhite; text-align:center; height: 321px; margin-top:0px;margin-left:129px;margin-right:129px;text-align:left;">
        <br />
       
   
             <div style="display:inline-block;margin-bottom:10px;width:55%;text-align:center">
                  <asp:Label ID="Label1" runat="server" Text="Reviews" ForeColor="#003366"></asp:Label>
            </div>
             <div style="display:inline-block;width:40%;text-align:center">
                 <asp:Label ID="Label2" runat="server" Text="Write a review..." ForeColor="#666666"></asp:Label>
            </div>
  
      
        
        <div class="Review">
          <div style="width:55%;display:inline-block;margin-left:20px">
              <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" Height="211px" Width="559px" OnTextChanged="TextBox1_TextChanged" ></asp:TextBox>
          </div>
            <div style="width:38%; display:inline-block;text-align:center;vertical-align:top;margin-left:20px; margin-bottom: 0px;margin-right:10px">
                   <asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" Height="122px" Width="250px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                <div style="width: 325px; text-align:right" >
                <asp:Button ID="Button1" runat="server" Text="Post Review" BackColor="#339966" OnClick="Button1_Click" />
                    </div>
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

