<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="registroAsistencia.aspx.cs" Inherits="Vista.registroAsistencia" %>
<asp:Content ID="PageTitle" ContentPlaceHolderID="Title" runat="server">
    Registro de Asistencia
</asp:Content>
<asp:Content ID="ContentPage" ContentPlaceHolderID="Content" runat="server">
    <h1 class="text-center">Registrar Asistencia</h1>
    <h2 class="text-center">
        <asp:Label ID="lblFecha" runat="server"></asp:Label>
    </h2>
    <div class="row">
        <div class="col-md-12">
            <label class="control-label" for="ddlInfante">Infante:</label>
            <asp:DropDownList ID="ddlInfante" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="ddlEstadoInfante">Estado:</label>
            <asp:DropDownList ID="ddlEstadoInfante" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtFecha">Fecha:</label>
            <asp:TextBox ID="txtFecha" runat="server" CssClass="form-control" ReadOnly="true"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="cbxAsistencia">Asistencia:</label>
            <asp:CheckBox ID="cbxAsistencia" runat="server" CssClass="form-control"/>
        </div>
        <div class="col-md-12">
            <asp:Button runat="server" text="Guardar Registro de Asistencia" ID="btnRegistroAsistencia" CssClass="btn btn-block btn-success" OnClick="btnRegistroAsistencia_Click" />
        </div>
    </div>
</asp:Content>
