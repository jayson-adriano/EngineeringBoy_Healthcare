<%@ Page Title="" Language="C#" MasterPageFile="~/PatientFolder/PatientMasterPage.Master" AutoEventWireup="true" CodeBehind="FeedbackPatient.aspx.cs" Inherits="EngineeringBoy_Healthcare.PatientFolder.FeedbackPatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainBody" runat="server">
    <div class="container">
        <div class="row">
            <div class="box">
                    <h1 class="brand-name">Feedback</h1>
                    <hr class="tagline-divider" />
                    <h2>
                        <small>
                            <strong>Type your feedback</strong>
                        </small>
                    </h2>
                    <hr class="tagline-divider" />
                    <br />
                    <asp:TextBox ID="txtBoxFeedback" runat="server" Height="250px" Width="500px" style="text-align:left; vertical-align:top"></asp:TextBox>
                    <br /><br />
                    <asp:Button ID="btnSubmitTesti" runat="server" Text="Submit" OnClick="btnSubmitFeedback_Click" class="btn btn-default btn-lg" />
                    <br/>
                </div>
            </div>
        </div>
</asp:Content>
