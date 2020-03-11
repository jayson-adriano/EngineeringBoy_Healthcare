<%@ Page Title="" Language="C#" MasterPageFile="~/Unregistered.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="EngineeringBoy_Healthcare.Contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainBody" runat="server">
    <section class="success" id="about">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center">
                    <h2>Contact Us</h2>
                    <hr class="star-light" />
                </div>
            </div>
            <div class="row">
                <div class="col-lg-4 col-lg-offset-2">
                    <strong>WEB DEVELOPERS</strong><br /><br />
                    <asp:Label ID="lblContactMessage" runat="server" Text="Text"></asp:Label><br />
               
                     </div>
            </div>
        </div>
    </section>
</asp:Content>
