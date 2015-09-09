using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectEuler_Web
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MultiplesOf3And5Click(object sender, EventArgs e)
        {
            String inputText = multiplesOf3And5Input.Text;
            if (inputText == null)
                throw new InvalidOperationException("Input cannot be null");

            Problems.MultiplesOf3And5 problem = new Problems.MultiplesOf3And5();
            multiplesOf3And5Response.Text = problem.GetSumOfMultiples(Int32.Parse(inputText)).ToString();

        }

        protected void EvenFibonacciClick(object sender, EventArgs e)
        {
            String inputText = EvenFibonacciInput.Text;
            if (inputText == null)
                throw new InvalidOperationException("Input cannot be null");

            Problems.EvenFibonacci problem = new Problems.EvenFibonacci();
            EvenFibonacciResponse.Text = problem.GetSumOfEvenFibonacci(Int32.Parse(inputText)).ToString();

        }

        protected void LargestPrimeFactorClick(object sender, EventArgs e)
        {
            String inputText = LargestPrimeFactorInput.Text;
            if (inputText == null)
                throw new InvalidOperationException("Input cannot be null");

            Problems.LargestPrimeFactor problem = new Problems.LargestPrimeFactor();
            long startTime = DateTime.Now.Millisecond;
            LargestPrimeFactorResponse.Text = problem.getLargestPrimeFactor(Int64.Parse(inputText)).ToString();
            LargestPrimeFactorResponseTime.Text = (DateTime.Now.Millisecond - startTime).ToString();

        }

        protected void LargestPalendromeClick(object sender, EventArgs e)
        {
            String inputText = LargestPalendromeInput.Text;
            if (inputText == null)
                throw new InvalidOperationException("Input cannot be null");

            Problems.Palendrome problem = new Problems.Palendrome();
            long startTime = DateTime.Now.Millisecond;
            LargestPalendromeResponse.Text = problem.findBiggestPalendrome(Int64.Parse(inputText)).ToString();
            LargestPalendromeResponseTime.Text = (DateTime.Now.Millisecond - startTime).ToString();

        }
    }
}