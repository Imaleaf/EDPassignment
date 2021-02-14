<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserSignUp.aspx.cs" Inherits="Pract4.UserSignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div>
    <h3>Registration</h3>
    <table style="width:100%;">
        <tr>
            <td class="auto-style1" style="width: 134px">UserID:</td>
            <td>
                <asp:TextBox ID="TbUserID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px; height: 22px;">Password:</td>
            <td style="height: 22px">
                <asp:TextBox ID="TbPW" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Name:</td>
            <td>
                <asp:TextBox ID="TbName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Date of Birth:</td>
            <td>
                <asp:TextBox ID="TbDOB" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Contact:</td>
            <td>
                <asp:TextBox ID="TbNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Email:</td>
            <td>
                <asp:TextBox ID="TbEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Country:</td>
            <td>
                <asp:DropDownList ID="DropDownList" runat="server" Width="154px">
                    <asp:ListItem Selected="True" Value="0">- Select -</asp:ListItem>
                    <asp:ListItem Value="Sg">Singapore</asp:ListItem>
                    <asp:ListItem Value="My">Malaysia</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px; height: 22px;">City:</td>
            <td style="height: 22px">
                <asp:TextBox ID="TbCity" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Postalcode:</td>
            <td>
                <asp:TextBox ID="Tbpostal" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>
                <asp:Button ID="btnSignUp" runat="server" OnClick="btnAdd_Click" Text="Register" Width="77px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>
                <asp:Label ID="lbMsg" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
    </div>
        
</asp:Content>
