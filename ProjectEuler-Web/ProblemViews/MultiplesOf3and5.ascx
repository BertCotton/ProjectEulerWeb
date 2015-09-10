<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MultiplesOf3and5.ascx.cs" Inherits="ProjectEulerWeb.ProblemViews.MultiplesOf3and5" %>
<div class="col-md-4 well">
    <h2>Multiples of 3 and 5</h2>
    <div class="row">
        <label for="multiplesOf3And5Input">Upper bound</label>
        <asp:TextBox ID="multiplesOf3And5Input" runat="server" Text="10"></asp:TextBox>
        <asp:Button OnClick="MultiplesOf3And5Click" runat="server" Text="Go" />
    </div>
    <% if (multiplesOf3And5Response.Text != null && multiplesOf3And5Response.Text.Length > 0)
        { %>
    <div class="row" id="multiplesOf3And5ResponseRow">
        <label for="multiplesOf3And5Response">Reponse</label>
        <asp:Label ID="multiplesOf3And5Response" runat="server"></asp:Label>
    </div>
    <% } %>
</div>
