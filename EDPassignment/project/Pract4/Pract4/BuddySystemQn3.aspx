<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuddySystemQn3.aspx.cs" Inherits="Pract4.BuddySystemQn3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div align="center">

        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="About you"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="Large" Text="When were you born?"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="Qn3tbBday" runat="server" placeholder="dd/mm/yyyy" TextMode="Date"></asp:TextBox>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="BtnQ3" runat="server" BackColor="#3333FF" Font-Bold="False" ForeColor="White" Height="43px" OnClick="BtnQ3_Click" Text="Next" Width="193px" />
        <br />
        <br />
        <br />



    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Pan" runat="server">
</asp:Content>
