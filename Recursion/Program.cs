
void reverse(char[] s,int f,int l)
{
    if (f > l) return;
    (s[f], s[l]) = (s[l], s[f]);
    reverse(s,f+1,l-1);
}

string s = "Shahadat";
char[] chars = s.ToCharArray();
reverse(chars,0,s.Length-1);
s=new string(chars);
Console.WriteLine(s);