<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PremiumTest.aspx.cs" Inherits="SQAssign1Web.PremiumTest" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <br/><br/><br/>
            <asp:TextBox ID="ageTB" placeholder="Age" runat="server" Width="52px"></asp:TextBox>

            <asp:DropDownList ID="genderDDL" runat="server">
                <asp:ListItem>female</asp:ListItem>
                <asp:ListItem>male</asp:ListItem>
                <asp:ListItem>other</asp:ListItem>
            </asp:DropDownList>

        </div>
        <div style="text-align: center">
            <br/>   
            <asp:Button ID="submitBtn" runat="server" Text="Submit" OnClick="submitBtn_Click" />
            <p>
                <asp:Label ID="label1" runat="server">Premium: </asp:Label>
                <asp:Label ID="outputLabel" runat="server" Text=""></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
