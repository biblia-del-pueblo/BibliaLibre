using System;
using System.Text;
using System.Text.RegularExpressions;

Language = "english";
//Program.Replace = "/LORD/[Lord]{.smallcaps}";
// replace uppercase words with smallcaps
Create.Preprocess = txt => Regex.Replace(txt, @"(?<!((^|\n)#[^\n]*?|[^ ]_))\p{Lu}{2,}", m =>
{

    if (Regex.IsMatch(m.Value, "^(?:[IVXCD]+|ISBN)$", RegexOptions.Singleline))
    {
        // is roman number or ISBN
        return m.Value;
    }

    var str = new StringBuilder("[");
    str.Append(m.Value[0]);
    for (int i = 1; i < m.Value.Length; i++) str.Append(Char.ToLower(m.Value[i]));
    str.Append("]{.smallcaps}");
    return str.ToString();
}, RegexOptions.Singleline);

Import.ImportStrongs = true;