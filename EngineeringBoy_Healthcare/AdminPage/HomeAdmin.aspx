<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeAdmin.aspx.cs" Inherits="EngineeringBoy_Healthcare.AdminPage.HomeAdmin" %>



<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>EngineeringBoy Healthcare</title>
    <!--GOOGLE FONT -->
    <link href='http://fonts.googleapis.com/css?family=Open+Sans' rel='stylesheet' type='text/css'>
    <!--BOOTSTRAP MAIN STYLES -->
    <link href="../css/bootstrap.css" rel="stylesheet" />
    <!--FONTAWESOME MAIN STYLE -->
    <link href="../css/font-awesome.min.css" rel="stylesheet" />
    <!--CUSTOM STYLE -->
    <link href="../css/style.css" rel="stylesheet" />
</head>
<body>
    <!-- NAV SECTION -->
    <div class="navbar navbar-inverse navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="../AdminPage/HomeAdmin.aspx">ENG'GBOY</a>
            </div>
            <div class="navbar-collapse collapse">
                <ul class="nav navbar-nav navbar-right">
                  
            </div>

        </div>
    </div>
    <!--END NAV SECTION -->
    <!-- ABOUT SECTION -->
    <div class="section">
        <div class="container">

            <div class="row main-low-margin">
                <div class="col-md-10 col-md-offset-1 col-sm-10 col-sm-offset-1">

                    <form id="main" runat="server">
                        <div class="container">
                            <div class="row">
                                <div class="box">
                                        <h1 class="brand-name">HOME ADMINISTRATOR</h1>
                                        <hr class="tagline-divider" />
                                        <h2>
                                            <small>
                                                <strong>Edit information shown in your page.</strong>
                                            </small>
                                        </h2>
                                        <hr class="tagline-divider" />
                                        <br />
                                        <small>
                                            <strong>ABOUT</strong>
                                        </small>
                                        <br />
                                        <asp:TextBox ID="txtAbout" runat="server" Height="250px" Width="500px" Style="text-align: left; vertical-align: top"></asp:TextBox>
                                        <br />
                                        <br />
                                        <small>
                                            <strong>CONTACT</strong>
                                        </small>
                                        <br />
                                        <asp:TextBox ID="txtContact" runat="server" Height="250px" Width="500px" Style="text-align: left; vertical-align: top"></asp:TextBox>
                                    &nbsp;<br />
                                        <br />
                                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmitEdit_Click" class="btn btn-default btn-lg"/>
                                        <br />
                                        <br />
                                        <a href="../Home.aspx">Logout</a>
                                        <br />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </form>

                </div>
            </div>


        </div>
    </div>

    <div class="space-bottom"></div>
    <!--END ABOUT SECTION -->

    <!--END FOOTER SECTION -->
    <!-- JAVASCRIPT FILES PLACED AT THE BOTTOM TO REDUCE THE LOADING TIME  -->
    <!-- CORE JQUERY LIBRARY -->
    <script src="../js/jquery.js"></script>
    <!-- CORE BOOTSTRAP LIBRARY -->
    <script src="../js/bootstrap.min.js"></script>

</body>
</html>
