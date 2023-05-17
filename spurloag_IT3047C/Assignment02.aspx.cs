//*********************************************************************************************
//* Name            - Alexander Spurlock
//* Email Address   - spurloag @mail.uc.com
//* Assignment #    - Assignment #02
//* Due date        - 1/29/2020
//* Course          - IT3047C, ASP.NET
//* Semester        - Spring, 2020
//* Description     - The user fills in a number, clicks the button, and your code-behind will generate View controls
//                     inside the MultiView, drop-down to navigate the MultiView and something visually interesting
//                   in each View control so we can tell them apart.
//                    Note: your logic should work more than once without stopping and restarting your page.
//* CITE and OTHER HELP: 
//                      FINAL SOLUTION: https://forums.asp.net/t/1586152.aspx?ActiveViewIndex+is+being+set+to+0+
//                      https://www.tutorialspoint.com/asp.net/asp.net_multi_views.htm
//
//                      HELP: Worked with Joseph Svintsitsky.
//**********************************************************************************************
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Assignment02 : System.Web.UI.Page
{
    // instance varible to hold user number
    private static int textBoxNumber;

    /// <summary>
    /// Event method to add all Views to MultiView before Page_Load happens.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Page_Init(object sender, EventArgs e)
    {

        if (Page.IsPostBack)
        {
            // Check if there were previus views
            if (textBoxNumber > 0)
            {
                // Add previous views, if there were any
                for (int i = 1; i <= textBoxNumber; i++)
                {
                    // View object
                    View view = new View();
                    // give new view object an ID, Label, and a css class
                    view.ID = "View " + (i - 1);
                    view.Controls.Add(new Label()
                    {
                        Text = i.ToString(),
                        CssClass = "views"

                    });
                    // add each view to MultiView Control
                    mltView_FromList.Views.Add(view);
                }
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// A Button event method to get user's input, convert it to int, then finally add that many items to a ListBox
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btn_GetUserNumber_Click(object sender, EventArgs e)
    {
        // convert
        textBoxNumber = Int32.Parse(txtBox_UserNumber.Text);
        // clear ListBox from a lists, else it'll keep adding to previews Listitems
        lstBox_ViewTabs.Items.Clear();

        // for loop to add ListItems to ListBox
        for (int i = 1; i <= textBoxNumber; i++)
        {
            lstBox_ViewTabs.Items.Add(Convert.ToString(i));
        }
    }


    /// <summary>
    /// A Button even method to set get the View(ID) that is selected in the ListBox(ListItem with the same index as View)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btn_LoadView_Click(object sender, EventArgs e)
    {
        mltView_FromList.ActiveViewIndex = lstBox_ViewTabs.SelectedIndex;
    }
}