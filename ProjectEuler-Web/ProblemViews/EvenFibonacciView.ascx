<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EvenFibonacciView.ascx.cs" Inherits="ProjectEulerWeb.ProblemViews.EvenFibinacci" %>

<div class="col-md-4 well">
    <h2>Even Fibonacci</h2>
    <div class="row">
        <label for="EvenFibonacciInput">Upper bound</label>
        <asp:TextBox ID="EvenFibonacciInput" runat="server" Text="10"></asp:TextBox>
        <asp:Button OnClick="EvenFibonacciClick" runat="server" Text="Go" />
    </div>
    <% if (EvenFibonacciResponse.Text != null && EvenFibonacciResponse.Text.Length > 0)
        { %>
    <div class="row">
        <label for="EvenFibonacciResponse">Reponse</label>
        <asp:Label ID="EvenFibonacciResponse" runat="server"></asp:Label>
    </div>
    <% } %>
</div>
