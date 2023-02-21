using System;
using System.Linq;
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