<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LargestProductGridView.ascx.cs" Inherits="ProjectEulerWeb.ProblemViews.LargestProductGridView" %>
<div class="col-md-4 well">
    <h2>Largest Product</h2>
    <div class="row">
        <label for="Input">Grid</label>
        <asp:TextBox ID="Input" runat="server" Text="10"></asp:TextBox>
        <label for="InputLength">Length</label>
        <asp:TextBox ID="InputLength" runat="server" Text="1"></asp:TextBox>
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