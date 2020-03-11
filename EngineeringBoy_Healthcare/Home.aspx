<%@ Page Title="" Language="C#" MasterPageFile="~/Unregistered.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EngineeringBoy_Healthcare.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainBody" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-lg-12" align="center">
                    <img class="img-responsive" src="./pics/profile.png" alt="" />
                    <div align="center">
                        <h2><strong>EngineerBoy HealthCare</strong></h2>
                        <hr class="tagline-divider" />
                        <h5>Where Healing Begins</h5>
                    </div>
                </div>
            </div>
        </div>
    <div class="col-lg-12" style="text-align: center">
            <asp:Label ID="Label1" runat="server" Text="UserName:" ForeColor="#000066"></asp:Label><br />
        <asp:TextBox ID="txtboxUsername" runat="server" Width="200px"></asp:TextBox><br />
            <asp:Label ID="Label2" runat="server" Text="Password:" ForeColor="#000066"></asp:Label><br />
        <asp:TextBox ID="txtboxPassword" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkPatient" runat="server" Text="Patient?" ForeColor="#000066" />
        <br />
        <asp:Button ID="btnLogIn" class="btn btn-default btn-lg" runat="server" Text="LogIn" OnClick="btnLogin_Click" />
        <br />
        <a href="Register.aspx">No Account yet? Register here.</a>
        <hr class="tagline-divider" />
        <small><a href="ReactivateAccount.aspx">Reactivate an account?</a></small>
        <br />
    </div>
</asp:Content>
