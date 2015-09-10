<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LargestPalendromeView.ascx.cs" Inherits="ProjectEulerWeb.ProblemViews.LargestPalendromeView" %>

<div class="col-md-4 well">
    <h2>Largest Palendrome</h2>
    <div class="row">
        <label for="LargestPalendromeInput">Upper bound</label>
        <asp:TextBox ID="LargestPalendromeInput" runat="server" Text="10"></asp:TextBox>
        <asp:Button OnClick="LargestPalendromeClick" runat="server" Text="Go" />
    </div>
    <% if (LargestPalendromeResponse.Text != null && LargestPalendromeResponse.Text.Length > 0)
        { %>
    <div class="row">
        <label for="LargestPalendromeResponse">Reponse</label>
        <asp:Label ID="LargestPalendromeResponse" runat="server"></asp:Label>
        in 
                        <asp:Label ID="LargestPalendromeResponseTime" runat="server"></asp:Label>ms
    </div>
    <% } %>
</div>
