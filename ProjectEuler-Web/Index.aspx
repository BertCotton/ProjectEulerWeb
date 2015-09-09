<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ProjectEuler_Web.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css">

    <script src="http://code.jquery.com/jquery-2.1.4.min.js"></script>
    <script src="http://code.jquery.com/jquery-2.1.4.min.map"></script>
    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>


    <title>Project Euler Tests</title>

</head>
<body>
    <form runat="server">
        <nav class="navbar navbar-inverse navbar-fixed-top"></nav>
        <div class="jumbotron">
            <div class="container">
                <h1>Project Euler C# Examples</h1>
                <p>This will have a list of solved problems from the Project Euler site</p>
            </div>
        </div>

        <div class="container">
            <div class="col-md-4 well">
                <h2>1. Multiples of 3 and 5</h2>
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
            <div class="col-md-4 well">
                <h2>2. Even Fibonacci</h2>
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
            <div class="col-md-4 well">
                <h2>4. Largest Palendrome</h2>
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
        </div>
    </form>
</body>
</html>
