using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectEulerWeb.ProblemViews
{
    public partial class SmallestMultipleView : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void SmallestMultipleClick(object sender, EventArgs e)
        {
            String lowerBound = SmallestMultipleLowerInput.Text;
            if (lowerBound == null)
                throw new InvalidOperationException("Input cannot be null");

            String uppperBound = SmallestMultipleUpperInput.Text;
            if (uppperBound == null)
                throw new InvalidOperationException("Upper bound input cannot be null");

            Problems.SmallestMultiple problem = new Problems.SmallestMultiple();
            SmallestMultipleResponse.Text = problem.GetSmallestMultiple(Int32.Parse(lowerBound), Int32.Parse(uppperBound)).ToString();

        }
    }
}