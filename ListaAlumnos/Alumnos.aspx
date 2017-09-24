<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Alumnos.aspx.cs" Inherits="ListaAlumnos.Alumnos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:TextBox runat="server" ID="txtID" Visible="false"></asp:TextBox>
            <div class="input-field col s6">
                <asp:TextBox runat="server"  ID="txtnombres" CssClass="validate"></asp:TextBox>
                <label for="txtnombres">Nombres</label>
            </div>
            <div class="input-field col s6">
                <asp:TextBox runat="server"  ID="txtapellidos" CssClass="validate"></asp:TextBox>
                <label for="txtnombres">Apellidos</label>
            </div>

        </div>
        <div class="row">
            <div class="input-field col s6">
                <asp:TextBox runat="server"  ID="txtGrado" CssClass="validate"></asp:TextBox>
                <label for="txtGrado">Grado</label>
            </div>
            <div class="input-field col s6">
                <asp:TextBox runat="server" ID="txtGrupo" CssClass="validate"></asp:TextBox>
                <label for="txtGrupo">Grupo</label>
            </div>
        </div>
        <div class="row">
            <asp:Button CssClass="waves-effect waves-light btn" runat="server" ID="btnAgregar" Text="Agregar" />
            <asp:Button CssClass="waves-effect waves-light btn" runat="server" ID="btnModificar" Text="Modificar" />
            <asp:Button CssClass="waves-effect waves-light btn" runat="server" ID="btnEliminar" Text="Eliminar" />
            
        </div>
        <div class="row">
            <asp:GridView runat="server" ID="gvAlumnos">
            </asp:GridView>
        </div>
    </div>
</asp:Content>
