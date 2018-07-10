<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Infante.aspx.cs" Inherits="Vista.Infante" %>
<asp:Content ID="PageTitle" ContentPlaceHolderID="Title" runat="server">
    Registrar Niño
</asp:Content>
<asp:Content ID="PageContent" ContentPlaceHolderID="Content" runat="server">
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
            <label class="control-label" for="txtDireccion">Dirección:</label>
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtTelefono">Teléfono:</label>
            <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" ></asp:TextBox>
        </div>
        <div class="col-md-12">
            <label class="control-label" for="ddlCiudadNacimiento">Ciudad de Nacimiento:</label>
            <asp:DropDownList ID="ddlCiudadNacimiento" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtFechaNacimiento">Fecha de Nacimiento:</label>
            <asp:TextBox ID="txtFechaNacimiento" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtFechaIngreso">Fecha de Ingreso:</label>
            <asp:TextBox ID="txtFechaIngreso" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtTipoSangre">Tipo de Sangre:</label>
            <asp:TextBox ID="txtTipoSangre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtPeso">Peso en Kg:</label>
            <asp:TextBox ID="txtPeso" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtTalla">Talla en Cm:</label>
            <asp:TextBox ID="txtTalla" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtEps">EPS:</label>
            <asp:TextBox ID="txtEps" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="ddlAcudiente">Acudiente:</label>
            <asp:DropDownList ID="ddlAcudiente" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="ddlJardin">Jardín:</label>
            <asp:DropDownList ID="ddlJardin" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        &nbsp;
        <div class="col-md-12">
            <asp:Button ID="btnCrearInfante" runat="server" Text="Registrar Infante" CssClass="btn btn-block btn-success" OnClick="btnCrearAcudiente_Click"/>
        </div>
    </div>
</asp:Content>
