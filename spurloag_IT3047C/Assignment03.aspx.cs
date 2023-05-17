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
using System.Web;
using System.Web.UI.WebControls;

public partial class Assignment03 : System.Web.UI.Page
{
    // class Dictionary, and class List of currently selected options
    private Dictionary<String, List<String>> dictionary = new Dictionary<string, List<String>>();
    protected static List<String> selectedOptions = new List<String>();

    /// <summary>
    /// Page Load event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {
        
        // File directory
        String file = HttpContext.Current.Server.MapPath("~/vehicle_data_Assignment03/modelsAndOptions.txt");
        // new object of tokenizer to tokenize the file
        Tokenizer tokenizer = new Tokenizer();

        // store the returened Dictionary from Tokenizer into  a class Dictionary
        dictionary = tokenizer.Tokenize(file);

        // do the code inside one time.
        if (!IsPostBack)
        {
            // for each item in class dictionary, add key(Car Model) tp the Drop Down List
            foreach (KeyValuePair<string, List<String>> key_value in dictionary)
            {

                drpDwn_Cars.Items.Add( key_value.Key.ToString() );

            }

        }

    }

    /// <summary>
    /// Drop down ListItem checge event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void drpDwn_Cars_SelectedIndexChanged(object sender, EventArgs e)
    {
        // clear first and second ListBox
        lst_CarOptions.Items.Clear();
        lstBox_SelectedOptions.Items.Clear();

        // go through the Dictionary
        foreach (KeyValuePair<string, List<String>> key_value in dictionary)
        {
            // assign a variable to Dictionary Key
            string key = key_value.Key;
            // assign a variable to Dictionary Values
            List<string> values = key_value.Value;

            // go through the List inside the Dictionary
            for (int i = 1; i < values.Count; i++)
            {
                // check if the key matches the selected item inside the DropDown List
                if (key == drpDwn_Cars.SelectedItem.ToString())
                {
                    // if true, add the value to the ListBox
                    lst_CarOptions.Items.Add( values[i] );

                }

            }

        }

    }

    /// <summary>
    /// Button Add Click event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btn_Add_Click(object sender, EventArgs e)
    {
        // Add selected item from first ListBox to second
        lstBox_SelectedOptions.Items.Add( lst_CarOptions.SelectedItem );
        // add selected item from first Listbox to List<String>
        selectedOptions.Add( lst_CarOptions.SelectedItem.ToString() );

        // after adding item to second ListBox, remove it from first ListBox
        lst_CarOptions.Items.RemoveAt(lst_CarOptions.SelectedIndex);
    }

    /// <summary>
    /// Button Remove Click event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btn_Remove_Click(object sender, EventArgs e)
    {
        // Add selected item from second ListBox to first ListBox
        lst_CarOptions.Items.Add( lstBox_SelectedOptions.SelectedItem );
        // Remove selected item form seocnd Listbox from List<String>
        selectedOptions.Remove( lstBox_SelectedOptions.SelectedItem.ToString() );

        // after adding item to first ListBox, remove it from second ListBox
        lstBox_SelectedOptions.Items.RemoveAt( lstBox_SelectedOptions.SelectedIndex );
    }

    /// <summary>
    /// Button Add All Click event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btn_AddAll_Click(object sender, EventArgs e)
    {
        // for each word in first ListBox,  add that word to the second ListBox
        // then add the same word to a list
        foreach (ListItem word in lst_CarOptions.Items)
        {
            lstBox_SelectedOptions.Items.Add(word);
            selectedOptions.Add(word.ToString());
        }
        // clear the first listbox
        lst_CarOptions.Items.Clear();
        
    }

    /// <summary>
    /// Button Remove All Click event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btn_RemoveAll_Click(object sender, EventArgs e)
    {
        // foreach word in second ListBox, add that word to First ListBox
        foreach (ListItem word in lstBox_SelectedOptions.Items)
        {
            lst_CarOptions.Items.Add(word.ToString());
        }
        // clear both the List<String>, and the second ListBox
        selectedOptions.Clear();
        lstBox_SelectedOptions.Items.Clear();
    }

    /// <summary>
    /// Button Done Click event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void btn_Done_Click(object sender, EventArgs e)
    {
        Application["Car"] = drpDwn_Cars.SelectedValue;
        Application["Options"] = selectedOptions;

        // after Storing the application variables, go the next page
        Response.Redirect( "result.aspx");
    }
}