<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Submit1 {
            height: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
&nbsp;<p>
            Name&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Email&nbsp;
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            ID&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            Cources</p>
        <p>
            <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="C" />
&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox2" runat="server" Text="C#" />
&nbsp;&nbsp;
            <asp:CheckBox ID="CheckBox3" runat="server" Text="C++" />
        </p>
        <p>
            Gender<asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
        </p>
        <p>
            &nbsp;</p>
        Description<br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
        <asp:Label ID="Label8" runat="server"></asp:Label>
        <asp:Label ID="Label9" runat="server"></asp:Label>
        <br />
        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
        <br />
        <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
    </form>
    
</body>
</html>
