<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LargestPrimeFactor.ascx.cs" Inherits="ProjectEulerWeb.ProblemViews.LargestPrimeFactor" %>
<div class="col-md-4 well">
    <h2>3. Largest Prime Factor</h2>
    <div class="row">
        <label for="LargestPrimeFactorInput">Upper bound</label>
        <asp:TextBox ID="LargestPrimeFactorInput" runat="server" Text="10"></asp:TextBox>
        <asp:Button OnClick="LargestPrimeFactorClick" runat="server" Text="Go" />
    </div>
    <% if (LargestPrimeFactorResponse.Text != null && LargestPrimeFactorResponse.Text.Length > 0)
        { %>
    <div class="row">
        <label for="LargestPrimeFactorResponse">Reponse</label>
        <asp:Label ID="LargestPrimeFactorResponse" runat="server"></asp:Label>
        in 
                        <asp:Label ID="LargestPrimeFactorResponseTime" runat="server"></asp:Label>ms
    </div>
    <% } %>
</div>
