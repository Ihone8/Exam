<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="员工订餐.Login" %>

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
            <div class="page-header">
                <h1>用户登入</h1>
            </div>
            <div class="form-inline">
                账 号：
             <asp:TextBox ID="txtName" runat="server" Text="001"  CssClass ="form-control"></asp:TextBox>
            </div>
            <br />
            <div class="form-inline">
                密 码：
             <asp:TextBox TextMode="Password" ID="txtPassword" Text="123456" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Label ID="lblMes" runat="server" Text=""></asp:Label>
            <br />
            <div class="form-inline">
                <asp:Button ID="btnLogin" runat="server" Text="登入" CssClass="btn btn-primary " Style="margin-left: 48px;" OnClick="btnLogin_Click" />
            </div>
        </div>
    </form>
</body>
</html>
