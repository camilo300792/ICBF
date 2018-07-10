<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="ListarJardines.aspx.cs" Inherits="Vista.ListarJardines" %>
<asp:Content ID="PageTitle" ContentPlaceHolderID="Title" runat="server">
    Jardines
</asp:Content>
<asp:Content ID="ContentPage" ContentPlaceHolderID="Content" runat="server">
    <h1 class="text-center">Jardines</h1>
    <asp:GridView ID="gvJardines" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered" DataKeyNames="idJardin" OnRowDataBound="gvJardines_RowDataBound" OnRowUpdating="gvJardines_RowUpdating" OnRowCancelingEdit="gvJardines_RowCancelingEdit" OnRowEditing="gvJardines_RowEditing" OnRowDeleting="gvJardines_RowDeleting">
        <HeaderStyle CssClass="bg-blue" ForeColor="White" />
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:Label ID="lblId" runat="server" Text='<%# Bind("idJardin") %>'></asp:Label>
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
            <asp:TemplateField HeaderText="Dirección">
                <ItemTemplate>
                    <asp:Label ID="lblDireccion" runat="server" Text='<%# Bind("_direccion") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox runat="server" ID="txtDireccion" CssClass="form-control" Text='<%# Bind("_direccion") %>'></asp:TextBox>
                </EditItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Estado Jardín">
                <ItemTemplate>
                    <asp:Label ID="lblEstado" runat="server" Text='<%# Bind("estadoJardin") %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:DropDownList ID="ddlEstadoJardin" runat="server" CssClass="form-control"></asp:DropDownList>
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
    </asp:GridView>
</asp:Content>