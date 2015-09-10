<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SmallestMultipleView.ascx.cs" Inherits="ProjectEulerWeb.ProblemViews.SmallestMultipleView" %>
<div class="col-md-4 well">
    <h2>Smallest Multiple</h2>
    <div class="row">
        <label for="SmallestMultipleLowerInput">Lower bound</label>
        <asp:TextBox ID="SmallestMultipleLowerInput" runat="server" Text="1"></asp:TextBox>
        <label for="SmallestMultipleUpperInput">Upper bound</label>
        <asp:TextBox ID="SmallestMultipleUpperInput" runat="server" Text="10"></asp:TextBox>
        <asp:Button OnClick="SmallestMultipleClick" runat="server" Text="Go" />
    </div>
    <% if (SmallestMultipleResponse.Text != null && SmallestMultipleResponse.Text.Length > 0)
        { %>
    <div class="row" id="SmallestMultipleResponseRow">
        <label for="SmallestMultipleResponse">Reponse</label>
        <asp:Label ID="SmallestMultipleResponse" runat="server"></asp:Label>
    </div>
    <% } %>
</div>
