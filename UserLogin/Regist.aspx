。<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regist.aspx.cs" Inherits="UserLogin.Regist" %>

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
                    <h1>用户注册</h1>
                </div>
                <div class="form-inline">
                    <asp:Label Text="用&nbsp;&nbsp;户&nbsp;&nbsp名：" runat="server" CssClass="control-label" />
                   <asp:TextBox ID="txtName" runat="server" CssClass="form-control" AutoPostBack="True" OnTextChanged="txtName_TextChanged1"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="用户名不能为空" ControlToValidate="txtName" CssClass="text-danger"></asp:RequiredFieldValidator>
                </div>
                <br />
                <div class="form-inline">
                    <asp:Label Text="密 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp码：" runat="server" CssClass="control-label" />
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能为空！" CssClass="text-danger" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
                </div>
                <br />
                <div class="form-inline">
                    <asp:Label Text="确认密码：" runat="server" CssClass="control-label" />
                    <asp:TextBox ID="txtPassword2" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="确认密码不能为空！" CssClass="text-danger" ControlToValidate="txtPassword2"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" CssClass="text-danger" runat="server" ErrorMessage="俩次输入密码不一致！" ControlToCompare="txtPassword" ControlToValidate="txtPassword2"></asp:CompareValidator>
                </div>
                <br />
                <div class="form-inline">
                    <asp:Label Text="性&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;别：" runat="server" CssClass="control-label" />
                    <asp:DropDownList ID="dropSex" runat="server" CssClass="form-control">
                        <asp:ListItem Selected="True">男</asp:ListItem>
                        <asp:ListItem >女</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <br />
                <div class="form-inline">
                    <asp:Label Text="出生日期：" runat="server" CssClass="control-label" />
                    <asp:TextBox ID="txtDate" runat="server" CssClass="form-control" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="出生日期不能为空！" CssClass="text-danger" ControlToValidate="txtDate"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" CssClass="text-danger" runat="server" ErrorMessage="日期不符合格式" ControlToValidate="txtDate" ValidationExpression="^((\d{2}(([02468][048])|([13579][26]))[\-\/\s]?((((0?[13578])|(1[02]))[\-\/\s]?((0?[1-9])|([1-2][0-9])|(3[01])))|(((0?[469])|(11))[\-\/\s]?((0?[1-9])|([1-2][0-9])|(30)))|(0?2[\-\/\s]?((0?[1-9])|([1-2][0-9])))))|(\d{2}(([02468][1235679])|([13579][01345789]))[\-\/\s]?((((0?[13578])|(1[02]))[\-\/\s]?((0?[1-9])|([1-2][0-9])|(3[01])))|(((0?[469])|(11))[\-\/\s]?((0?[1-9])|([1-2][0-9])|(30)))|(0?2[\-\/\s]?((0?[1-9])|(1[0-9])|(2[0-8]))))))(\s(((0?[1-9])|(1[0-2]))\:([0-5][0-9])((\s)|(\:([0-5][0-9])\s))([AM|PM|am|pm]{2,2})))?$" Display="Dynamic"></asp:RegularExpressionValidator>
                </div>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label Text="" ID="lblMes" runat="server" CssClass="text-danger" />
                <br />
                <br />

                <div class="form-inline">
                   &nbsp;&nbsp;&nbsp;&nbsp   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button Text="确定" runat="server" ID="btnRegist" CssClass="btn btn-primary" OnClick="btnRegist_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:HyperLink ID="HyperLink1" runat="server" CssClass="btn btn-danger" NavigateUrl="~/Login.aspx">返回</asp:HyperLink>

                </div>

            </div>
        </div>
    </form>
</body>
</html>
