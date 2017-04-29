<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 109px;
        }
    </style>
</head>
<body>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:TextBox ID="TextBox1" runat="server" Height="21px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Hacer la operacion" />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" style="margin-bottom: 0px">
            <asp:ListItem>Suma</asp:ListItem>
            <asp:ListItem Value="Resta"></asp:ListItem>
            <asp:ListItem Value="Multiplicacion"></asp:ListItem>
            <asp:ListItem Value="divisiones">divisiones</asp:ListItem>
        </asp:DropDownList>
        <br/>
        <asp:Label ID="Label4" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Hacerel pino" />
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem>+</asp:ListItem>
            <asp:ListItem>*</asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
