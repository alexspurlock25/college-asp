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
using System.IO;

/// <summary>
/// Class to tokenize Strings/Files into functional groups
/// </summary>
public class Tokenizer
{
    /// <summary>
    /// Method tp tokenize a file into 2 groups: First word (Key), and the rest of the line (Values to the Key) 
    /// </summary>
    /// <param name="file"></param>
    /// <returns>A Dictionary of keys and values of Strings</returns>
    public Dictionary<String, List<String>> Tokenize(String file)
    {
        // create a dictionary to hold String Keys and List of Strings
        Dictionary<String, List<String>> dictionary = new Dictionary<String, List<String>>();
        // new reader ojbect
        StreamReader reader = null;
        // new List
        List<String> values;

        
        try
        {
            // try to read file
            using (reader = new StreamReader(file))
            {
                // read until end of line
                String line;
                while ((line = reader.ReadLine()) != null)
                {
                    // split the first word and put that into "key" variable
                    String key = line.Split(',')[0];

                    // go through every word, or "token", until in a given line
                    foreach (String token in line.Split(','))
                    {
                        // remove the first word because we want the first word to be a Key in a dictionary
                        token.Remove(0, token.Length);

                        // check if a value already exist (values that match the key).
                        if (!dictionary.TryGetValue(key, out values))
                        {
                            // If value does not exist, create an instance of a already declared List, then 
                            // attach the List to the current Key
                            values = new List<string>();
                            dictionary[key] = values;
                            
                        }
                        // else, add current token to the List
                        values.Add(token);
                    }

                }

            }

        }
        catch (FileNotFoundException)
        {
            throw;
        }
        finally
        {
            // close reader object
            reader.Close();
        }

        // return finished dictionary
        return dictionary;

    }
}