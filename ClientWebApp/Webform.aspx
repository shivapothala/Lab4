<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Webform.aspx.cs" Inherits="Webform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
            <asp:Label ID="Label4" runat="server" Text="This is a simple Calculator!! Please enter the numbers" style="font-weight: 700"></asp:Label>
    
    </div>
        <p>
    
        <asp:Label ID="Label1" runat="server" Text="Input1"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Input2"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Substract" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Multiply" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Divide" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Result"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="See Source Code in the below Link"></asp:Label>
        </p>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" style="text-decoration: underline; font-weight: 700">https://github.com/shivapothala/Lab4</asp:HyperLink>
        </p>
    </form>
</body>
</html>
