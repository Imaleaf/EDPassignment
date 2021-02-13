<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookingFormCustomer.aspx.cs" Inherits="Pract4.BookingFormCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container-fluid">
        <center>
            <h1>BOOK A FACILITY</h1>
        </center>
        <center>
        <asp:GridView ID="gvBooking" runat="server" AutoGenerateColumns="False" CellPadding="0" CssClass="myDatagrid">
            <Columns>
                <asp:BoundField DataField="FacilityID" HeaderText="Facility ID" ReadOnly="True" />
                <asp:BoundField DataField="FacilityName" HeaderText="Facility Name" ReadOnly="True" />
                <asp:BoundField DataField="Sport" HeaderText="Sport" ReadOnly="True" />
                <asp:BoundField DataField="Date" HeaderText="Date" ReadOnly="True" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="Duration" HeaderText="Duration" ReadOnly="True" />
                <asp:BoundField DataField="Price" DataFormatString="{0:N}" HeaderText="Price ($)" ReadOnly="True" />
            </Columns>
        </asp:GridView></center>
        </div>
</asp:Content>
