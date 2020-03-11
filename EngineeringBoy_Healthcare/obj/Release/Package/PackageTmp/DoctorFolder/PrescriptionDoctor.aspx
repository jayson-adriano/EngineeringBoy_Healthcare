<%@ Page Title="" Language="C#" MasterPageFile="~/DoctorFolder/DoctorMasterPage.Master" AutoEventWireup="true" CodeBehind="PrescriptionDoctor.aspx.cs" Inherits="EngineeringBoy_Healthcare.DoctorFolder.PrescriptionDoctor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainBody" runat="server">

    <div class="container" align="left">
        <div class="row">
            <div class="box">
                <h1 class="brand-name">Prescription</h1>
                <hr class="tagline-divider" />
                <h2>
                    <small>
                        <strong>Send prescriptions: </strong>
                    </small>
                </h2>

                <div align="left">
                    <hr class="tagline-divider" />
                    <br />
                    <br />
                    Patient:
                        <asp:DropDownList ID="ddPatient" runat="server"></asp:DropDownList>
                    <br />
                    <br />
                    Prescription Message
                        <br />
                    <asp:TextBox ID="txtBoxPrescription" runat="server" Height="250px" Width="500px" Style="text-align: left; vertical-align: top"></asp:TextBox>

                    <hr class="tagline-divider" />
                    <br />
                    <asp:Button ID="btmPrescribe" class="btn btn-default btn-lg" runat="server" Text="Prescribe" OnClick="btnPrescribe_Click" />
                    <br />
                </div>
            </div>
        </div>
        <div align="center">
            <a href="../Home.aspx">Logout</a>
            <br />
        </div>
    </div>
</asp:Content>
