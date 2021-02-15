<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuddySystemQn9.aspx.cs" Inherits="Pract4.BuddySystemQn9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div align="center">

        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Qn9Lbl1" runat="server" Text="Ideal Buddy"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Qn9Lbl2" runat="server" Font-Bold="True" Font-Size="Large" Text="When would you normally workout?"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:CheckBoxList ID="Qn9ChkBox" runat="server">
            <asp:ListItem>Monday</asp:ListItem>
            <asp:ListItem>Tuesday</asp:ListItem>
            <asp:ListItem>Wednesday</asp:ListItem>
            <asp:ListItem>Thursday</asp:ListItem>
            <asp:ListItem>Friday</asp:ListItem>
            <asp:ListItem>Saturday</asp:ListItem>
            <asp:ListItem>Sunday</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="BtnQ9" runat="server" BackColor="#3333FF" Font-Bold="False" ForeColor="White" Height="43px" OnClick="BtnQ9_Click" Text="Next" Width="193px" />
        <br />
        <br />
        <br />



    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Pan" runat="server">
</asp:Content>
