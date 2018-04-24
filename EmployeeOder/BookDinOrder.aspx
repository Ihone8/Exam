<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookDinOrder.aspx.cs" Inherits="员工订餐.BookDinList" %>

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
                <h1 class="text-center">员工订餐</h1>
            </div>
            <div class="col-lg-offset-4">
                <h3>订餐人：
                    <asp:Label runat="server" ID="lblName"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    工  号：
                    <asp:Label runat="server" ID="lblNo"></asp:Label>
                </h3>
                <br />
                <br />
                <div class="form-inline row">
                    <asp:Label Text="开始时间：" runat="server" />
                    <asp:TextBox ID="txtStartTime" CssClass="form-control" runat="server" Enabled="false"></asp:TextBox>
                </div>
                <br />

                <div class="form-inline row">
                    
                    <asp:Label Text="结束时间：" runat="server" />
                    <asp:TextBox ID="txtEndTime" CssClass="form-control" runat="server"></asp:TextBox>
                </div>
                <br />
                <div>
                      <asp:Label Text="&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;" runat="server" />
                    <asp:Button ID="btnOrder" runat="server" Text="预定" CssClass="btn btn-success" OnClick="btnOrder_Click" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
