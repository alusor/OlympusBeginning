<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_Material.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--  page-wrapper -->
     
        <div id="page-wrapper">
 
            <div class="row">
                <!-- Page Header -->
                <div class="col-lg-8">
                    <h1 class="page-header">Principal</h1>
                </div>
                <!--End Page Header -->
            </div>

            <div class="row">
                <!-- Welcome -->
                <div class="col-lg-12">
                    <div class="alert alert-info">
                        <center>
                        <asp:Label ID="MensajeBienvenida" runat="server" Text="¡Bienvenido al portal Olympus Beginning!"></asp:Label>
                        </center>
                    </div>
                </div>
                <!--end  Welcome -->
            </div>
            <div class="row">
                <div class="col-lg-12">

                    <!--Simple table Win Mobile -->
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <i class="fa fa-gamepad fa-fw"></i> Score
                        </div>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-lg-12">
                                    <div class="table-responsive">
                                        <center>
                                        <asp:Label ID="ScoreActual" runat="server" Font-Bold="True" Font-Size="XX-Large"></asp:Label>
                                        </center>
                                    </div>

                                </div>

                            </div>
                            <!-- /.row -->
                        </div>
                        <!-- /.panel-body -->
                    </div>
                    <!--End simple table -->
                    
                    <!--Simple table Win Desktop -->
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <i class="fa fa-gamepad fa-fw"></i> ScoreBoard
                        </div>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-lg-12">
                                    <div class="table-responsive">
                                        <center>
                                        <asp:GridView runat="server" ID="grvScoreBoard" class="table table-bordered table-striped" BorderStyle="Solid" BorderWidth="2px" CellPadding="4"></asp:GridView>
                                        </center>
                                    </div>

                                </div>

                            </div>
                            <!-- /.row -->
                        </div>
                        <!-- /.panel-body -->
                    </div>
                    <!--End simple table example -->
                    
                     
               
                </div>
            </div>  
</asp:Content>
