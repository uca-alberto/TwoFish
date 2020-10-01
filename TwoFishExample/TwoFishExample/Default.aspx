<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TwoFishExample._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>TWO FISH</h1>
        <p><a> Ejemplo del metodo de seguridad</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
          <label>Encriptar Mensaje</label>
            <asp:TextBox  runat="server" ID="TxtMessage" CssClass=""/>
            <asp:Button runat="server" ID="BtnEncriptar" CssClass="btn-success" OnClick="BtnEncriptar_Click" Text="Encriptar"/>
            <asp:Button runat="server" ID="btnDesEncriptar" CssClass="btn-success" OnClick="btnDesEncriptar_click" Text="DesEncriptar"/>
        </div>
    </div>
	<br />
	<br />

	<div class="row">
		 <div class="col-md-4">
          <label>Mensaje Encriptado</label>
           <textarea runat="server" id="TxtAreaEncriptado"></textarea>
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
