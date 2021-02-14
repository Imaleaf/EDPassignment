<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="Pract4.UserLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <center>
      <img width="150px" src="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTVMxYdQL13uCc2nO9YegWkgoA9hJPBpV3VGw&usqp=CAU"/>
    </center>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3>Login</h3>
                        </center>
                         </div>
                      </div>
                    <center>
                    <div class="row">
                     <div class="col">
                        <label>UserID :</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TbUserID" runat="server" placeholder="UserID"></asp:TextBox>
                        </div>
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TbPW" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="form-group">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="BtnLogin" runat="server" Text="Login" OnClick="BtnLogin_Click" />
                            <br />
                            <asp:Label ID="lbMsg" runat="server" ForeColor="Red"></asp:Label>
                        </div>
                     </div>
                  </div>
                        </center>


</asp:Content>
