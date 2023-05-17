//<%--*********************************************************************************************
// * Name            - Alexander Spurlock
// * Email Address   - spurloag @mail.uc.com
// * Assignment #    - Assignment #01
// * Due date        - 1/22/2020
// * Course          - IT3047C, ASP.NET
// * Semester        - Spring, 2020
// * Description     - A landing page for IT3047C, during Spring semester, year 2020
// **********************************************************************************************--%>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Assignment01 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        

    }
    /// <summary>
    /// On button click, solve the problem
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btnSolve_Click(object sender, EventArgs e)
    {
        // create an instance, 
        Problem002 prob2 = new Problem002();

        // store the result of Solve method in 'result'
        int result = prob2.Solve();

        // print out the solution into the textbox
        Problem002Solution.Text = result.ToString();

    }

    protected void btnLink_Click(object sender, EventArgs e)
    {
        
    }
}