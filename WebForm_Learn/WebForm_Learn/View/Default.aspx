<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm_Learn._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <div class="col-md-12">
            <div class="row">

                        <div class="mb-3">
                            <label class="form-label">Email address</label>&nbsp;
                            <input type="email" class="form-control" id="TxtEmail" placeholder="Enter Email" />
                        </div>
                        <div class="mb-3">
                            <label class="form-label">Password</label>&nbsp;
                            <input type="password" class="form-control" id="TxtPassword" placeholder="Enter Password" />
                        </div>
                        <asp:Button CssClass="btn btn-primary" ID="Btn_LoginAjax" runat="server" Text="Submit" />

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
            <asp:Button CssClass="btn btn-primary" ID="Btn_Login" runat="server" Text="Submit" />
            <asp:Label ID="LblNotifi" runat="server"></asp:Label>
        </div>
    </div>
    <script src="../Scripts/jquery-3.4.1.min.js"></script>
    <script src="../MyJavascript/DefaultJS.js"></script>
</asp:Content>
