<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="MadreComunitaria.aspx.cs" Inherits="Vista.MadreComunitaria" %>
<asp:Content ID="PageTitle" ContentPlaceHolderID="Title" runat="server">
    Registrar Madre Comunitaria
</asp:Content>
<asp:Content ID="ContentPage" ContentPlaceHolderID="Content" runat="server">
    <h1 class="text-center">Registrar Madre Comunitaria</h1>
    <div class="row">
        <div class="col-md-12">
            <label class="control-label" for="txtNombre">Nombre:</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtDocumento">Documento:</label>
            <asp:TextBox ID="txtDocumento" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="ddlTipoDocumento">Tipo Documento:</label>
            <asp:DropDownList ID="ddlTipoDocumento" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtCorreo">Correo:</label>
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtDireccion">Dirección:</label>
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtTelefono">Teléfono:</label>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtFechaNacimiento">Fecha de Nacimiento:</label>
            <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
        </div>
        &nbsp;
        <div class="col-md-12">
            <asp:Button ID="btnCrearMadreComunitaria" runat="server" Text="Registrar Madre Comunitaria" CssClass="btn btn-block btn-success" OnClick="btnCrearAcudiente_Click"/>
        </div>
    </div>
</asp:Content>

