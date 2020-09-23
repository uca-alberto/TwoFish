<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TwoFishExample._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>TWOTFISH</h1>
        <p><a> Ejemplo del metodo de seguridad</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
          <label>Encriptar Mensaje</label>
            <asp:TextBox runat="server" ID="TxtMessage" CssClass=""/>
            <asp:Button runat="server" ID="BtnEncriptar" CssClass="btn-success" OnClick="BtnEncriptar_Click" Text="Encriptar"/>
        </div>
    </div>
	<br />
	<br />

	<div class="row">
		 <div class="col-md-4">
          <label>Mensaje Encriptado</label>
           <textarea runat="server" id="TxtAreaEncriptado"/>
            <asp:Button runat="server" ID="BtnEnviar" CssClass="btn-info" OnClick="BtnEnviar_Click" Text="Enviar" />
        </div>
	</div>
	<br />
	<br />

	<div class="row">
		<div class="col-md-4">
           <label>Respuesta de Peticion</label>
            <asp:Label runat="server" ID="LbRespuesta"/>
        </div>
	</div>

</asp:Content>
