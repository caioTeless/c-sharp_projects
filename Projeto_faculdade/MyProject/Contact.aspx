<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="MyProject.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-5 p-5 border">
                <h4>Nos envie um e-mail =)</h4>
                <form>
                    <div class="form-group">
                        <asp:Label ID="Error" Font-Size="16" ForeColor="Red" runat="server"></asp:Label>
                    </div>
                    <div class="form-group">
                        <label>Nome</label>
                        <asp:TextBox ID="Nome" autocomplete="off" placeholder="Insira um nome" CssClass="form-control" MaxLength="100" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>E-mail</label>
                        <asp:TextBox ID="Email" MaxLength="100" autocomplete="off" CssClass="form-control"
                            runat="server" placeholder="Insira um e-mail"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label>Mensagem</label>
                        <asp:TextBox ID="Mensagem" autocomplete="off" MaxLength="255" Columns="10" Rows="4"
                            runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="Enviar" OnClick="Enviar_Click" CssClass="btn btn-primary btn-block"
                            runat="server" Text="Enviar"/>
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
