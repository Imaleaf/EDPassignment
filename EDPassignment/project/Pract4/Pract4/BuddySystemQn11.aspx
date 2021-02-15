<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuddySystemQn11.aspx.cs" Inherits="Pract4.BuddySystemQn11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div align="center">

        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Qn11Lbl1" runat="server" Text="Ideal Buddy"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Qn11Lbl2" runat="server" Font-Bold="True" Font-Size="Large" Text="How old should they be?"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="Qn11Tb1" runat="server" TextMode="Number"></asp:TextBox>
&nbsp;&nbsp; -&nbsp;&nbsp;
        <asp:TextBox ID="Qn11Tb2" runat="server" TextMode="Number"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="BtnQ11" runat="server" BackColor="#3333FF" Font-Bold="False" ForeColor="White" Height="43px" OnClick="BtnQ11_Click" Text="Submit" Width="193px" />
        <br />
        <br />
        <br />



    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Pan" runat="server">
</asp:Content>
