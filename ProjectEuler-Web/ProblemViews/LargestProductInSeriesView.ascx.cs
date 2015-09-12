using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectEulerWeb.ProblemViews
{
    public partial class LargestProductInSeriesView : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClickHandler(object sender, EventArgs e)
        {
            String sourceInput = SourceInput.Text;
            if (sourceInput == null)
                throw new InvalidOperationException("Input cannot be null");

            String adjacentLength = ProductLengthInput.Text;
            if (adjacentLength == null)
                throw new InvalidOperationException("Input cannot be null");

            Problems.LargestProductInSeries problem = new Problems.LargestProductInSeries();
            ProblemResponse.Text = problem.FindLargestProduct(sourceInput, Int64.Parse(adjacentLength)).ToString();

        }
    }
}