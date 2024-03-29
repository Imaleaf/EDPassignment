﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CustomerForm.aspx.cs" Inherits="Pract4.CustomerForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-sm-8">
            <asp:Panel ID="PanelErrorResult" Visible="false" runat="server" CssClass="alert alert-dismissable alert-danger">
            <button type="button" class="close" data-dismiss="alert">
                <span aria-hidden="true">&times;</span>
            </button>
            <asp:Label ID="Lbl_err" runat="server"></asp:Label>
            </asp:Panel>
            <div class="panel panel-info">
                <div class="panel-heading">
                    <h3 class="panel-title">Search</h3>
                </div>
                <div class="panel-body">
                    <div class="form-group">
                        <asp:Label ID="lbCustId" runat="server" Text="Customer Id:"></asp:Label>
                        <asp:TextBox ID="tbCustId" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <asp:Button ID="btnGetCustomer" runat="server" CssClass="btn btn-default" Text="Get" OnClick="btnGetCustomer_Click" />
                </div>
            </div>
            <asp:Panel ID="PanelCust" Visible="false" runat="server">
                <div class="panel panel-info">
                    <div class="panel-heading">Results:</div>
                    <div class="panel-body">
                        <div class="row">
                            <label for="Lbl_custname" class="col-sm-2 col-form-label">Name :</label>
                            <div class="col-sm-4">
                                <asp:Label ID="Lbl_custname" runat="server"></asp:Label>
                            </div>
                            <label for="Lbl_HomePhone" class="col-sm-2 col-form-label">Home Phone:</label>
                            <div class="col-sm-4">
                                <asp:Label ID="Lbl_HomePhone" runat="server"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <label for="Lbl_Address" class="col-sm-2 col-form-label">Address:</label>
                            <div class="col-sm-4">
                                <asp:Label ID="Lbl_Address" runat="server"></asp:Label>
                            </div>
                            <label for="Lbl_Mobile" class="col-sm-2 col-form-label">Mobile:</label>
                            <div class="col-sm-4">
                                <asp:Label ID="Lbl_Mobile" runat="server"></asp:Label>
                            </div>
                        </div>
                    </div>
                </div>
            </asp:Panel>
            <div class="row">   
                <asp:HyperLink ID="HyplinkAdd" CssClass="col-sm-12" NavigateUrl="~/TermDepositForm.aspx" Visible="false" runat="server">Create a new term deposit</asp:HyperLink>
            </div>
        </div>
    </div>
</asp:Content>
