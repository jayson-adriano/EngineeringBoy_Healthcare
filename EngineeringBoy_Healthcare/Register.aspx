<%@ Page Title="" Language="C#" MasterPageFile="~/Unregistered.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="EngineeringBoy_Healthcare.Register" %>

<asp:Content ID="mainBody" ContentPlaceHolderID="mainBody" runat="server">
    <section id="DoctorRegister">
        <div class="container">
            <div class="row">
                <div class="col-lg-12 text-center" align="center">
                    <h2>Registration</h2>
                    <hr class="star-light" />
                    <div class="col-lg-12" align="center">
                        <table class="table-unreg">
                            <tr>
                                <td>Last name</td>
                                <td>
                                    <asp:TextBox ID="txtBoxLastName" runat="server" Width="277px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>First name</td>
                                <td>
                                    <asp:TextBox ID="txtBoxfirstName" runat="server" Width="277px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>Middle name</td>
                                <td>
                                    <asp:TextBox ID="txtBoxmiddleName" runat="server" Width="277px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>Username</td>
                                <td>
                                    <asp:TextBox ID="txtBoxuserName" runat="server" Width="277px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>Password</td>
                                <td>
                                    <asp:TextBox ID="txtBoxpassword" runat="server" Width="277px" TextMode="Password"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>Address</td>
                                <td>
                                    <asp:TextBox ID="txtBoxAddress" runat="server" Width="277px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>E-mail address</td>
                                <td>
                                    <asp:TextBox ID="txtBoxemailAddress" runat="server" Width="277px"></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td>Birthday</td>
                                <td>Year:
                                    <asp:DropDownList ID="ddlYear" runat="server" onchange="PopulateDays()" />
                                    Month:
                                    <asp:DropDownList ID="ddlMonth" runat="server" onchange="PopulateDays()" />
                                    Day:
                                    <asp:DropDownList ID="ddlDay" runat="server" />

                                    <script type="text/javascript">
                                        function PopulateDays() {
                                            var ddlMonth = document.getElementById("<%=ddlMonth.ClientID%>");
                                            var ddlYear = document.getElementById("<%=ddlYear.ClientID%>");
                                            var ddlDay = document.getElementById("<%=ddlDay.ClientID%>");
                                            var y = ddlYear.options[ddlYear.selectedIndex].value;
                                            var m = ddlMonth.options[ddlMonth.selectedIndex].value != 0;
                                            if (ddlMonth.options[ddlMonth.selectedIndex].value != 0 && ddlYear.options[ddlYear.selectedIndex].value != 0) {
                                                var dayCount = 32 - new Date(ddlYear.options[ddlYear.selectedIndex].value, ddlMonth.options[ddlMonth.selectedIndex].value - 1, 32).getDate();
                                                ddlDay.options.length = 0;
                                                AddOption(ddlDay, "DD", "0");
                                                for (var i = 1; i <= dayCount; i++) {
                                                    AddOption(ddlDay, i, i);
                                                }
                                            }
                                        }

                                        function AddOption(ddl, text, value) {
                                            var opt = document.createElement("OPTION");
                                            opt.text = text;
                                            opt.value = value;
                                            ddl.options.add(opt);
                                        }

                                        function Validate(sender, args) {
                                            var ddlMonth = document.getElementById("<%=ddlMonth.ClientID%>");
                            var ddlYear = document.getElementById("<%=ddlYear.ClientID%>");
                            var ddlDay = document.getElementById("<%=ddlDay.ClientID%>");
                            args.IsValid = (ddlDay.selectedIndex != 0 && ddlMonth.selectedIndex != 0 && ddlYear.selectedIndex != 0)
                        }
                                    </script>
                                    <br />

                                </td>
                            </tr>
                            <tr>
                                <td>Code for Doctors:</td>
                                <td>
                                    <asp:TextBox ID="txtDocCode" runat="server" Width="277px" TextMode="Password"></asp:TextBox> <asp:Label ID="Label1" runat="server" Text="*Only doctors can fill up this textbox" ForeColor="#CC0000"></asp:Label></td>
                            </tr>
                            <tr>
                                <td>Specialization:</td>
                                <td>
                                    <asp:TextBox ID="txtSpecialization" runat="server" Width="277px"></asp:TextBox><asp:Label ID="Label2" runat="server" Text="*Only doctors can fill up this textbox" ForeColor="#CC0000"></asp:Label></td>
                            </tr>

                            <tr>
                                <td></td>
                                <td>
                                    <br />
                                    <asp:Button ID="btnRegister" class="btn btn-default btn-lg" runat="server" Text="Register" OnClick="btnRegister_Click" /></td>
                            </tr>
                        </table>
                        <h2 class="brand-before">
                            <small>Already have an account? <a href="../Home.aspx">Log In here.</a> </small>
                        </h2>
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
