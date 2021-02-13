<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserSignUp.aspx.cs" Inherits="Pract4.UserSignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

     <div>
    <h3>Create Facility</h3>
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
                <asp:Button ID="btnSignUp" runat="server" OnClick="btnAdd_Click" Text="SignUp" Width="77px" />
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
        <asp:GridView ID="gvUserInfo" runat="server" AutoGenerateColumns="False" CellPadding="0" CssClass="myDatagrid">
            <Columns>
                <asp:BoundField DataField="UserID" HeaderText="UserID" ReadOnly="True" />
                <asp:BoundField DataField="Password" HeaderText="Password" ReadOnly="True" />
                <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" />
                <asp:BoundField DataField="Dob" HeaderText="Date" ReadOnly="True" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="Contact" HeaderText="Contact" ReadOnly="True" />
                <asp:BoundField DataField="Email" HeaderText="Email" ReadOnly="True" />
                <asp:BoundField DataField="Country" HeaderText="Country" ReadOnly="True" />
                <asp:BoundField DataField="City" HeaderText="City" ReadOnly="True" />
                <asp:BoundField DataField="Postalcode" HeaderText="Postalcode" ReadOnly="True" />
                
            </Columns>
        </asp:GridView>
</asp:Content>
