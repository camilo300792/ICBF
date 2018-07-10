<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="ListarMadresComunitarias.aspx.cs" Inherits="Vista.ListarMadresComunitarias" %>
<asp:Content ID="PageTitle" ContentPlaceHolderID="Title" runat="server">
    Madres Comunitarias
</asp:Content>
<asp:Content ID="ContentPage" ContentPlaceHolderID="Content" runat="server">
    <asp:Gridview CssClass="table table-bordered" ID="gvMadresComunitarias" runat="server" OnRowDataBound="gvMadresComunitarias_RowDataBound" OnRowDeleting="gvMadresComunitarias_RowDeleting" OnRowEditing="gvMadresComunitarias_RowEditing" OnRowUpdating="gvMadresComunitarias_RowUpdating" DataKeyNames="_idUsuario" AutoGenerateColumns="False" OnRowCancelingEdit="gvMadresComunitarias_RowCancelingEdit">
       <HeaderStyle CssClass="bg-blue" ForeColor="White" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Label ID="lblId" runat="server" Text='<%# Bind("_idUsuario") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Nombre">
                <ItemTemplate>
                    <asp:Label ID="lblNombre" runat="server" Text='<%# Bind("_nombre") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control" Text='<%# Bind("_nombre") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Documento">
                <ItemTemplate>
                    <asp:Label ID="lblDocumento" runat="server" Text='<%# Bind("_documento") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" ID="txtDocumento" CssClass="form-control" Text='<%# Bind("_documento") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Tipo Documento">
                <ItemTemplate>
                    <asp:Label ID="lblTipoDocumento" runat="server" Text='<%# Bind("_tipoDocumento") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:DropDownList ID="ddlTipoDocumento" runat="server" CssClass="form-control"></asp:DropDownList>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Fecha Nacimiento">
                <ItemTemplate>
                    <asp:Label ID="lblFechaNacimiento" runat="server" Text='<%# Bind("_fechaNacimiento") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" ID="txtFechaNacimiento" CssClass="form-control" TextMode="Date" Text='<%# Bind("_fechaNacimiento") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Correo">
                <ItemTemplate>
                    <asp:Label ID="lblCorreo" runat="server" Text='<%# Bind("_correo") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" ID="txtCorreo" CssClass="form-control" TextMode="Email" Text='<%# Bind("_correo") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Dirección">
                <ItemTemplate>
                    <asp:Label ID="lblDireccion" runat="server" Text='<%# Bind("_direccion") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control" Text='<%# Bind("_direccion") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Teléfono">
                <ItemTemplate>
                    <asp:Label ID="lblTelelfono" runat="server" Text='<%# Bind("_telefono") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" ID="txtTelefono" CssClass="form-control" Text='<%# Bind("_telefono") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton ID="lbEditar" runat="server" CssClass="btn btn-primary" Text="Editar" CausesValidation="false" CommandName="Edit"></asp:LinkButton>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:LinkButton ID="lbActualizar" runat="server" CssClass="btn btn-success" Text="Actualizar" CausesValidation="true" CommandName="Update"></asp:LinkButton>
                    <asp:LinkButton ID="lbCancelar" runat="server" CssClass="btn btn-warning" Text="Cancelar" CausesValidation="false" CommandName="Cancel"></asp:LinkButton>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" >
                <ControlStyle CssClass="btn btn-danger" ForeColor="White" />
            </asp:CommandField>
        </Columns>
    </asp:Gridview>
</asp:Content>
