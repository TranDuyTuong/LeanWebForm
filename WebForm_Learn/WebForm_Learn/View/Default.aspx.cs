using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForm_Learn.ConnectionDatabase;

namespace WebForm_Learn
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var Db = new ManagerMusicDatabaseEntities();
            var City = Db.Citys.ToList();


        }

        [WebMethod]
        [ScriptMethod(UseHttpGet = true)]
        public static string Login(string Email, string Password)
        {
            string Notifi;
            string UserName = "duytuong@gmail.com";
            string PasswordDefaul = "Tuong123$";
            if (Email == UserName && Password == PasswordDefaul)
            {
                Notifi = "Login Success";
            }
            else
            {
                Notifi = "Login Faild";
            }
            return Notifi;
        }

        protected void Btn_Login_Click(object sender, EventArgs e)
        {
            string Email = "duytuong0503@gmail.com";
            string Password = "Duytuong123$";
            if(TxtEmail_1.Text == "")
            {
                LblNotifi.Text = "Vui lòng nhập Email";
            }
            else if(TxtPassword_1.Text == "")
            {
                LblNotifi.Text = "Vui lòng nhập password";
            }
            else
            {
                if(TxtEmail_1.Text == Email && TxtPassword_1.Text == Password)
                {
                    LblNotifi.Text = "Đăng nhập thành công!";
                }
                else
                {
                    LblNotifi.Text = "Sai Tài Khoản hoặc mật khẩu!";
                }
            }
            return;
        }
    }
}