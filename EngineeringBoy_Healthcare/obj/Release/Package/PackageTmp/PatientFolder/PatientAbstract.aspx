<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PatientFolder/PatientMasterPage.Master" CodeBehind="PatientAbstract.aspx.cs" Inherits="EngineeringBoy_Healthcare.PatientFolder.PatientAbstract" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainBody" runat="server">
    <div class="container">
        <div class="row">
            <div class="box">
                <h1 class="brand-name">Abstract</h1>
                <hr class="tagline-divider" />
                <h2>
                    <small>
                        <strong>View your medical abstract: </strong>
                    </small>
                </h2>

                <div class="body-text  text-center">
                    <hr class="tagline-divider" />
                    <div align="left">
                        <asp:DataGrid ID="dViewAbstract" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingItemStyle BackColor="White" />
                            <EditItemStyle BackColor="#7C6F57" />
                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                            <ItemStyle BackColor="#E3EAEB" />
                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                        </asp:DataGrid>
                    </div>
                    <hr class="tagline-divider" />
                </div>
                <br />
                <br />

            </div>
        </div>
    </div>

</asp:Content>
