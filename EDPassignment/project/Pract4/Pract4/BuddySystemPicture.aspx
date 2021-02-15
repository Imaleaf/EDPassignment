<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuddySystemPicture.aspx.cs" Inherits="Pract4.BuddySystemPicture" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
            <div align="center">

        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="About you"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="Large" Text="Upload a picture of yourself"></asp:Label>
        <br />
        <br />
        <br />
            <br />
        <br />

        <label class="file-upload"><asp:FileUpload ID="FileUpload1" runat="server" Height="30px" Width="250px" > </asp:FileUpload> </label>
        <br />
        <br />
            <br />
        <br />
        <br />
        <asp:Button ID="BtnProfilePic" runat="server" BackColor="#3333FF" Font-Bold="False" ForeColor="White" Height="43px" Text="Next" Width="193px" OnClick="BtnProfilePic_Click" />
        <br />
        <br />
        <br />



    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Pan" runat="server">
</asp:Content>
