<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtinput1" runat="server" ontextchanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ControlToValidate="txtinput1" ErrorMessage="RegularExpressionValidator" 
            ValidationExpression="^[0-9]"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ControlToValidate="txtinput1" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    
    </div>
    <asp:TextBox ID="txtinput2" runat="server" ontextchanged="TextBox2_TextChanged"></asp:TextBox>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
        ControlToValidate="txtinput2" ErrorMessage="RegularExpressionValidator" 
        ValidationExpression="^[0-9]"></asp:RegularExpressionValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
        ControlToValidate="txtinput2" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
    <br />
    <asp:Button ID="btnaddition" runat="server" onclick="Button1_Click" 
        Text="Addition" />
    <asp:Button ID="btnsub" runat="server" onclick="btnsub_Click" 
        Text="Subtraction" />
    <asp:Button ID="btnmul" runat="server" onclick="btnmul_Click" 
        Text="Multipication" />
    <asp:Button ID="btndiv" runat="server" onclick="btndiv_Click" Text="Division" />
    <br />
    <asp:Label ID="lblans" runat="server" Text="Answer"></asp:Label>
    </form>
</body>
</html>
