using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectEulerWeb.ProblemViews
{
    public partial class LargestProductGridView : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ClickHandler(object sender, EventArgs e)
        {
            String inputText = Input.Text;
            if (inputText == null)
                throw new InvalidOperationException("Input cannot be null");

            String inputLengthText = InputLength.Text;

            String[] inputTextArray = inputText.Split(' ');

            int inputLength = Int32.Parse(inputLengthText);
            int[][] grid = new int[inputLength][];

            int x = 0;
            int y = 0;
            for(int i = 0; i < inputTextArray.Length; i++)
            {
                if (y == 0)
                    grid[x] = new int[inputLength];
                grid[x][y] = Int32.Parse(inputTextArray[i]);
                if (y >= (inputLength) - 1)
                {
                    x++;
                    y = 0;
                }
                else
                    y++;
            }

            Problems.LargestProductInGrid problem = new Problems.LargestProductInGrid();
            ProblemResponse.Text = problem.FindLargestProduct(grid, inputLength).ToString();

        }
    }
}