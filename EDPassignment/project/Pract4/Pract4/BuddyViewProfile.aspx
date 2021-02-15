<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BuddyViewProfile.aspx.cs" Inherits="Pract4.BuddyViewProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <style type="text/css">
        #div1{
            background-color : #1A1A1A;
            height:220px;
        }
        #div2{
            background-color : #F3F5F9;
            height:500px;
        }
        #div3{
            background-color : #F3F5F9;
            height:500px;
        }
        .auto-style1 {
            margin-top: 0px;
            margin-bottom: 0px;
        }
        .container2{
            background-color : #FFFFFF;
            width: 410px;
            height: 70px;
            padding: 20px 50px 20px 20px;
        }
        .container3{
            background-color : #f6f1f4;
            width: 410px;
            height: 80px;
            padding: 20px 50px 20px 20px;
        }
        .container4{
            width: 300px;
            height: 50px;
            padding: 20px 50px 20px 20px;
        }
        .something{
            background-color:transparent;
            border:none;
        }
        </style>
<div id="div1" align="center">

    <br />
    <asp:Image ID="Image1" runat="server" Height="122px" Width="148px" CssClass="auto-style1" />
    <br />
    <br />
&nbsp;<asp:Label ID="lbl_Name" runat="server" Font-Size="XX-Large" ForeColor="White"></asp:Label>
    &nbsp;<asp:Label ID="Label1" runat="server" Font-Size="XX-Large" ForeColor="White" Text="•"></asp:Label>
&nbsp;<asp:Label ID="lbl_Age" runat="server" Font-Size="XX-Large" ForeColor="White"></asp:Label>
&nbsp;<asp:Label ID="Label2" runat="server" Font-Size="XX-Large" ForeColor="White" Text="•"></asp:Label>
    &nbsp;<asp:Label ID="lbl_Location" runat="server" Font-Size="XX-Large" ForeColor="White"></asp:Label>
</div>
    <div class="container-fluid">
    <div class="row">
    <div id="div2" class="col-sm-6" align="right">
        <br />
        <br />
        <div class="container2" align="left">
            <asp:Label ID="Label3" runat="server" ForeColor="#949AA6" Text="ABOUT ME" Font-Bold="True" Font-Names="Arial" Font-Size="Small"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="My self-summary" Font-Names="Arial" Font-Size="Large" ForeColor="Black"></asp:Label>
            <br />
        </div>
        <div class="container3" align="left">

            <asp:Label ID="lbl_bio" runat="server" Font-Names="Arial" Font-Size="Large" ForeColor="Black"></asp:Label>
            <asp:Button ID="btn_bio" CssClass="something" runat="server" Text="Edit" ForeColor="#3366FF" Font-Italic="True" OnClick="btn_bio_Click" />
        </div>
        <br />
        <div class="container2" align="left">
            <asp:Label ID="Label5" runat="server" ForeColor="#949AA6" Text="WORKOUT SCHEDULE" Font-Bold="True" Font-Names="Arial" Font-Size="Small"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Current Schedule" Font-Names="Arial" Font-Size="Large" ForeColor="Black"></asp:Label>
            <br />
        </div>

        <div class="container3" align="left">
            <asp:Label ID="lbl_workoutdays" runat="server" Font-Names="Arial" Font-Size="Large" ForeColor="Black"></asp:Label>
            <asp:Button ID="btn_workoutdays" CssClass="something" runat="server" Text="Edit" ForeColor="#3366FF" Font-Italic="True" OnClick="btn_workoutdays_Click" />
            <br />
            <asp:Label ID="lbl_workoutduration" runat="server" Font-Names="Arial" Font-Size="Large" ForeColor="Black"></asp:Label>
            <asp:Button ID="btn_workoutduration" CssClass="something" runat="server" Text="Edit" ForeColor="#3366FF" Font-Italic="True" OnClick="btn_workoutduration_Click" />

        </div>
    </div>
        <div id="div3" class="col-sm-6">
            <br />
            <br />
            <div class="container4" align="left">
                <svg width="24" height="25" viewBox="0 0 24 25" fill="none" xmlns="http://www.w3.org/2000/svg" class=""><path d="M12.03 7.104a3.552 3.552 0 1 1 3.552-3.543 3.543 3.543 0 0 1-3.552 3.543zm0-5.704a2.16 2.16 0 1 0 2.16 2.161 2.15 2.15 0 0 0-2.16-2.16z" fill="#191919"></path><path d="M14.376 24.01a2.059 2.059 0 0 1-1.984-1.743l-.334-2.57-.38 2.57a2.077 2.077 0 0 1-2.069 1.743 2.225 2.225 0 0 1-1.641-.705 2.207 2.207 0 0 1-.621-1.669l.62-6.946-.416.686a1.957 1.957 0 0 1-2.152.928 1.854 1.854 0 0 1-1.215-1.02 1.8 1.8 0 0 1 0-1.586l2.745-5.25a3.617 3.617 0 0 1 2.68-1.947l1.725-.25a4.48 4.48 0 0 1 1.317 0l1.734.25a3.617 3.617 0 0 1 2.7 1.948l2.726 5.212a1.855 1.855 0 0 1-1.178 2.606 1.957 1.957 0 0 1-2.152-.928l-.417-.686.621 6.918a2.27 2.27 0 0 1-2.262 2.402l-.047.037zm-2.365-9.162a.871.871 0 0 1 .872.77l.835 6.426a.668.668 0 0 0 .658.557.873.873 0 0 0 .64-.27.844.844 0 0 0 .232-.648l-.844-9.47a.788.788 0 0 1 1.465-.481l1.762 2.912a.566.566 0 0 0 .622.25.428.428 0 0 0 .278-.612L15.84 9.07a2.215 2.215 0 0 0-1.65-1.187l-1.725-.232a3.051 3.051 0 0 0-.928 0l-1.725.25A2.216 2.216 0 0 0 8.172 9.09L5.482 14.3a.427.427 0 0 0 .279.613.556.556 0 0 0 .621-.26l1.762-2.903a.788.788 0 0 1 1.465.482l-.853 9.497a.862.862 0 0 0 .533.822c.11.046.229.07.348.068a.668.668 0 0 0 .659-.566l.834-6.417a.927.927 0 0 1 .881-.788z" fill="#191919"></path></svg>
                &nbsp;<asp:Label ID="lbl_gender" runat="server" Font-Names="Arial" Font-Size="Large" ForeColor="Black"></asp:Label>
                <asp:Button ID="btn_gender" CssClass="something" runat="server" Text="Edit" ForeColor="#3366FF" Font-Italic="True" OnClick="btn_gender_Click"/>
                <br />
                <br />
                <svg width="24" height="24" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg" class=""><title>Combined Shape</title><g id="Symbols" fill="none" fill-rule="evenodd"><g id="Icon/Background/24" fill="#1A1A1A" fill-rule="nonzero"><path d="M12.155.016L12 .015C18.627.015 24 5.38 24 12c0 6.566-5.287 11.899-11.841 11.984a.769.769 0 0 1-.317-.001l.158.002C5.373 23.985 0 18.619 0 12 0 5.433 5.289.1 11.844.016a.764.764 0 0 1 .311 0zM6.773 12.748l-5.247.001c.344 4.855 3.996 8.797 8.718 9.592a17.025 17.025 0 0 1-3.47-9.593zm15.7.001h-5.246a17.025 17.025 0 0 1-3.47 9.591c4.721-.794 8.373-4.736 8.717-9.591zm-6.748 0h-7.45A15.543 15.543 0 0 0 12 22.13a15.54 15.54 0 0 0 3.725-9.383zm-5.481-11.09l-.191.034c-4.63.867-8.188 4.768-8.527 9.557h5.247a17.027 17.027 0 0 1 3.47-9.591zm1.756.21l-.253.303a15.537 15.537 0 0 0-3.472 9.078h7.45a15.535 15.535 0 0 0-3.472-9.078L12 1.869zm1.755-.21l.137.18a17.022 17.022 0 0 1 3.335 9.411h5.247c-.344-4.855-3.996-8.798-8.719-9.591z" id="Combined-Shape"></path></g></g></svg>
                &nbsp;<asp:Label ID="lbl_workoutType" runat="server" Font-Names="Arial" Font-Size="Large" ForeColor="Black"></asp:Label>
                <asp:Button ID="btn_workoutType" CssClass="something" runat="server" Text="Edit" ForeColor="#3366FF" Font-Italic="True" OnClick="btn_workoutType_Click" />
                <br />
                <br />
                <svg width="24" height="22" viewBox="0 0 24 22" xmlns="http://www.w3.org/2000/svg" class=""><title>Combined Shape</title><g id="Symbols" fill="none" fill-rule="evenodd"><g id="Icon/Pronouns/24" transform="translate(0 -1)" fill="#1A1A1A"><path d="M17.524 1.433L23.93 15.17a.75.75 0 0 1-1.233.824l-8.195 1.743a3.755 3.755 0 0 1-3.532 5.011 3.756 3.756 0 0 1-3.74-3.465l-2.84.603.242.52a.751.751 0 0 1-1.36.635L.07 14.172a.75.75 0 1 1 1.36-.635l.227.487L16.105 1.872a.75.75 0 0 1 1.42-.439zm-4.511 16.62l-4.294.912.001.033c0 1.24 1.01 2.25 2.25 2.25a2.253 2.253 0 0 0 2.043-3.196zm3.725-14.755L2.313 15.431l1.427 3.06 18.272-3.885-5.274-11.308z" id="Combined-Shape"></path></g></g></svg>
                &nbsp;<asp:Label ID="lbl_idealbuddy" runat="server" Font-Names="Arial" Font-Size="Large" ForeColor="Black"></asp:Label>
            </div>
                
            </div>
        </div>
        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Pan" runat="server">
</asp:Content>
