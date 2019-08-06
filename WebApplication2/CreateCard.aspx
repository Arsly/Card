<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateCard.aspx.cs" Inherits="WebApplication2.CreateCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Create a Business Card</h1>
            <asp:Label ID="lblCardText" runat="server" Text="Card Text" AssociatedControlID="txtCardText"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
