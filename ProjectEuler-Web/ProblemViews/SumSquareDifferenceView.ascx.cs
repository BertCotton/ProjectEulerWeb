using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectEulerWeb.ProblemViews
{
    public partial class SumSquareDifferenceView : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SumSquareDifferenceClick(object sender, EventArgs e)
        {
            string lowerBound = SumSquareDifferenceLowerInput.Text;
            if (lowerBound == null)
                throw new InvalidOperationException("Lower bound cannot be null");

            string upperBound = SumSquareDifferenceUpserInput.Text;
            if (upperBound == null)
                throw new InvalidOperationException("Upper bound cannot be null");

            Problems.SumSquareDifference problem = new Problems.SumSquareDifference();
            SumSquareDifferenceResponse.Text = problem.Difference(Int64.Parse(lowerBound), Int64.Parse(upperBound)).ToString();

        }
    }
}