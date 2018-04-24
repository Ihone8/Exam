<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeAdd.aspx.cs" Inherits="Employee.EmployeeAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="page-header">
                <h1>添加员工信息</h1>
            </div>         
                <div class="form-inline row">
                    <asp:Label ID="lblName" runat="server" Text="姓 名:" CssClass="col-lg-1 control-label "></asp:Label>
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control col-lg-6"></asp:TextBox>
                    <asp:Label ID="lblNameMes" runat="server" Text="" CssClass="col-lg-5 control-label "></asp:Label>
                </div>
            <br />
            <div class="form-inline row">
                    <asp:Label ID="Label1" runat="server" Text="年 龄:" CssClass="col-lg-1 control-label"></asp:Label>
                    <asp:TextBox ID="txtAge" runat="server" CssClass="form-control col-lg-6"></asp:TextBox>
                <asp:Label ID="lblAgeMes" runat="server" Text="" CssClass="col-lg-5 control-label "></asp:Label>
               
               
                </div>
            <br />
            <div class="form-inline row">
                <asp:Label ID="Label2" runat="server" Text="性 别:" CssClass="col-lg-1 control-label"></asp:Label>
                <asp:RadioButton ID="RdMan" runat="server"  GroupName="Sex"  Checked="true"/> 男
                <asp:RadioButton ID="RdWoMan" runat="server"  GroupName="Sex" /> 女
             </div>
             <br />
            <div class="form-inline row">
                <asp:Label ID="Label3" runat="server" Text="部 门:" CssClass="col-lg-1 control-label"></asp:Label>
                <asp:DropDownList ID="DepartmentList" runat="server" CssClass="form-control " Width="200" >
                   
                </asp:DropDownList>
               
            </div>
             <asp:Label ID="lblDepartment" runat="server" Text="" CssClass="col-lg-5 control-label  col-lg-offset-1" ></asp:Label>
            <br />
             <br />
            <asp:Button Text="添加" ID="btnSearch" CssClass="btn btn-primary" Width="200" style="margin-left:80px;" runat="server" OnClick="btnSearch_Click"  />
        </div>
    </form>
</body>
</html>
