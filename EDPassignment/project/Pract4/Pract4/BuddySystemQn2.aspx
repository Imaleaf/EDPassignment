<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuddySystemQn2.aspx.cs" Inherits="Pract4.BuddySystemQn2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">

        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="About you"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" Text="I am a..."></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:RadioButtonList ID="Qn2RadioBtn" runat="server" Width="149px" >
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="BtnQ2" runat="server" BackColor="#3333FF" Font-Bold="False" ForeColor="White" Height="43px" OnClick="BtnQ2_Click" Text="Next" Width="193px" />
        <br />
        <br />
        <br />



    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Pan" runat="server">
</asp:Content>
