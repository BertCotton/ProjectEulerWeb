using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectEulerWeb.ProblemViews
{
    public partial class LargestPrimeFactor : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

    }
}