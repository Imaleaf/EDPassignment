<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuddySystemQn6.aspx.cs" Inherits="Pract4.BuddySystemQn6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">

        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Qn6Lbl1" runat="server" Text="Ideal Buddy"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Qn6Lbl2" runat="server" Font-Bold="True" Font-Size="Large" Text="What type of workout buddy are you <br /> looking for?"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:CheckBoxList ID="Qn6ChkBox" runat="server">
            <asp:ListItem>Casual</asp:ListItem>
            <asp:ListItem>Serious</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="BtnQ1" runat="server" BackColor="#3333FF" Font-Bold="False" ForeColor="White" Height="43px" OnClick="BtnQ6_Click" Text="Next" Width="193px" />
        <br />
        <br />
        <br />



    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Pan" runat="server">
</asp:Content>
