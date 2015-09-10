using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectEulerWeb.ProblemViews
{
    public partial class EvenFibinacci : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EvenFibonacciClick(object sender, EventArgs e)
        {
            String inputText = EvenFibonacciInput.Text;
            if (inputText == null)
                throw new InvalidOperationException("Input cannot be null");

            Problems.EvenFibonacci problem = new Problems.EvenFibonacci();
            EvenFibonacciResponse.Text = problem.GetSumOfEvenFibonacci(Int32.Parse(inputText)).ToString();

        }

    }
}