<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuddySystemQn8.aspx.cs" Inherits="Pract4.BuddySystemQn8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">

        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Qn8Lbl1" runat="server" Text="Ideal Buddy"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Qn8Lbl2" runat="server" Font-Bold="True" Font-Size="Large" Text="How long do you plan to workout per <br /> session?"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:CheckBoxList ID="Qn8ChkBox" runat="server">
            <asp:ListItem>at most 1 hour</asp:ListItem>
            <asp:ListItem>at most 2 hours</asp:ListItem>
            <asp:ListItem>at most 3 hours</asp:ListItem>
            <asp:ListItem>more than 3 hours</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="BtnQ8" runat="server" BackColor="#3333FF" Font-Bold="False" ForeColor="White" Height="43px" OnClick="BtnQ8_Click" Text="Next" Width="193px" />
        <br />
        <br />
        <br />



    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Pan" runat="server">
</asp:Content>
