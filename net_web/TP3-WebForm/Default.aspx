<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TP3TorresMariano._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="form-container">
        <asp:Label ID="Label1" runat="server" Text="Ingrese su nombre" CssClass="form-label"></asp:Label>
        <br />
        <div>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-input"></asp:TextBox>
        </div>

        <asp:Label ID="Label2" runat="server" Text="Seleccione su producto" CssClass="form-label"></asp:Label>
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-select">
                <asp:ListItem Text="Silla" Value="silla" />
                <asp:ListItem Text="Cama" Value="cama" />
                <asp:ListItem Text="Mesa" Value="mesa" />
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" Text="Agregar al carrito" CssClass="form-button" OnClick="Button1_Click" />
        </div>

        <asp:Label ID="Label3" runat="server" Text="Mi carrito de compras" CssClass="form-label"></asp:Label>
        <br />
        <asp:ListBox ID="ListBox1" runat="server" CssClass="form-listbox"></asp:ListBox>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Comprar" CssClass="form-button" OnClick="Button2_Click" />
        <br />
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    </section>
</asp:Content>
