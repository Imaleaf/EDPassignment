<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuddySystemQn10.aspx.cs" Inherits="Pract4.BuddySystemQn10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <div align="center">

        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Qn10Lbl1" runat="server" Text="Ideal Buddy"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Qn10Lbl2" runat="server" Font-Bold="True" Font-Size="Large" Text="What type of fitness are you looking to <br /> do?"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:CheckBoxList ID="Qn10ChkBox" runat="server">
            <asp:ListItem Value="Aerobic">Aerobic Fitness</asp:ListItem>
            <asp:ListItem Value="Muscle">Muscle Strengthening</asp:ListItem>
            <asp:ListItem>Flexibility</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="BtnQ10" runat="server" BackColor="#3333FF" Font-Bold="False" ForeColor="White" Height="43px" OnClick="BtnQ10_Click" Text="Next" Width="193px" />
        <br />
        <br />
        <br />



    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Pan" runat="server">
</asp:Content>
