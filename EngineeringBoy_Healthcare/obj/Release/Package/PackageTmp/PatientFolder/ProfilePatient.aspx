<%@ Page Title="" Language="C#" MasterPageFile="~/PatientFolder/PatientMasterPage.Master" AutoEventWireup="true" CodeBehind="ProfilePatient.aspx.cs" Inherits="EngineeringBoy_Healthcare.PatientFolder.ProfilePatient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainBody" runat="server">

    <div class="container">
        <div class="row">
            <div class="box">

                <h1 class="brand-name">Account</h1>
                <hr class="tagline-divider" />
                <h2>
                    <small>
                        <strong>Account details</strong>
                    </small>
                </h2>

                <div class="body-text  text-center">
                    <table class="table-unreg">
                        <tr>
                            <td>Last name</td>
                            <td>
                                <asp:TextBox ID="txtBoxLastName" runat="server" Width="277px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>First name</td>
                            <td>
                                <asp:TextBox ID="txtBoxfirstName" runat="server" Width="277px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Middle name</td>
                            <td>
                                <asp:TextBox ID="txtBoxmiddleName" runat="server" Width="277px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Username</td>
                            <td>
                                <asp:TextBox ID="txtBoxuserName" runat="server" Width="277px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Password</td>
                            <td>
                                <asp:TextBox ID="txtBoxpassword" runat="server" Width="277px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Address</td>
                            <td>
                                <asp:TextBox ID="txtBoxAddress" runat="server" Width="277px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>E-mail address</td>
                            <td>
                                <asp:TextBox ID="txtBoxemailAddress" runat="server" Width="277px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td>Birthday:</td>
                            <td>
                                <asp:TextBox ID="txtBirthday" runat="server" Width="277px" ReadOnly="true"></asp:TextBox></td>
                        </tr>
                    </table>
                </div>
                <br />
                <br />
                <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSaveChanges_Click" class="btn btn-default btn-lg" />
                <br />
                <div align="center">
                    <a href="../PatientFolder/DeactivatePatient.aspx">Deactivate Account  </a>
                    <br />
                    <a href="../Home.aspx">Logout</a>
                    <br />
                </div>
            </div>
        </div>
    </div>


</asp:Content>
