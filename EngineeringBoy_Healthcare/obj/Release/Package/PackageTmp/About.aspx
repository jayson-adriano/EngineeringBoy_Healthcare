<%@ Page Title="" Language="C#" MasterPageFile="~/Unregistered.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="EngineeringBoy_Healthcare.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainBody" runat="server">
    <section class="success" id="about">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2>About Us</h2>
                    <hr class="star-light" />
                </div>
            </div>
            <div class="row">
                <div>
                    <img class="img-responsive" src="./pics/about.png" alt="" /> <asp:Label ID="lblAboutMessage" runat="server" Text="Label"></asp:Label>
                </div>
                <br />
                
                <div class="col-lg-4 col-lg-offset-2">
                </div>
            </div>
        </div>
    </section>
</asp:Content>
