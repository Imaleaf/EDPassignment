<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuddySystemQn4.aspx.cs" Inherits="Pract4.BuddySystemQn4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div align="center">

        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Qn4Lbl1" runat="server" Text="About you"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Qn4Lbl2" runat="server" Font-Bold="True" Font-Size="Large" Text="Where do you primarily live?"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TbQn4" runat="server" Height="24px" Width="148px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="BtnQ4" runat="server" BackColor="#3333FF" Font-Bold="False" ForeColor="White" Height="43px" OnClick="BtnQ4_Click" Text="Next" Width="193px" />
        <br />
        <br />
        <br />



    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Pan" runat="server">
</asp:Content>
