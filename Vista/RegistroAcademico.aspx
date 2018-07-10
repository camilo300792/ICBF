<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="RegistroAcademico.aspx.cs" Inherits="Vista.RegistroAcademico" %>
<asp:Content ID="PageTitle" ContentPlaceHolderID="Title" runat="server">
    Registro Academico
</asp:Content>
<asp:Content ID="ContentPage" ContentPlaceHolderID="Content" runat="server">
    <h1 class="text-center">Registro Académico</h1>
    <div class="row">
        <div class="col-md-12">
            <label class="control-label" for="ddlInfante">Infante:</label>
            <asp:DropDownList ID="ddlInfante" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtAnioEscolar">Año escolar:</label>
            <asp:TextBox ID="txtAnioEscolar" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="ddlNivelAcademico">Nivel Academico:</label>
            <asp:DropDownList ID="ddlNivelAcademico" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="ddlNota">Nota:</label>
            <asp:DropDownList ID="ddlNota" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtDescripcion">Descripción:</label>
            <asp:TextBox ID="txtDescripcion" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="col-md-6">
            <label class="control-label" for="txtFechaEntrega">Fecha entrega:</label>
            <asp:TextBox ID="txtFechaEntrega" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
        </div>
        &nbsp;
        <div class="col-md-12">
            <asp:Button runat="server" text="Guardar Registro Academico" ID="btnRegistroAcademico" CssClass="btn btn-block btn-success" OnClick="btnRegistroAcademico_Click"/>
        </div>
    </div>
</asp:Content>
