<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Evaluacion_3.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <img id="cover" src="./Assets/gameplay.gif" class="vh-100 vw-100 img-fluid image position-absolute" alt="pokemon fire red gameplay">
    <div class="container-fluid d-flex flex-column">
        <div class="row vh-100 align-items-center">
            <div class="col-sm-12">
                <h1 class="text-center text-white header-title">Hey trainer!</h1>
                <p class="text-center text-white subtext">
                    Welcome to PokeTrainer
                </p>
                <div class="d-flex flex-row justify-content-center">
                        <a class="btn btn-success mt-5" href="AddTrainer.aspx">Add my trainers!</a>
                </div>

            </div>
        </div>
        <div class="row vh-100 align-items-center" id="about">
            <div class="col-sm-12 col-md-6">
                <h3 class="text-center"><strong>The best website to manage your pokemon teams</strong></h3>
                <p class="text-center">
                   PokeTrainer is a website where you can register and manage your team. It's so easy to use! 
                </p>

            </div>
            <div class="col-sm-12 col-md-6">
                <img src="./Assets/team.gif" class="w-100 h-100" alt="">
            </div>
        </div>
        <div class="row background align-items-center bkg">
            <div class="col-sm-12 vw-100">
                <h1 class=" h1 mt-5 pt-3 text-center" id="contact">Start managing now!</h1>
                <div class="d-grid gap-2">
                    <a class="btn btn-danger text-white mt-5" href="AddTrainer.aspx">Add my trainers!</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
