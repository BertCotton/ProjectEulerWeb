using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectEulerWeb.ProblemViews
{
    public partial class LargestPalendromeView : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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