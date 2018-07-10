<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="ListarAcudientes.aspx.cs" Inherits="Vista.ListarAcudientes" %>
<asp:Content ID="PageTitle" ContentPlaceHolderID="Title" runat="server">
    Acudientes
</asp:Content>
<asp:Content ID="ContentPage" ContentPlaceHolderID="Content" runat="server">
    <h1 class="text-center">Acudientes</h1>
    <div class="table-responsive">
        <asp:GridView ID="dgvAcudientes" runat="server" CssClass="table table-bordered" AutoGenerateColumns="False" DataKeyNames="_idUsuario" OnRowEditing="dgvAcudientes_RowEditing" OnRowCancelingEdit="dgvAcudientes_RowCancelingEdit" OnRowDeleting="dgvAcudientes_RowDeleting" OnRowUpdating="dgvAcudientes_RowUpdating" OnRowDataBound="dgvAcudientes_RowDataBound">
            <HeaderStyle CssClass="bg-blue" ForeColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="ID">
                    <ItemTemplate>
                        <asp:Label ID="lblId" runat="server" Text='<%# Bind("_idUsuario") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Nombre">
                    <ItemTemplate>
                        <asp:Label ID="lblNombre" runat="server" Text='<%# Bind("_nombre") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" Text='<%# Bind("_nombre") %>'></asp:TextBox>
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
                <asp:TemplateField HeaderText="Documento">
                    <ItemTemplate>
                        <asp:Label ID="lblDocumento" runat="server" Text='<%# Bind("_documento") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtDocumento" runat="server" Text='<%# Bind("_documento") %>' CssClass="form-control"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Dirección">
                    <ItemTemplate>
                        <asp:Label ID="lblDireccion" runat="server" Text='<%# Bind("_direccion") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtDireccion" runat="server" Text='<%# Bind("_direccion") %>' CssClass="form-control"></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Correo">
                    <ItemTemplate>
                        <asp:Label ID="lblCorreo" runat="server" Text='<%# Bind("_correo") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtCorreo" runat="server" CssClass="form-control" Text='<%# Bind("_correo") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Teléfono">
                    <ItemTemplate>
                        <asp:Label ID="lblTelefono" runat="server" Text='<%# Bind("_telefono") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control" Text='<%# Bind("_telefono") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Celular">
                    <ItemTemplate>
                        <asp:Label ID="lblCelular" runat="server" Text='<%# Bind("_Celular") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="txtCelular" runat="server" CssClass="form-control" Text='<%# Bind("_celular") %>'></asp:TextBox>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="btnEditar" runat="server" Text="Editar" CssClass="btn btn-info" CommandName="Edit" CausesValidation="false"></asp:LinkButton>
                        <asp:LinkButton ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" CommandName="Delete"></asp:LinkButton>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" CommandName="Update" CausesValidation="true"></asp:LinkButton>
                        <asp:LinkButton ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-warning" CommandName="Cancel" CausesValidation="false"></asp:LinkButton>
                    </EditItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>

