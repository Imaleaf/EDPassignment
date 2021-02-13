<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TDUpdateForm.aspx.cs" Inherits="Pract4.TDUpdateForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Update Term Deposit</h3>
    <table class="table">
        <tr>
            <td class="modal-sm" style="width: 151px">Customer Id: :</td>
            <td>
                <asp:Label ID="lbCustId" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 151px">Customer Name :</td>
            <td>
                <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
                <asp:Label ID="lbCustname" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 151px">TD Account:</td>
            <td>
                <asp:Label ID="lbAcc" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 151px">Principal (S$) :</td>
            <td>

                <asp:Label ID="lbPrincipal" runat="server"></asp:Label>
                   
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 151px">Maturity Date :</td>
            <td>
                <asp:Label ID="lbMaturedDte" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 151px">P+I (S$):</td>
            <td>
                <asp:Label ID="lbMaturedAmt" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 151px">TD Renewal Mode :</td>
            <td>
                <asp:DropDownList ID="ddlRenew" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="-1">--Select--</asp:ListItem>
                    <asp:ListItem Value="1">Renew P+I</asp:ListItem>
                    <asp:ListItem Value="2">Renew P</asp:ListItem>
                    <asp:ListItem Value="3">Not renewing</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 151px">&nbsp;</td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" style="height: 26px"  />&nbsp;&nbsp;
                <asp:Button ID="btnBack" runat="server" OnClick="btnBack_Click" Text="Back" />
            </td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 151px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="modal-sm" style="width: 151px">&nbsp;</td>
            <td>
                <asp:Label ID="lbResult" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>
