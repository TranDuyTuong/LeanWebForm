<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebForm_Learn.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng Nhập</title>
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="container">
                <div class="col-md-12">
                    <div class="row">

                        <div class="mb-3">
                            <label class="form-label">Email address</label>
                            <asp:TextBox CssClass="form-control" ID="TxtEmail" runat="server"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label class="form-label">Password</label>
                            <asp:TextBox CssClass="form-control" ID="TxtPassword" runat="server"></asp:TextBox>
                        </div>
                        <asp:Button CssClass="btn btn-primary" ID="Btn_Login" OnClick="Login_Data" runat="server" Text="Submit" />
                        <asp:Label ID="ErrorNotifi" runat="server" Text=""></asp:Label>
                    </div>
                </div>
                <br />
            </div>
            <%--<script src="../MyJavascript/LoginJS.js"></script>--%>
        </div>
    </form>
</body>
</html>
