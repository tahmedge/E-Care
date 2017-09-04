<%@ Page Title="" Language="C#" MasterPageFile="~/Site2.Master" AutoEventWireup="true" CodeBehind="DoctorProfileUnregistered.aspx.cs" Inherits="E_Care.DoctorProfileUnregistered" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
  

    <div style="margin-bottom:0px;margin-left:69px;margin-right:69px;height:445px; background-color:ghostwhite" >
           <div style="width:29%; display:inline-block;margin-top:10px">
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Photo/Doctor_with_Patient_RGB.jpg" Width="92%" Height="288px"  />
               </div>
         <div style="width:69%; text-align:left;margin-left:0px;margin-right:0px;margin-top:5px;display:inline-block;vertical-align:top; height: 415px;">
             <div style="margin-top:10px">
               <asp:Label ID="Label16" runat="server" Text=" Name: " Font-Size="Large" Height="26px" Width="200px" ForeColor="#89919c"></asp:Label>
      <asp:Label ID="Labelname" runat="server" Text=" Dr.Md.Aminur Rahman Laskar " Font-Size="X-Large" Height="26px" Width="361px" ForeColor="#004498"></asp:Label>
             <br />
                 </div>
              <div style="margin-top:10px">
               <asp:Label ID="Label17" runat="server" Text=" Degree: " Font-Size="Large" Height="26px" Width="200px" ForeColor="#89919c"></asp:Label>
             <asp:Label ID="Labeldegree" runat="server" Text=" MBBS,D.Card " Font-Size="Large" Height="26px" Width="361px" ForeColor="#3d9ff1"></asp:Label>
             <br /></div>
                   <div style="margin-top:10px">
               <asp:Label ID="Label" runat="server" Text=" Speciality: " Font-Size="Large" Height="26px" Width="200px" ForeColor="#89919c"></asp:Label>
             <asp:Label ID="Labelspeciality" runat="server" Text=" Cardiologyst " Font-Size="Large" Height="26px" Width="361px" ForeColor="#CC0066"></asp:Label>
             <br /></div>
                        <div style="margin-top:10px;vertical-align:top">
                            <span style="margin-top:0px;vertical-align:top;display:inline-block">
               <asp:Label ID="Label111" runat="server" Text=" Professional Details: " Font-Size="Large" Height="70px" Width="200px" ForeColor="#89919C"></asp:Label>
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
           
  </div>  <hr/> 
</div>
    <div style="background-color:ghostwhite; text-align:center; height: 292px; margin-top:0px;margin-left:129px;margin-right:129px;text-align:left;">
        <br />
        <div style="margin-left:200px;display:inline-block">
             <div style="margin-left:20px;display:inline-block">
            </div>
             <div style="margin-left:20px;display:inline-block">
            </div>
        </div>
        <br />
        <br />
          <div class="days" >
            <div style="margin-left:20px;display:inline-block;text-align:center">
                 <asp:Label ID="Day1" runat="server" Text=" Available " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
                   <asp:Label ID="Day2" runat="server" Text=" Available  " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
                <asp:Label ID="Day3" runat="server" Text=" Available  " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
           <asp:Label ID="Day4" runat="server" Text=" Available  " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
                 <asp:Label ID="Day5" runat="server" Text=" Available  " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
        <asp:Label ID="Day6" runat="server" Text=" Available  " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>
             <div style="margin-left:20px;display:inline-block;text-align:center">
                  <asp:Label ID="Day7" runat="server" Text=" Closed  " Font-Size="Large" Height="25px" Width="119px" ForeColor="#89919C"></asp:Label>
            </div>

    </div>
        <div class="prescription">
            <div style="margin-left:20px;display:inline-block">
                <asp:Button ID="Button1" runat="server" Text="Saturday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" Enabled="False" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button2" runat="server" Text="Sunday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" Enabled="False" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button3" runat="server" Text="Monday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" Enabled="False" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button4" runat="server" Text="Tuesday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" Enabled="False" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button5" runat="server" Text="Wednesday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" Enabled="False" />
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button6" runat="server" Text="Thursday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" Enabled="False"/>
            </div>
             <div style="margin-left:20px;display:inline-block">
                 <asp:Button ID="Button7" runat="server" Text="Friday" Height="50px" Width="119px" ForeColor="Black" BackColor="#339966" Enabled="False" />
            </div>

    </div>
    </div>
    
     <hr />
      <div id="footer" 
         style="background-color:white;clear:both;text-align:center; color: #c34444; width:  100%; height:auto;">
                Copyright ©
                 2014 Team Underdog, All Rights Reserved.</div>
    
</asp:Content>

