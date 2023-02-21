using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm_Learn.Model;

namespace WebForm_Learn.View
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        [System.Web.Services.WebMethod]
        public Login_M Login_v(string Email, string Password)
        {
            var InfoLogin = new InfoLogin_M();
            var Notifi = new Login_M();
            string UserName = "duytuong@gmail.com";
            string PasswordDefaul = "Tuong123$";
            if (Email == UserName && Password == PasswordDefaul)
            {
                InfoLogin.Email = Email;
                InfoLogin.Password = Password;
                Session["Infomation"] = InfoLogin;
                Notifi.Id = 1;
                Notifi.Message = "/View/Index.aspx";
            }
            else
            {
                Notifi.Id = 2;
                Notifi.Message = "Login Faild";
            }
            return Notifi;
        }

        protected void Login_Data(object sender, EventArgs e)
        {
            var InfoLogin = new InfoLogin_M();
            var Notifi = new Login_M();
            string UserName = "duytuong@gmail.com";
            string PasswordDefaul = "Tuong123$";
            if (TxtEmail.Text == UserName && TxtPassword.Text == PasswordDefaul)
            {
                InfoLogin.Email = TxtEmail.Text;
                InfoLogin.Password = TxtPassword.Text;
                Session["Infomation"] = InfoLogin;
                Response.Redirect("Index.aspx");
            }
            else
            {
                ErrorNotifi.Text = "Login Fail";
            }
        }
    }
}