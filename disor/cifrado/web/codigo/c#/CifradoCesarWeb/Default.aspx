<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    	<asp:Label ID="Label1" runat="server" Text=" Texto Plano:"></asp:Label>
		<asp:TextBox ID="TextoPlano" runat="server" Height="61px" Width="159px" OnTextChanged="TextoPlano_TextChanged" TextMode="MultiLine"   AutoPostBack="True"></asp:TextBox>
		<br />
		<br /> CifradoCesar<br />
		<br />
		Desplazamiento:<br />

		<asp:ListBox ID="DesCesar" runat="server" Height="22px" style="margin-top: 33px" Width="44px" OnSelectedIndexChanged="DesCesar_SelectedIndexChanged" >
			<asp:ListItem Value="0">0</asp:ListItem>
			<asp:ListItem Value="1">1</asp:ListItem>
			<asp:ListItem Value="2">2</asp:ListItem>
			<asp:ListItem Value="3">3</asp:ListItem>
			<asp:ListItem Value="4">4</asp:ListItem>
		</asp:ListBox>
		<br />
		Texto Cifrado:<asp:TextBox ID="TextoCifrado" runat="server" Height="51px" Width="135px" ReadOnly="True" AutoPostBack="True" TextMode="MultiLine"></asp:TextBox>
		<br />
		<br />
		Texto Plano Invertido:<br />
		<br />
		<asp:TextBox ID="TextoInvertido" runat="server" Height="75px" Width="179px" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
		<br />
		<br />
			Organizar por Grupos:<br />

		<asp:ListBox ID="DesGrupo" runat="server" Height="22px" style="margin-top: 33px" Width="44px" OnSelectedIndexChanged="DesGrupo_SelectedIndexChanged">
			<asp:ListItem Value="0">0</asp:ListItem>
			<asp:ListItem Value="1">1</asp:ListItem>
			<asp:ListItem Value="2">2</asp:ListItem>
			<asp:ListItem Value="3">3</asp:ListItem>
			<asp:ListItem Value="4">4</asp:ListItem>
		</asp:ListBox>
		<br />
		<br />
			Texto:<asp:TextBox ID="TextoInvertidoxGrupo" runat="server" Height="53px" Width="168px" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
		<br />
    
    </div>
    </form>
</body>
</html>
