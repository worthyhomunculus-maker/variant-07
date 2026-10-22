public static class ReviewTask
{
    public static int Run(bool[] available)
    {
        if (available.Length == 0)
            return 0;

        int down = 0;

        foreach (bool value in available)
        {
            if (!value)
                down++;
        }

        return down * 100 / available.Length;
    }
}