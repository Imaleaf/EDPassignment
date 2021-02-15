<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuddySystemQn5.aspx.cs" Inherits="Pract4.BuddySystemQn5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div align="center">

        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Qn5Lbl1" runat="server" Text="About you"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Qn5Lbl2" runat="server" Font-Bold="True" Font-Size="Large" Text="Introduce yourself"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="Qn5Tb1" runat="server" Height="189px" style="margin-top: 0" TextMode="MultiLine" Width="317px"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="BtnQ5" runat="server" BackColor="#3333FF" Font-Bold="False" ForeColor="White" Height="43px" OnClick="BtnQ5_Click" Text="Next" Width="193px" />
        <br />
        <br />
        <br />



    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Pan" runat="server">
</asp:Content>
