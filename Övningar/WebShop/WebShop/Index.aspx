<%@ Page Title="" Language="C#" MasterPageFile="Master_Page.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Ecommerce_v2.pages.Index" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MasterPageContent" runat="server">

    <div class="container" style="margin-top: 150px">
        <div class="voffset-20">
            <!-- Full Page Image Background Carousel Header -->
            <div id="myCarousel" class="carousel slide center" data-ride="carousel">
                <!-- Indicators -->
                <ol class="carousel-indicators">
                    <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
                    <li data-target="#myCarousel" data-slide-to="1"></li>
                    <li data-target="#myCarousel" data-slide-to="2"></li>
                </ol>
                <!-- Wrapper for slides -->
                <div class="carousel-inner" role="listbox">
                    <div class="item active">
                        <img src="../images/Index/001.jpg" alt="" />
                    </div>

                    <div class="item">
                        <img src="../images/Index/002.jpg" alt="" />
                    </div>

                    <div class="item">
                        <img src="../images/Index/003.jpg" alt="" />
                    </div>
                </div>

                <!-- Left and right controls -->
                <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                    <span class="sr-only">Previous</span>
                </a>
                <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
                    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
                    <span class="sr-only">Next</span>
                </a>
            </div>
        </div>
    </div>
    <!-- -------------------------------------------------------------------------------- -->
    <div class="container">
        <div class="voffset30">
            <!-- Grids -->
            <div class="row">
                <div class="col-xs-4">
                    <a href="#" class="thumbnail">
                        <img src="../images/Index/t01.jpg" alt="..." />
                    </a>
                </div>
                <div class="col-xs-4">
                    <a href="#" class="thumbnail">
                        <img src="../images/Index/t02.jpg" alt="..." />
                    </a>
                </div>
                <div class="col-xs-4">
                    <a href="#" class="thumbnail">
                        <img src="../images/Index/t03.jpg" alt="..." />
                    </a>
                </div>
            </div>
        </div>
    </div>
    <!-- -------------------------------------------------------------------------------- -->
    <div class="container">
        <div class="voffset10">
            <div class="row">
                <div class="col-xs-12">
                    <h4 class="text-center">Herrskjortor, kostymer, chinos - skräddarsydda efter dina mått</h4>
                </div>
            </div>
        </div>
    </div>
    <!-- -------------------------------------------------------------------------------- -->
    <div id="kunderna-box">
        <div class="voffset10">
            <div class="row">
                <div class="container">
                    <div class="col-xs-4 text-center">
                        <i class="fa fa-quote-right fa-4x" aria-hidden="true"></i>
                        <h3>Kunderna berättar</h3>
                    </div>
                    <div class="col-xs-6">
                        <blockquote cite="http://www.worldwildlife.org/who/index.html">
                            “Enda nackdelen med era kläder är att man plötsligt blir 
                            missnöjd med passformen på de kläder man redan har i garderoben.”
                <h4>Jakob N.
                    Sweden
                </h4>
                        </blockquote>
                    </div>
                </div>
                <div class="col-xs-12">
                    <img src="../images/Global/Meastape.png" alt="..." />
                </div>
                <br />
                <br />
                <br />
            </div>
        </div>
    </div>
    <!-- -------------------------------------------------------------------------------- -->
    <!-- Mainly scripts -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.1.0/jquery.min.js"></script>
    <script src="../js/bootstrap.min.js"></script>

</asp:Content>
