<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaMaestra.Master" AutoEventWireup="true" CodeBehind="Lista.aspx.cs" Inherits="ListaAlumnos.Lista" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row center">
        <h1 class="">Lista</h1>
    
        <asp:CheckBoxList ID="che" runat="server" CssClass="center-align">

        </asp:CheckBoxList>
            
    </div>
</asp:Content>
