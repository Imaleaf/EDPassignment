<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserViewProfile.aspx.cs" Inherits="Pract4.UserViewProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


                      <center>
                       <img width="150px" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTVMxYdQL13uCc2nO9YegWkgoA9hJPBpV3VGw&usqp=CAU"/>
                        </center>
                 
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3>User Profile</h3>
                        </center>

                <div class="panel panel-info">
                    <div class="panel-heading">User Profile:</div>
                    <div class="panel-body">
                        <div class="row">
                            <label for="Lbl_custname" class="col-sm-2 col-form-label">Name :</label>
                            <div class="col-sm-4">
                                <asp:Label ID="lbl_name" runat="server"></asp:Label>
                            </div>
                            <label for="Lbl_HomePhone" class="col-sm-2 col-form-label">Date of Birth :</label>
                            <div class="col-sm-4">
                                <asp:Label ID="lbl_dob" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <label for="Lbl_Address" class="col-sm-2 col-form-label">Contact :</label>
                            <div class="col-sm-4">
                                <asp:Label ID="lbl_contact" runat="server"></asp:Label>
                            </div>
                            <label for="Lbl_Mobile" class="col-sm-2 col-form-label">Email :</label>
                            <div class="col-sm-4">
                                <asp:Label ID="lbl_email" runat="server"></asp:Label>
                            </div>
                        </div>
                         <div class="row">
                            <label for="lbl_country" class="col-sm-2 col-form-label">Country :</label>
                            <div class="col-sm-4">
                                <asp:Label ID="lbl_country" runat="server"></asp:Label>
                            </div>
                            <label for="lbl_city" class="col-sm-2 col-form-label">City :</label>
                            <div class="col-sm-4">
                                <asp:Label ID="lbl_city" runat="server"></asp:Label>
                            </div>

                    </div>
                </div>

                     
                      </div>
                         <asp:Button ID="Logout" runat="server" Text="Logout" OnClick="Logout_Click" />
                      </div>
</asp:Content>
