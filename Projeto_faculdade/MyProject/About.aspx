<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="MyProject.About" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-12">
                <div class="margin-top-40 border-card">
                    <div>
                        <h4 class="text-center text-white display-4">
                            <img class="box-img-about" src="Imagens/mundo-conectado.jpg" />
                        </h4>
                    </div>
                    <div class="margin-top-40">
                        Nome
                        <h5 class="text-center font-weight-bold">Empresa nanana, Cnpj 0000001/00 - 00</h5>

                        Telefone
                        <h5 class="text-center font-weight-bold">(21)3232 - 3232</h5>

                        E-mail <a href="#" class="text-center btn btn-link">empresananan@empresa.com.br</a>

                    </div>
                </div>
            </div>
            <div class="col-md-5 mt-4 mb-2 border d-flex align-items-center">
                <div class="p-2">
                    <img width="100%" src="Imagens/ia-1.jpg" />
                </div>
            </div>
            <div class="col-md-5 mt-4 mb-2 border d-flex align-items-center">
                <div class="p-2">
                    <img width="100%" src="Imagens/ia-1.jpg" />

                </div>
            </div>

            <div class="col-md-12 mt-2 p-5">
                <div class="back-about">
                    asdsad
                </div>
            </div>
            <div class="col-md-5">
                <form>
                    <div class="form-group p-5">
                        <label class="font-weight-bold font-italic">Informe um e-mail para receber atualizações</label>
                        <input type="email" placeholder="email@exemplo.com" class="form-control mt-2 mb-2" />
                        <button type="button" class="mt-2 btn btn-outline-primary btn-block">Cadastra-se</button>
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>
