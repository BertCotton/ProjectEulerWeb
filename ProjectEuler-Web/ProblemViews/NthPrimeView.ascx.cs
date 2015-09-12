using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectEulerWeb.ProblemViews
{
    public partial class NthPrimeView : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClickHandler(object sender, EventArgs e)
        {
            String inputText = Input.Text;
            if (inputText == null)
                throw new InvalidOperationException("Input cannot be null");

            Problems.NthPrimes problem = new Problems.NthPrimes();
            ProblemResponse.Text = problem.GetNthPrime(Int32.Parse(inputText)).ToString();

        }

    }

}