<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AddTrainer.aspx.cs" Inherits="Evaluacion_3.AddTrainer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid" runat="server" ID="divAdd">
        <div class="row">
            <div class="col-sm-12 mx-auto mt-5 w-50">
                <div runat="server" ID="alertAdd" class="alert alert-success dsb" role="alert">
                    Trainer added successfully!
                </div>
                <h1 class="mt-3">Add Trainer </h1>
                <div class="form-group">
                    <label for="trainerName">Trainer Name</label>
                    <asp:TextBox ID="trainerName" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="trainerName" CssClass="text-danger" runat="server" ErrorMessage="Field must be completed!"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <label for="RadioButton1">Gender</label>
                    <asp:RadioButtonList ID="RadioButton1" runat="server">
                        <asp:ListItem Text=" Boy" Value="1" Selected="True"></asp:ListItem>
                        <asp:ListItem Text=" Girl" Value="2"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div class="form-group mt-3">
                    <label for="teamName">Team Name</label>
                    <asp:TextBox ID="teamName" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" ControlToValidate="teamName" CssClass="text-danger" runat="server" ErrorMessage="Field must be completed!"></asp:RequiredFieldValidator>
                </div>
                <div class="form-group mt-3">
                    <label for="pokemonTeam1">Pokemon n°1</label>
                    <asp:DropDownList ID="pokemonTeam1" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <div class="form-group mt-3">
                    <label for="pokemonTeam2">Pokemon n°2</label>
                    <asp:DropDownList ID="pokemonTeam2" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <div class="form-group mt-3">
                    <label for="pokemonTeam3">Pokemon n°3</label>
                    <asp:DropDownList ID="pokemonTeam3" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <div class="form-group mt-3">
                    <label for="pokemonTeam4">Pokemon n°4</label>
                    <asp:DropDownList ID="pokemonTeam4" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <div class="form-group mt-3">
                    <label for="pokemonTeam5">Pokemon n°5</label>
                    <asp:DropDownList ID="pokemonTeam5" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <div class="form-group mt-3">
                    <label for="pokemonTeam6">Pokemon n°6</label>
                    <asp:DropDownList ID="pokemonTeam6" runat="server" CssClass="form-control">
                    </asp:DropDownList>
                </div>
                <asp:Button ID="addTrainerBtn" CssClass="btn btn-success mt-5" OnClick="addTrainerBtn_Click" runat="server" Text="Submit" />
            </div>
        </div>
    </div>
   
</asp:Content>
