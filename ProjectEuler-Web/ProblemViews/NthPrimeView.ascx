<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="NthPrimeView.ascx.cs" Inherits="ProjectEulerWeb.ProblemViews.NthPrimeView" %>

<div class="col-md-4 well">
    <h2>Nth Prime</h2>
    <div class="row">
        <label for="Input">Upper bound</label>
        <asp:TextBox ID="Input" runat="server" Text="10"></asp:TextBox>
        <asp:Button OnClick="ClickHandler" runat="server" Text="Go" />
    </div>
    <% if (ProblemResponse.Text != null && ProblemResponse.Text.Length > 0)
        { %>
    <div class="row">
        <label for="ProblemResponse">Reponse</label>
        <asp:Label ID="ProblemResponse" runat="server"></asp:Label>
    </div>
    <% } %>
</div>