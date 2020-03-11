<%@ Page Title="" Language="C#" MasterPageFile="~/PatientFolder/PatientMasterPage.Master" AutoEventWireup="true" CodeBehind="DoctorInfoPage.aspx.cs" Inherits="EngineeringBoy_Healthcare.PatientFolder.DoctorInfoPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainBody" runat="server">
    <div class="container">
        <div class="row">
            <div class="box">

                <h1 class="brand-name">DOCTORS SPECIALIZATIONS</h1>
                <hr class="tagline-divider" />
                <h2>
                    <small>LIST OF DOCTORS
                    </small>
                </h2>

                <div class="body-text  text-center">
                    <hr class="tagline-divider" />
                    <div align="left">
                        <asp:DataGrid ID="dViewdoctors" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingItemStyle BackColor="White" />
                            <EditItemStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <ItemStyle BackColor="#E3EAEB" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        </asp:DataGrid>
                        <hr class="tagline-divider" />
                    </div>
                </div>
                <br />
                <br />


                <br />
                <br />
                <br />
                <a href="../Home.aspx">Logout</a>
                <br />

            </div>
        </div>

    </div>
</asp:Content>
