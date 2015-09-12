using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectEulerWeb.ProblemViews
{
    public partial class SummationOfPrimesView : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClickHandler(object sender, EventArgs e)
        {
            String inputText = Input.Text;
            if (inputText == null)
                throw new InvalidOperationException("Input cannot be null");

            Problems.SummationOfPrimes problem = new Problems.SummationOfPrimes();
            ProblemResponse.Text = problem.SumOfPrimes(Int64.Parse(inputText)).ToString();

        }
    }
}