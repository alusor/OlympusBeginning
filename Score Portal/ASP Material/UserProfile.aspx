<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="ASP_Material.UserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="page-wrapper">
 
            <div class="row">
                <!-- Page Header -->
                <div class="col-lg-12">
                    <h1 class="page-header">Perfil de Usuario</h1>
                </div>
                <!--End Page Header -->
            </div>

            <div class="row">
                <div class="col-lg-12">
                    <!-- Nueva-->
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <i class="fa fa-shopping-cart fa-fw"></i> <asp:Label ID="LabelIngresar" runat="server">Usuario</asp:Label>
                        </div>

                        <div class="panel-body">                      
                            <asp:TextBox ID="TextBox_Id" runat="server" Visible="false"></asp:TextBox>      
                            <asp:Label ID="Label_Usuario" runat="server" Text="Usuario"></asp:Label>
                    <asp:Label ID="Label_UsuarioMensaje" runat="server" ForeColor="Red"></asp:Label>
                    <br /> 
                    <asp:TextBox ID="TextBox_Usuario" runat="server" class="form-control" onkeypress="return solonumeros(event);" OnTextChanged="TextBox_Telefono_TextChanged" ReadOnly="true"></asp:TextBox>
                    <br />
                            <asp:Label ID="Label_Nombre" runat="server" Text="Nombre"></asp:Label>
                    <asp:Label ID="Label_MensajeProveedor" runat="server" ForeColor="Red"></asp:Label>
                    <br /> 
                    <asp:TextBox ID="TextBox_Nombre" runat="server" class="form-control" ></asp:TextBox>
                    <br />
                                        
                    <asp:Label ID="Label_Contraseña" runat="server" Text="Cambiar Contraseña"></asp:Label>
                    <asp:Label ID="Label_ContraseñaMensaje" runat="server" ForeColor="Red"></asp:Label>
                    <br /> 
                    <asp:TextBox ID="TextBox_Contraseña" runat="server" class="form-control" OnTextChanged="TextBox_Contraseña_TextChanged"></asp:TextBox>

                    <asp:Label ID="Label_Mensaje" runat="server" ForeColor="Red"></asp:Label>
                    <br /> 
                    
                            <asp:Button id="Button_Guardar" runat="server" type="submit" class="btn btn-success" Text="Guardar" OnClick="Button_Guardar_Click"/>
                            <asp:Button id="Button_Actualizar" runat="server" type="submit" class="btn btn-success" Text="Actualizar" OnClick="Button_Actualizar_Click"/>
                            <asp:Button id="Button_Cancelar" runat="server" type="submit" class="btn btn-danger" Text="Cancelar" OnClick="Button_Cancelar_Click"/>
                        </div>
                    </div>
                </div>
            </div>

            <div class="row">

                

            </div>
        </div>
        <!-- end page-wrapper -->
    <asp:TextBox ID="texto" runat="server" Visible="true" Value="" Height="0px" Width="0px"></asp:TextBox>
   
</asp:Content>
