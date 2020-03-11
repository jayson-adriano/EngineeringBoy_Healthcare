<%@ Page Title="" Language="C#" MasterPageFile="~/Unregistered.Master" AutoEventWireup="true" CodeBehind="ReactivateAccount.aspx.cs" Inherits="EngineeringBoy_Healthcare.ReactivateAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainBody" runat="server">
    <header>
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
    </header>
    <div class="col-lg-12" style="text-align: center" />
    <h2 class="brand-before">
        <small>Welcome to</small>
    </h2>
    <h2>Reactivate Account</h2>
    <hr class="tagline-divider" />
    <asp:Label ID="Label1" runat="server" Text="UserName:" ForeColor="#000066"></asp:Label><br />
    <asp:TextBox ID="txtboxUsername" runat="server" Width="200px"></asp:TextBox><br />
    <asp:Label ID="Label2" runat="server" Text="Password:" ForeColor="#000066"></asp:Label><br />
    <asp:TextBox ID="txtboxPassword" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
    <br />
    <br />
    <asp:Button class="btn btn-default btn-lg" ID="btnLogIn" runat="server" Text="Reactivate" OnClick="btnReactivate_Click"/>
    <br />
    <br />
    <h2 class="brand-before">
        <small>Already have an account? <a href="./Home.aspx">Log In here.</a> </small>
    </h2>
</asp:Content>
