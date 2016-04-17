<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Notifications.aspx.cs" Inherits="ASP_Material.Notifications" Async="true"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="page-wrapper">
 
            <div class="row">
                <!-- Page Header -->
                <div class="col-lg-12">
                    <h1 class="page-header">Notificaciones</h1>
                </div>
                <!--End Page Header -->
            </div>

            
            <div class="row">
                <div class="col-lg-12">



                 
                    <!--Simple table example -->
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <i class="fa fa-bell fa-fw"></i>Enviar Notificación
                            <div class="pull-right">
                                
                            </div>
                        </div>

                        <div class="panel-body">
                            <div class="row">
                                <div class="col-lg-12">
                                    <div class="table-responsive">
                                        <center>
                                        <asp:Label ID="Label_Mensaje" runat="server" Text="Mensaje:"></asp:Label>
                                        <br /><br />
                                        <asp:TextBox ID="TextBoxMensaje" runat="server" Width="70%" class="form-control" ></asp:TextBox>
                                        <br />
                                        <asp:Button id="Button_Guardar" runat="server" type="submit" class="btn btn-facebook" Text="Enviar" OnClick="Button_Guardar_Click"/>
                                        <br />
                                        <br />
                                        <asp:Label ID="LabelAviso" runat="server" Text="Notificación Enviada Correctamente" ForeColor="Green" Visible="False"></asp:Label>
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
