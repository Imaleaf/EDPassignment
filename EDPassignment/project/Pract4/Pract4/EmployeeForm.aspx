<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployeeForm.aspx.cs" Inherits="Pract4.EmployeeForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div>
    <h3>Create Employee</h3>
    <table style="width:100%;">
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Nric:</td>
            <td>
                <asp:TextBox ID="tbNric" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Name:</td>
            <td>
                <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Birth Date:</td>
            <td>
                <asp:TextBox ID="tbBirthDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Department:</td>
            <td>
                <asp:DropDownList ID="ddlDept" runat="server" Width="154px">
                    <asp:ListItem Selected="True" Value="0">- Select -</asp:ListItem>
                    <asp:ListItem Value="Finance">Finance</asp:ListItem>
                    <asp:ListItem Value="HR">HR</asp:ListItem>
                    <asp:ListItem Value="IT">IT</asp:ListItem>
                    <asp:ListItem Value="Sales">Sales</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">Monthly Salary ($):</td>
            <td>
                <asp:TextBox ID="tbMthlySalary" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>
                <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="77px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1" style="width: 134px">&nbsp;</td>
            <td>
                <asp:Label ID="lbMsg" runat="server" ForeColor="Red"></asp:Label>
            </td>
        </tr>
    </table>
    </div>
        <asp:GridView ID="gvEmployee" runat="server" AutoGenerateColumns="False" CellPadding="0" CssClass="myDatagrid">
            <Columns>
                <asp:BoundField DataField="Nric" HeaderText="NRIC" ReadOnly="True" />
                <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" />
                <asp:BoundField DataField="Dept" HeaderText="Department" ReadOnly="True" />
                <asp:BoundField DataField="BirthDate" HeaderText="Birth Date" ReadOnly="True" DataFormatString="{0:dd/MM/yyyy}" />
                <asp:BoundField DataField="MthlySalary" DataFormatString="{0:N}" HeaderText="Monthly Salary ($)" ReadOnly="True" />
                <asp:BoundField DataField="EmployeeCPF" DataFormatString="{0:N}" HeaderText="Employee CPF Contribution ($)" ReadOnly="True" />
                <asp:BoundField DataField="EmployerCPF" DataFormatString="{0:N}" HeaderText="Employer CPF Contribution ($)" ReadOnly="True" />
            </Columns>
        </asp:GridView>
</asp:Content>
