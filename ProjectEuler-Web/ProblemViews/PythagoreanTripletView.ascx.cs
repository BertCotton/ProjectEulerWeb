using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectEulerWeb.ProblemViews
{
    public partial class PythagoreanTripletView : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClickHandler(object sender, EventArgs e)
        {
            String sourceInput = Input.Text;
            if (sourceInput == null)
                throw new InvalidOperationException("Input cannot be null");

            Problems.PythagoreanTripplet problem = new Problems.PythagoreanTripplet();
            ProblemResponse.Text = problem.FindProduct(Int64.Parse(sourceInput)).ToString();

        }
    }
}