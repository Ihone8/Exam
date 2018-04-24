<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeSearch.aspx.cs" Inherits="Employee.EmployeeSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnAdd" runat="server" Text="添加员工" OnClick="btnAdd_Click" />
            <br />
            <br />
            <br />
            <asp:GridView ID="Employees" runat="server" AllowPaging="True" AutoGenerateColumns="False"  CellPadding="4" ForeColor="#333333" GridLines="None" style="text-align:center;" OnPageIndexChanging="Employees_PageIndexChanging" PageSize="8">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="姓名" ItemStyle-Width="100" />
                    <asp:BoundField DataField="Age" HeaderText="年龄" ItemStyle-Width="100"/>
                    <asp:BoundField DataField="Sex" HeaderText="性别" ItemStyle-Width="100"/>
                    <asp:BoundField DataField="DepartmentName" HeaderText="部门名称" ItemStyle-Width="100"/>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
