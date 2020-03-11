<%@ Page Title="" Language="C#" MasterPageFile="~/PatientFolder/PatientMasterPage.Master" AutoEventWireup="true" CodeBehind="DeactivatePatient.aspx.cs" Inherits="EngineeringBoy_Healthcare.PatientFolder.DeactivatePatient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="mainBody" runat="server">
    
    <div class="body-text" style="text-align:center">
        <h2>  Are you sure you want to deactivate your account?</h2>
  
                    <asp:Button ID="btnConfirmDeactivation" runat="server" Text="Yes" OnClick="btnOKDeact_Click" class="btn btn-default btn-lg"/>
    
                    <asp:Button ID="btnCancelDeactivation" runat="server" Text="No" class="btn btn-default btn-lg" OnClick="btnCancelDeact_Click" />
   
    </div>

</asp:Content>
