public class Solution
{
    private List<int> Solver(string s)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '+' || s[i] == '-' || s[i] == '*')
            {
                var left = Solver(s.Substring(0, i));
                var right = Solver(s.Substring(i + 1));

                foreach (var x in left)
                {
                    foreach (var y in right)
                    {
                        if (s[i] == '+') result.Add(y + x);
                        else if (s[i] == '-') result.Add(x - y);
                        else result.Add(x * y);
                    }
                }
            }
        }
        if (result.Count == 0)
        {
            result.Add(int.Parse(s));
            return result;
        }
        return result;
    }
    public IList<int> DiffWaysToCompute(string s)
    {
        return Solver(s); 
    }
}