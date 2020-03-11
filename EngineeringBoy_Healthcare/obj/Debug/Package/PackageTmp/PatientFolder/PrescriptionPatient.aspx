<%@ Page Title="" Language="C#" MasterPageFile="~/PatientFolder/PatientMasterPage.Master" AutoEventWireup="true" CodeBehind="PrescriptionPatient.aspx.cs" Inherits="EngineeringBoy_Healthcare.PatientFolder.PrescriptionPatient" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainBody" runat="server">
    <div class="container">
        <div class="row">
            <div class="box">
                <h1 class="brand-name">Prescription</h1>
                <hr class="tagline-divider" />
                <h2>
                    <small>
                        <strong>View your prescriptions: </strong>
                    </small>
                </h2>

                <div class="body-text  text-center">
                    <hr class="tagline-divider" />
                    <div align="left">
                        <asp:DataGrid ID="dViewPrescriptions" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingItemStyle BackColor="White" />
                            <EditItemStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <ItemStyle BackColor="#E3EAEB" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        </asp:DataGrid>
                    </div>
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="btnPrint" runat="server" Text="Print" OnClientClick="javascript:window.print();" class="btn btn-default btn-lg" />
                    <hr class="tagline-divider" />
                </div>

                <br />
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="btnLogOut">Logout</asp:LinkButton>
                <br />

                </>
            </div>
        </div>
    </div>
</asp:Content>
