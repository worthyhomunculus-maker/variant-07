using System;
using System.Collections.Generic;
using System.Globalization;

public static class ReviewTask
{
    public static int Run(bool[] available)
    {
        int down = 0;
        foreach (bool value in available)
            if (value)
                down++;
        return down / available.Length * 100;
    }
}
