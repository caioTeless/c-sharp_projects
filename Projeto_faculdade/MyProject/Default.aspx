<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyProject.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-4 box-col">
                <img class="default-img" src="Imagens/beneficio-1.jpg" />
                <p class="p-box">
                    Contrary to popular belief, Lorem Ipsum is not simply 
                    random text. It has roots in a piece of classical Latin
                    literature from 45 BC, making it over 2000 years old. 
                    Richard McClintock, a Latin professor at Hampden-Sydney
                    College in Virginia, looked up one of the more obscure
                    Latin words, consectetur, from a Lorem Ipsum passage,
                    and going through the cites of the word in classical
                    literature, discovered the undoubtable source.
                </p>
            </div>
            <div class="col-md-4 box-col">
                <img class="default-img" src="Imagens/beneficio-2.jpg" />
                <p class="p-box">
                    Contrary to popular belief, Lorem Ipsum is not simply 
                    random text. It has roots in a piece of classical Latin
                    literature from 45 BC, making it over 2000 years old. 
                    Richard McClintock, a Latin professor at Hampden-Sydney
                    College in Virginia, looked up one of the more obscure
                    Latin words, consectetur, from a Lorem Ipsum passage,
                    and going through the cites of the word in classical
                    literature, discovered the undoubtable source.
                </p>
            </div>
            <div class="col-md-4 box-col">
                <img class="default-img" src="Imagens/beneficio-3.jpg" />
                <p class="p-box">
                    Contrary to popular belief, Lorem Ipsum is not simply 
                    random text. It has roots in a piece of classical Latin
                    literature from 45 BC, making it over 2000 years old. 
                    Richard McClintock, a Latin professor at Hampden-Sydney
                    College in Virginia, looked up one of the more obscure
                    Latin words, consectetur, from a Lorem Ipsum passage,
                    and going through the cites of the word in classical
                    literature, discovered the undoubtable source.
                </p>
            </div>
            <div class="col-md-10 mt-3 mb-3 border-top border-bottom">
                <h3 class="display-4  text-center">Differences</h3>
            </div>
            <div class="col-md-10"><!-- CAROUSEL--><!--A SER FEITO-->
                <div id="homeCarousel" class="carousel slide" data-ride="carousel">
                    <ol class="carousel-indicators">
                        <li data-target="#homeCarousel" data-slide-to="0" class="active"></li>
                        <li data-target="#homeCarousel" data-slide-to="1"></li>
                        <li data-target="#homeCarousel" data-slide-to="2"></li>
                    </ol>
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <img class="d-block w-100 img-general2" src="Imagens/Mundo-dedo-tecnologia-2.jpg" />
                        </div>
                        <div class="carousel-item">
                            <img class="d-block w-100 img-general2" src="Imagens/Mundo-dedo-tecnologia-3.jpg" />
                        </div>
                        <div class="carousel-item">
                            <img class="d-block w-100 img-general2" src="Imagens/Mundo-dedo-tecnologia.jpg" />
                        </div>
                    </div>
                    <a class="carousel-control-prev" href="#homeCarousel" role="button" data-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="sr-only">Previous</span>
                    </a>
                    <a class="carousel-control-next" href="#homeCarousel" role="button" data-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="sr-only">Next</span>
                    </a>
                </div>
            </div>
            <div class="col-md-5 mr-2 mt-3 ">
                <h3 class="display-4  text-center">Differences</h3>
                <img class="default-img" src="Imagens/ia-1.jpg" />
            </div>
            <div class="col-md-5 mt-3">
                <h3 class="display-4  text-center">Differences</h3>
                <img class="default-img" src="Imagens/ia-2.jpg" />
            </div>

            <div class="col-md-12">
                <p class="border-top border-bottom mt-5 mb-5" style="font-size: 20px;">
                    Contrary to popular belief, Lorem Ipsum is not simply 
                    random text. It has roots in a piece of classical Latin
                    literature from 45 BC, making it over 2000 years old. 
                    Richard McClintock, a Latin professor at Hampden-Sydney
                    College in Virginia, looked up one of the more obscure
                    Latin words, consectetur, from a Lorem Ipsum passage,
                    and going through the cites of the word in classical
                    literature, discovered the undoubtable source.
                </p>
            </div>
            <div class="col-md-12">
                <img class="img-general h-75" src="Imagens/ia-3.jpg" />
                <p class="text-center" style="margin-top: 20px;cursor:pointer;font-size: 30px;">
                    <a class="text-dark text-decoration-none">O que há por trás da tecnologia ?</a>
                </p>
            </div>
            <br />
            <br />
        </div>
    </div>
</asp:Content>
