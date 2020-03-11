<%@ Page Title="" Language="C#" MasterPageFile="~/DoctorFolder/DoctorMasterPage.Master" AutoEventWireup="true" CodeBehind="MedicalAbstractDoctor.aspx.cs" Inherits="EngineeringBoy_Healthcare.DoctorFolder.MedicalAbstractDoctor" %>

<asp:Content ID="Content1" ContentPlaceHolderID="mainBody" runat="server">


    <div class="container">
        <div class="row">
            <div class="box">
                <h1>Medical Abstract</h1>
                <hr class="tagline-divider" />
                <h2>
                    <small>
                        <strong>Send the Medical Abstract: </strong>
                    </small>
                </h2>

                <div>
                    <hr class="tagline-divider" />
                    <br />
                    <br />
                    <h3>Patient:</h3>
                    <asp:DropDownList ID="ddPatient" runat="server"></asp:DropDownList>
                    <br />
                    <br />
                    <br />
                    <asp:Label ID="Label2" runat="server" Text="Result:" ForeColor="#000066"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtResult" runat="server" Height="250px" Width="500px" Style="text-align: left; vertical-align: top"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label1" runat="server" Text="Treatment" ForeColor="#000066"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtTreatment" runat="server" Height="250px" Width="500px" Style="text-align: left; vertical-align: top"></asp:TextBox>
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Restriction:" ForeColor="#000066"></asp:Label>
                    <br />
                    <asp:TextBox ID="txtRestriction" runat="server" Height="250px" Width="500px" Style="text-align: left; vertical-align: top"></asp:TextBox>

                    <hr class="tagline-divider" />
                    <br />
                    <asp:Button ID="btnAbstract" runat="server" Text="Send Abstract" OnClick="btnAbstract_Click" class="btn btn-default btn-lg" />
                    <br />
                </div>
            </div>
        </div>
        <br />
        <div align="center">
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="btnLogOut">Logout</asp:LinkButton>
            <br />
        </div>
    </div>

</asp:Content>
