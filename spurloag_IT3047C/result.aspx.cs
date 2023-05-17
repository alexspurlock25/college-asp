//*********************************************************************************************
//* Name            - Alexander Spurlock
//* Email Address   - spurloag @mail.uc.com
//* Assignment #    - Assignment #03
//* Due date        - 2/5/2020
//* Course          - IT3047C, ASP.NET
//* Semester        - Spring, 2020
//* Description     - A webform that allowes a user to select a car, and later select options 
//                    only available to that car. As the user adds the options from a ListBox, those options are
//                    moved to a second ListBox. User can then click "done", which leads him/her to
//                    a secondarty page with the car and options the user had selected.
//
//* CITE             - Dictionary with List<String> as values https://stackoverflow.com/questions/17887407/dictionary-with-list-of-strings-as-value
//                   - Spliting words https://stackoverflow.com/questions/53138384/how-to-read-the-first-word-in-a-text-file-and-display-it-in-a-richtextbox
//                   - File reading, and currect way of getting the path of a file: Professor Nicholson
//**********************************************************************************************
using System;
using System.Collections.Generic;

public partial class result : System.Web.UI.Page
{
    /// <summary>
    /// Page load event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        // get the application variable from last page, and input that into a label
        lbl_Car.Text = "You've selected " + Application["Car"] as String + "!";
        
        // get the list from last page
        List<String> options = Application["Options"] as List<String>;

        // for each word in List, add the word to a ListBox on this page
        foreach (String option in options)
        {

            lst_OptionsResult.Items.Add(option);

        }

    }
}