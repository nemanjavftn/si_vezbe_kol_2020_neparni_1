<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="books.aspx.cs" Inherits="WebApplication1.books" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
        <asp:Label ID="Label2" runat="server" Text="Author"></asp:Label>
        <asp:TextBox ID="tbAuthor" runat="server"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="Year"></asp:Label>
        <asp:TextBox ID="tbYear" runat="server"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="Potvrdi" OnClick="btnSubmit_Click" />
        <asp:ListBox ID="ListBoxBooks" runat="server"></asp:ListBox>
    </form>
</body>
</html>
