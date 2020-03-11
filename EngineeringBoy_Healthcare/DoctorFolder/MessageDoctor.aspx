<%@ Page Title="" Language="C#" MasterPageFile="~/DoctorFolder/DoctorMasterPage.Master" AutoEventWireup="true" CodeBehind="MessageDoctor.aspx.cs" Inherits="EngineeringBoy_Healthcare.DoctorFolder.MessageDoctor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainBody" runat="server">
    <div class="container">
        <div class="row">
            <div class="box">
                <h1 class="brand-name">Chat</h1>
                <hr class="tagline-divider" />
                <h2>
                    <small>
                        <strong>View your recent messages</strong>
                    </small>
                </h2>
                <hr class="tagline-divider" />

                <div align="left">
                    <asp:DataGrid ID="dViewMessages" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
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
                <small><strong>Send to:</strong></small>
                <asp:DropDownList ID="ddPatient" runat="server"></asp:DropDownList><br />
                <br />
                <asp:TextBox ID="txtBoxChat" runat="server" Height="100px" Width="550px" Style="text-align: left; vertical-align: top"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btnSubmitChat" runat="server" Text="Send" OnClick="btnSubmitChat_Click" class="btn btn-default btn-lg" />
                <br />
            </div>
        </div>
        <div align="center">
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="btnLogOut">Logout</asp:LinkButton>
            <br />
        </div>
    </div>

</asp:Content>
