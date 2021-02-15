<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuddySystemQn7.aspx.cs" Inherits="Pract4.BuddySystemQn7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div align="center">

        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Qn7Lbl1" runat="server" Text="Ideal Buddy"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Qn7Lbl2" runat="server" Font-Bold="True" Font-Size="Large" Text="What is your preferred gender for <br /> workout buddy?"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:CheckBoxList ID="Qn7ChkBox" runat="server" style="height: 40px">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="BtnQ7" runat="server" BackColor="#3333FF" Font-Bold="False" ForeColor="White" Height="43px" OnClick="BtnQ7_Click" Text="Next" Width="193px" />
        <br />
        <br />
        <br />



    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Pan" runat="server">
</asp:Content>
