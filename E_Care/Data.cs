using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Drawing;
using System.Linq;
using System.Text;

namespace E_Care
{
    public class Data
    {
        public static string searchspeciality="";
        public static string searchdistrict="";
        public static string searchbloodtype = "";
        public static string searchblooddistrict = "";
        public static string docid = "0";
        public static string pid = "3";
        public static string msgid = "0";
        public static string presid = "0";
        public static string recieverid = "";
        public static string refid = "0";
        public static string day = "Wednesday";
       
        public int getid()
        {
           // int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(id) from ECARE_USER";
            OracleDataReader dr = cmd.ExecuteReader();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;

        }

        public string getmyid(string username, string password)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id from ECARE_USER where username='" + username + "' and password='" + password + "'";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
              string id = dr.GetString(0);
              conn.Dispose();
            return id;
        }
        public int verifyuser(string id, string verificationid,int val)
        {
          //  int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(id) from ECARE_userverification where id='" + id + "' and status="+1+"";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count;
        }


        public string getprescriptionid(string patientid)
        {
            //int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(id) from ECARE_PRESCRIPTION where patientid='" + Data.pid+ "'";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
           // OracleDataReader dr = cmd.ExecuteReader();
           // dr.Read();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            string id = count.ToString();
            return id;
        }
        public string getmessageidpatient(string patientid)
        {
            //int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(id) from ECARE_Message where recieverid='" + Data.pid + "'";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            // OracleDataReader dr = cmd.ExecuteReader();
            // dr.Read();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            string id = count.ToString();
            return id;
        }
        public string getemail(string id)
        {
            //int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select email from ecare_user where id='" + id + "'";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
          OracleDataReader dr = cmd.ExecuteReader();
            // dr.Read();
            dr.Read();
            string ids = dr.GetString(0);
            return ids;
        }
        public string getmessageiddoctor(string patientid)
        {
            //int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(id) from ECARE_Message where recieverid='" + Data.docid + "'";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            // OracleDataReader dr = cmd.ExecuteReader();
            // dr.Read();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            string id = count.ToString();
            return id;
        }
    
        public int searchuser(string username, string password,int type)
        {
           // int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(id) from ECARE_USER where username='"+username+"' and password='"+password+"' and usertype="+type+"";
            int count = Convert.ToInt32(cmd.ExecuteScalar());
          //  OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int checkuser(string uname)
        {
            // int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(id) from ECARE_USER where username='" + uname + "'";
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            //  OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int checkemail(string email)
        {
            // int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(id) from ECARE_USER where email='" + email + "'";
            int count = Convert.ToInt32(cmd.ExecuteScalar());


            conn.Dispose();
            return count;
        
        }
        public string getidfromnotifications(string patientid,string notificationid)
        {
            // int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select doctorid from ECARE_notifications where id='" + notificationid + "' and patientid='"+patientid+"'";
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string s = dr.GetString(0);
            conn.Dispose();
            return s;
        }
        public string getdocname(string id)
        {
            // int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select fullname from ECARE_DOCTOR where id='" + id + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string s=dr.GetString(0);
            conn.Dispose();
            return s;
        }
        public string getdocidreference(string un)
        {
            // int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select id from ECARE_DOCTOR where username='" + un + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string s = dr.GetString(0);
            conn.Dispose();
            return s;
        }
        public string insertnotifications(string id,string patientid,string doctorid,string message,string time)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into ecare_notifications values ('" + id + "','"+patientid+"','"+doctorid+"','"+message+"','"+time+"')";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
          //  dr.Read();
            //string name = dr.GetString(0);
            conn.Dispose();
            return "done";
        }
        public string insertuserverification(string id, string refid,int status)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into ecare_userverification values ('" + id + "','" + refid + "',"+status+")";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            //  dr.Read();
            //string name = dr.GetString(0);
            conn.Dispose();
            return "done";
        }
        public string countnotifications(string patientid)
        {
            
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(id) from ECARE_Notifications where patientid='" + patientid + "'";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            // OracleDataReader dr = cmd.ExecuteReader();
            // dr.Read();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            string id = count.ToString();
            conn.Dispose();
            return id;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
   
        }
        public string getnamepatient(string patientid)
        {
            //int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select fullname from ECARE_patient where id='" + patientid + "'";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string name = dr.GetString(0);
            conn.Dispose();
            return name;
        }
        public void insertuser(string id,string email,string password,string username,int usertypes)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into ecare_user values('" + id + "','" + email + "','" + password + "','" + username + "'," + usertypes + ")";
            OracleDataReader dr = cmd.ExecuteReader();
        }
        public void insertpatient(string id, string fullname, string bloodgroup, string district, string sex, string birthdate, string contactnumber, int contactnumbertype)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into ecare_patient values('" + id + "','" + fullname + "','" + bloodgroup + "','" + district + "','" + sex + "','" + birthdate + "','" + contactnumber + "', " + contactnumbertype + " )";
            OracleDataReader dr = cmd.ExecuteReader();
        }
        public void insertdoctor(string id, string fullname, string speciality, string workingon, string workingas, string degree,string district, string chamberaddress, string contactnumber, int cntyp, string sex)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into ecare_doctor values('" + id + "','" + fullname + "','" + speciality + "','" + workingon + "','" + workingas + "','" + degree + "','" + district + "','" + chamberaddress + "','" + contactnumber + "'," + cntyp + ",'" + sex + "')";
            OracleDataReader dr = cmd.ExecuteReader();
        }
        public void insertappointment(string id, string doctorid, string patientid, string appointmenttime, int appointmentstatus, string appointmentdate,string appointmentday)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into ecare_appointment values('" + id + "','" + doctorid + "','" + patientid + "','" + appointmenttime + "'," + appointmentstatus + ",'" + appointmentdate + "','" + appointmentday + "' )";
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            conn.Dispose();
        }
        public void insertappointmentinfo(string id, string workingtimestart,string workingtimeend, int limit, int saturday,int sunday,int monday,int tuesday,int wednesday,int thursday,int friday,int appointmentsystem)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into ecare_appointmentinfo values('" + id + "','" + workingtimestart + "','" + workingtimeend + "'," + limit + "," + saturday + "," + sunday + "," + monday + "," + tuesday + "," + wednesday + "," + thursday + "," + friday + "," + appointmentsystem + ")";
            OracleDataReader dr = cmd.ExecuteReader();
        }
        public void insertassistant(string id, string password,string email)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into ecare_assistant values('" + id + "','" + password + "','" + email + "' )";
            OracleDataReader dr = cmd.ExecuteReader();
        }
        public void insertmessagedoctor(string id, string senderid, string recieverid, string sender, string reciever, string subject, string body, string messagetime)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into ecare_message values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + reciever + "','" + subject + "','" + body + "','" + messagetime + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            conn.Dispose();
        }
        public void insertmessagepatient(string id, string senderid, string recieverid, string sender, string reciever, string subject, string body, string messagetime)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into ecare_message values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + reciever + "','" + subject + "','" + body + "','" + messagetime + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            conn.Dispose();
        }
        public void insertprescription(string id, string senderid, string recieverid,string docname, string body, string issuedate,int status)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into ecare_prescription values('" + id + "','" + senderid + "','" + recieverid + "','" + docname + "','" + body + "','" + issuedate + "'," + status + ")";
            OracleDataReader dr = cmd.ExecuteReader();
            conn.Dispose();
        }
        public void updateuser(string id,string email, string password)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update ecare_user set password='"+password+"',email='"+email+"' where id='"+id+"'";
            OracleDataReader dr = cmd.ExecuteReader();
            conn.Dispose();
        }
        public void updatedoctor(string id, string fullname, string speciality, string workingon, string workingas, string degree, string district,string chamberaddress,string contactnumber)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update ecare_doctor set fullname='" + fullname + "',speciality='" + speciality+ "',workingon='" + workingon + "',workingas='" + workingas + "',degree='" + degree + "',district='" + district + "',chamberaddress='" + chamberaddress + "',contactnumber='" + contactnumber + "' where id='" + id + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            conn.Dispose();
        }
        public void updatepatient(string id, string fullname,string district, string bloodgroup,string contactnumber)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update ecare_patient set fullname='" + fullname + "',district='" + district + "',contactnumber='" + contactnumber + "',bloodgroup='"+bloodgroup+"' where id='" + id + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            conn.Dispose();
        }
        public void updateappointmentinfo(string id, int monday,int tuesday,int wednesday,int thursday,int friday,int saturday,int sunday,int val)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update ecare_appointmentinfo set monday=" + monday + ",tuesday=" + tuesday + ",wednesday=" + wednesday + ",thursday=" + thursday + ",friday=" + friday + ",saturday=" + saturday + ",sunday=" + sunday + ",appointmentsystem=" + val + " where id='" + id + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            conn.Dispose();
        }

        public void updateverification(string id, string verificationid, int value)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update ecare_userverification set status="+value+" where id='"+id+"'";
            //     cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
        //    dr.Read();
            conn.Dispose();
        }
        public void updateinfouser(string id, string type, string value)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
       //     cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
        }
        public void updateinfodoctor(string id, string type, string value)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
        //    cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
        }
        public void updateinfopatient(string id, string type,string value)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
        //    cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
        }
        public void updateinfoappointment(string id, string type, string value)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
       //     cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
        }
        public void updateinfoappointmentinfo(string id, string type, string value)
        {
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
         //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
        }

        public int logindb(string email, string password)
        {
            int count=0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int checkappointment(string doctorid, string patientid,string date)
        {
           // int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select count(id) from ECARE_APPOINTMENT where id='"+date+"' and doctorid='"+doctorid+"' and patientid='"+patientid+"'";
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            //  OracleDataReader dr = cmd.ExecuteReader();
            conn.Dispose();
            return count;
        }
    
        public int searchdoctor(string speciality, string district)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int updateappointment(string id,string doctorid,string patientid,int appstatus)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "update ecare_appointment set appointmentstatus="+appstatus+" where patientid='" + patientid + "' and doctorid='" + doctorid + "' and appointmentdate='"+id+"'";
            OracleDataReader dr = cmd.ExecuteReader();
            conn.Dispose();
            return count;
            
        }
        public int searchpatient(string speciality, string district)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int inboxlist(string speciality, string district)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int messagedetails(string speciality, string district)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int prescriptionlist(string speciality, string district)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int prescriptiondetails(string speciality, string district)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int appointmentlist(string speciality, string district)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int doctordetails(string speciality, string district)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int patientdetails(string speciality, string district)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int notificationslist(string speciality, string district)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int askquestionsdetails(string speciality, string district)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int askquestionslist(string speciality, string district)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            return count;
        }
        public int articlelist(string speciality, string district)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            conn.Dispose();
            return count;
        }
        public int articledetails(string speciality, string district)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            //   cmd.CommandText = "insert into ecare_patient values('" + id + "','" + senderid + "','" + recieverid + "','" + sender + "','" + body + "','" + issuedate + "')";
            OracleDataReader dr = cmd.ExecuteReader();
            conn.Dispose();
            return count;
        }
        public int saturday(string id)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select saturday from ecare_appointmentinfo where id='" + id + "'";
            count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;
        }
        public int sunday(string id)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select sunday from ecare_appointmentinfo where id='" + id + "'";
         //   OracleDataReader dr = cmd.ExecuteReader();
            // dr.Read();

            count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;
        }
        public int monday(string id)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select monday from ecare_appointmentinfo where id='" + id + "'";
            count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;
        }
        public int tuesday(string id)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select tuesday from ecare_appointmentinfo where id='" + id + "'";
            count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;
        }
        public int wednesday(string id)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select wednesday from ecare_appointmentinfo where id='" + id + "'";
            count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;
        }
        public int thursday(string id)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select thursday from ecare_appointmentinfo where id='" + id + "'";
            count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;
        }
        public int friday(string id)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select friday from ecare_appointmentinfo where id='" + id + "'";
            count = Convert.ToInt32(cmd.ExecuteScalar());
            conn.Dispose();
            return count;
          
        }
        public int updateprescription(string patid,string preid)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update ecare_prescription set status=1 where patientid='" + patid + "' and id='"+preid+"'";
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            conn.Dispose();
            return count;

        }
        public int deleteprescription(string patid, string preid)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "delete from ecare_prescription where patientid='" + patid + "' and id='" + preid + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            conn.Dispose();
            return count;

        }
        public string getspeciality(string doctorid)
        {
            int count = 0;
            string oradb = "Data Source=localhost;User Id=system;Password=965720;";
            OracleConnection conn = new OracleConnection(oradb);  // C#
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select speciality from ecare_doctor where id='" + doctorid + "'";
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();
            string speciality = dr.GetString(0);
            conn.Dispose();
            return speciality;

        }

    }
}