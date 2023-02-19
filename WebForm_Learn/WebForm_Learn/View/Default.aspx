<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm_Learn._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-12">
            <div class="row">
                <p>Nhập Thông Tin Đăng Nhập</p>
                <div>
                    <div class="mb-3">
                        <label class="form-label">Email address</label>
                        <input type="email" class="form-control" id="TxtEmail" placeholder="Enter Email" />
                        <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
                    </div>
                    <div class="mb-3">
                        <label class="form-label">Password</label>
                        <input type="password" class="form-control" id="TxtPassword" placeholder="Enter Password" />
                    </div>
                    <div class="mb-3 form-check">
                        <input type="checkbox" class="form-check-input" id="exampleCheck1">
                        <label class="form-check-label" for="exampleCheck1">Check me out</label>
                    </div>
                    <button class="btn btn-primary" onclick="Btn_Login()">Submit</button>
                </div>
            </div>
            <br />
            <br />
            <p>Test Code C#</p>
            <div>
                <div class="mb-3">
                    <label class="form-label">Email address</label>
                    <asp:TextBox CssClass="form-control" ID="TxtEmail_1" runat="server"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label class="form-label">Password</label>
                    <asp:TextBox CssClass="form-control" ID="TxtPassword_1" runat="server"></asp:TextBox>
                </div>
                <asp:Button CssClass="btn btn-primary" ID="Btn_Login" runat="server" Text="Submit" OnClick="Btn_Login_Click" />
                <asp:Label ID="LblNotifi" runat="server" ></asp:Label>
            </div>
            <asp:BulletedList ID="BulletedList1" runat="server">
            </asp:BulletedList>
        </div>
    </div>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <script src="../Scripts/WebForms/MSAjax/MicrosoftAjax.js"></script>
    <script src="../MyJavascript/DefaultJS.js"></script>
</asp:Content>
