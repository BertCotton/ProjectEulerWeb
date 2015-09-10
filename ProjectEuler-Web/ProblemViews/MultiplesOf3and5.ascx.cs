using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectEulerWeb.ProblemViews
{
    public partial class MultiplesOf3and5 : System.Web.UI.UserControl
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


    }
}