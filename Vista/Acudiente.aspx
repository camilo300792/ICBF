<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Acudiente.aspx.cs" Inherits="Vista.test" %>
<asp:Content ID="PageTitle" ContentPlaceHolderID="Title" runat="server">
    Registrar Acudiente
</asp:Content>
<asp:Content ID="PageContent" ContentPlaceHolderID="Content" runat="server">
    <h1 class="text-center">Registrar Acudiente</h1>
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
            <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control"></asp:TextBox>
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
            <label class="control-label" for="txtCelular">Celular:</label>
            <asp:TextBox ID="txtCelular" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        &nbsp;
        <div class="col-md-12">
            <asp:Button ID="btnCrearAcudiente" runat="server" Text="Crear Acudiente" CssClass="btn btn-block btn-success" OnClick="btnCrearAcudiente_Click"/>
        </div>
    </div>
</asp:Content>
