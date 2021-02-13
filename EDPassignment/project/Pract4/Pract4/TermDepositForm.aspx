<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TermDepositForm.aspx.cs" Inherits="Pract4.TermDepositForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Create Term Deposit</h3>
    <table class="table">
        <tr>
            <td class="auto-style1" style="width: 165px">Customer Id:</td>
            <td>
                <asp:Label ID="lbCustId" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 165px">Customer Name:</td>
            <td>
                <asp:Label ID="Label1" runat="server" Text=" "></asp:Label>
                <asp:Label ID="lbCustname" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 165px">New TD Account:</td>
            <td>
                <asp:TextBox ID="tbNewAcno" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 165px">Principal (S$) :</td>
            <td>

                <asp:TextBox ID="tbPrincipal" runat="server"></asp:TextBox>
                &nbsp;<asp:Label ID="lbErr1" ForeColor="Red" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 165px">Term (months): </td>
            <td>
                <asp:DropDownList ID="ddlTerm" runat="server" OnSelectedIndexChanged="ddlTerm_SelectedIndexChanged">
                </asp:DropDownList>&nbsp;<asp:Label ID="lbErr2" ForeColor="Red" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 165px">Interest Rate (%) :</td>
            <td>
                <asp:Label ID="lbRate" runat="server"></asp:Label>
            </td>
        </tr>

        <tr>
            <td class="auto-style1" style="width: 165px">Maturity Date :</td>
            <td>
                <asp:Label ID="lbMaturedDate" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 165px">Interest Earned (S$):</td>
            <td>
                <asp:Label ID="lbInterest" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 165px">Matured Amount P+I (S$):</td>
            <td>
                <asp:Label ID="lbMaturedAmt" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 165px; height: 39px">TD Renewal Mode :</td>
            <td style="height: 39px">
                <asp:DropDownList ID="ddlRenew" runat="server" OnSelectedIndexChanged="ddlTerm_SelectedIndexChanged">
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 165px">&nbsp;</td>
            <td>
                <asp:Button ID="btnConfirm" runat="server" Text="Confirm" OnClick="btnConfirm_Click" />&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 165px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 165px">&nbsp;</td>
            <td>
                <asp:Label ID="lbResult" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>