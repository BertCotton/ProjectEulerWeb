<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ProjectEulerWeb.Index" %>

<%@ Register TagPrefix="problems" TagName="SmallestMultiple" Src="~/ProblemViews/SmallestMultipleView.ascx" %>
<%@ Register TagPrefix="problems" TagName="LargestPalendrom" Src="~/ProblemViews/LargestPalendromeView.ascx" %>
<%@ Register TagPrefix="problems" TagName="LargestPrimeFactor" Src="~/ProblemViews/LargestPrimeFactor.ascx" %>
<%@ Register TagPrefix="problems" TagName="EvenFibonacci" Src="~/ProblemViews/EvenFibonacciView.ascx" %>
<%@ Register TagPrefix="problems" TagName="MultiplesOf3and5" Src="~/ProblemViews/MultiplesOf3and5.ascx" %>
<%@ Register TagPrefix="problems" TagName="SumSquareDifference" Src="~/ProblemViews/SumSquareDifferenceView.ascx" %>
<%@ Register TagPrefix="problems" TagName="NthPrime" Src="~/ProblemViews/NthPrimeView.ascx" %>
<%@ Register TagPrefix="problems" TagName="LargestProductInSeries" Src="~/ProblemViews/LargestProductInSeriesView.ascx" %>
<%@ Register TagPrefix="problems" TagName="PythagoreanTripplet" Src="~/ProblemViews/PythagoreanTripletView.ascx" %>
<%@ Register TagPrefix="problems" TagName="SummationOfPrimes" Src="~/ProblemViews/SummationOfPrimesView.ascx" %>
<%@ Register TagPrefix="problems" TagName="LargestProductGrid" Src="~/ProblemViews/LargestProductGridView.ascx" %>


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
            <problems:MultiplesOf3and5 runat="server" />
            <problems:EvenFibonacci runat="server" />
            <problems:LargestPrimeFactor runat="server" />
            <problems:LargestPalendrom runat="server" />
            <problems:SmallestMultiple runat="server" />
            <problems:SumSquareDifference runat="server" />
            <problems:NthPrime runat="server" />
            <problems:LargestProductInSeries runat="server" />
            <problems:PythagoreanTripplet runat="server" />
            <problems:SummationOfPrimes runat="server"/>
            <problems:LargestProductGrid runat="server"/>
        </div>
    </form>
</body>
</html>
