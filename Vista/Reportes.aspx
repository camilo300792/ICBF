<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaster.Master" AutoEventWireup="true" CodeBehind="Reportes.aspx.cs" Inherits="Vista.Reportes" %>

<asp:Content ID="PageTitle" ContentPlaceHolderID="Title" runat="server">
    ICBF | Reportes
</asp:Content>
<asp:Content ID="PageContent" ContentPlaceHolderID="Content" runat="server">
    <div class="table-responsive">
        <asp:GridView ID="gvAsistencias" runat="server" AutoGenerateColumns="false" CssClass="table table-bordered">
            <HeaderStyle CssClass="bg-blue" ForeColor="White" />
            <Columns>
                <asp:BoundField HeaderText="Infante" DataField="_nombre"/>
                <asp:BoundField HeaderText="Fecha" DataField="_fecha"/>
                <asp:BoundField HeaderText="Estado" DataField="_estado"/>
                <asp:TemplateField HeaderText="Asistencia">
                    <ItemTemplate>
                        <asp:Label runat="server" Text='<%# (Convert.ToByte(Eval("_asistencia"))  == 1) ? "Si":"No" %>'/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
