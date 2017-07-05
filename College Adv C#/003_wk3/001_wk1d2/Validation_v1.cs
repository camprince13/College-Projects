using System;

public class validation
{
    //Tests if string contains Poop
    public static bool GotPoop(string temp)
    {
        bool result = false;
        if (temp.Contains("Poop"))
        { result = true; }
        return result;
    }


    //Tests a string to see if it is blank
    public static bool IsFilledIn(string temp)
    {
        bool result = false;
        if (temp.Length > 0)
        { result = true; }
        return result;
    }


    //Tests a double to see if it is blank
    /*public static bool IsFilledIn(double temp)
    {
        bool result = true;
        if (temp == null)
        { result = false; }
        return result;
    }*/


    //Tests for a valid length for state
    public static bool IsValidLength(string temp)
    {
        bool result = true;
        if (temp.Length != 2)
        { result = false; }
        return result;
    }


    //Tests for the country's length
    public static bool IsWithinRange(string temp)
    {
        bool result = false;
        if (temp.Length > 2 && temp.Length < 20)
        { result = true; }
        return result;
    }

    //Tests money amounts
    public static bool IsWithinRange(double temp)
    {
        bool result = false;
        if (temp >= 0 && temp <= 100)
        { result = true; }
        return result;
    }


    //Checks for valid email
    public static bool IsValidEmail(string temp)
    {
        bool result = true;
        int AtLocation = temp.IndexOf("@");
        int NextAtLocation = temp.IndexOf("@", AtLocation + 1);
        int PeriodLocation = temp.LastIndexOf(".");
        if (temp.Length < 8)
        { result = false; }
        else if (AtLocation < 2)
        { result = false; }
        else if (PeriodLocation + 2 > (temp.Length))
        { result = false; }
        return result;
    }


}