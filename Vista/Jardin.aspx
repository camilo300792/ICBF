<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Jardin.aspx.cs" Inherits="Vista.Jardin" %>
<asp:Content ID="PageTitle" ContentPlaceHolderID="Title" runat="server">
    Crear Jardin
</asp:Content>
<asp:Content ID="PageContent" ContentPlaceHolderID="Content" runat="server">
    <div class="row">
        <div class="col-md-12">
            <label class="control-label" for="txtNombre">Nombre:</label>
            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtDireccion">Dirección:</label>
            <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="ddlEstadoJardin">Estado Jardin:</label>
            <asp:DropDownList ID="ddlEstadoJardin" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        &nbsp;
        <div class="col-md-12">
            <asp:Button ID="btnCrearJardin" runat="server" Text="Crear Jardin" CssClass="btn btn-block btn-success" OnClick="btnCrearAcudiente_Click"/>
        </div>
    </div>
</asp:Content>
