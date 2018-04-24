<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UserLogin.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <link href="bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="col-lg-8 col-lg-offset-2">
                <div class="page-header">
                    <h1>用户登入</h1>
                </div>
                <div class="form-inline">
                    <asp:Label Text="用户名：" runat="server" CssClass="control-label" />
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户名不能为空" ControlToValidate="txtName" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <br />
                <div class="form-inline">
                    <asp:Label Text="密 &nbsp;&nbsp;&nbsp;码：" runat="server" CssClass="control-label" />
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空！" CssClass="text-danger" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </div>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label Text="" ID="lblMes" runat="server" CssClass="text-danger" />
                <br />
                <br />
                
                <div class="form-inline">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button Text="登入" runat="server" ID="btnLogin" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl="~/Regist.aspx">注册</asp:HyperLink>

                </div>

            </div>
        </div>
    </form>
</body>
</html>
