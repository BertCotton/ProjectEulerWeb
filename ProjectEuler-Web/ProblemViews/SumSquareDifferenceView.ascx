<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SumSquareDifferenceView.ascx.cs" Inherits="ProjectEulerWeb.ProblemViews.SumSquareDifferenceView" %>

<div class="col-md-4 well">
    <h2>Sum Square Difference</h2>
    <div class="row">
        <label for="SumSquareDifferenceLowerInput">Lower bound</label>
        <asp:TextBox ID="SumSquareDifferenceLowerInput" runat="server" Text="1"></asp:TextBox>
        <label for="SumSquareDifferenceUpserInput">Upper bound</label>
        <asp:TextBox ID="SumSquareDifferenceUpserInput" runat="server" Text="10"></asp:TextBox>
        <asp:Button OnClick="SumSquareDifferenceClick" runat="server" Text="Go" />
    </div>
    <% if (SumSquareDifferenceResponse.Text != null && SumSquareDifferenceResponse.Text.Length > 0)
        { %>
    <div class="row">
        <label for="SumSquareDifferenceResponse">Reponse</label>
        <asp:Label ID="SumSquareDifferenceResponse" runat="server"></asp:Label>
    </div>
    <% } %>
</div>
