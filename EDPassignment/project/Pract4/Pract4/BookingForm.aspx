<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookingForm.aspx.cs" Inherits="Pract4.BookingForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <h3>Create Facility</h3>
    <table style="width:100%;">
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Facility ID:</td>
            <td>
                <asp:TextBox ID="tbFacilityID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Facility name:</td>
            <td>
                <asp:TextBox ID="tbFacilityName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Sport:</td>
            <td>
                <asp:DropDownList ID="ddlSport" runat="server" Width="154px">
                    <asp:ListItem Selected="True" Value="0">- Select -</asp:ListItem>
                    <asp:ListItem Value="Table Tennis">Table Tennis</asp:ListItem>
                    <asp:ListItem Value="Tennis">Tennis</asp:ListItem>
                    <asp:ListItem Value="Badminton">Badminton</asp:ListItem>
                    <asp:ListItem Value="Soccer">Soccer</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Date:</td>
            <td>
                <asp:TextBox ID="tbDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Duration:</td>
            <td>
                <asp:DropDownList ID="ddlDuration" runat="server" Width="154px">
                    <asp:ListItem Selected="True" Value="0">- Select -</asp:ListItem>
                    <asp:ListItem Value="1 Hour">1 hour</asp:ListItem>
                    <asp:ListItem Value="2 Hour">2 hour</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Price ($):</td>
            <td>
                <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="77px" />
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
        <asp:GridView ID="gvBooking" runat="server" AutoGenerateColumns="False" CellPadding="0" CssClass="myDatagrid">
            <Columns>
                <asp:BoundField DataField="FacilityID" HeaderText="Facility ID" ReadOnly="True" />
                <asp:BoundField DataField="FacilityName" HeaderText="Facility Name" ReadOnly="True" />
                <asp:BoundField DataField="Sport" HeaderText="Sport" ReadOnly="True" />
                <asp:BoundField DataField="Date" HeaderText="Date" ReadOnly="True" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="Duration" HeaderText="Duration" ReadOnly="True" />
                <asp:BoundField DataField="Price" DataFormatString="{0:N}" HeaderText="Price ($)" ReadOnly="True" />
            </Columns>
        </asp:GridView>
</asp:Content>
