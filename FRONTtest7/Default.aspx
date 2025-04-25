<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FRONTtest7.Default" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Usernames</title>
 <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
            
        <p>
            <asp:TextBox ID="txtNewUsername" runat="server" Placeholder="Enter new username" CssClass="input-box" />
            <asp:Button ID="btnAddUser" runat="server" Text="Add User" OnClick="btnAddUser_Click" CssClass="add-button" Height="45px" Width="139px"/>

        </p>

        <div>
            <asp:Button ID="btnFetchUsers" runat="server" Text="Show Users" OnClick="btnFetchUsers_Click" Height="45px" Width="139px" />
        </div>
        <div style="margin-top: 10px;">
            <asp:Button ID="btnRemoveUsers" runat="server" Text="Hide Users" OnClick="btnRemoveUsers_Click" CssClass="remove-button" Height="45px" Width="139px"  />

        </div>

        <p>
            <asp:Label ID="lblUsernames" runat="server" Text="Usernames will appear here!" />
        </p>
    <asp:GridView ID="GridViewUsers" runat="server" />

    </form>
</body>
</html>