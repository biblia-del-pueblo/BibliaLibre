using System;
using System.Text;
using System.Text.RegularExpressions;

// Epub.Links = false;
// Epub.OmitTitles = false;
// Epub.OmitFootnotes = false;
// Epub.CreateChapterLinks = false;
// Epub.TableOfContentsPage = "ch001.xhtml";

Epub.OmitParagraphs = false;
Epub.Page = book =>
{
    book = book + 3;
    return $"ch{book:d3}.xhtml";
};
Language = "english";
//Create.Replace = "/LORD/[Lord]{.smallcaps}";
// replace uppercase words with smallcaps
Import.PreprocessImportUSFM = txt => txt.Replace("¶", "");

Create.Preprocess = txt => Regex.Replace(txt, @"[A-ZÑÓÍÉÁÚ][A-ZÑÓÍÉÁÚ]+", m =>
{

    if (Regex.IsMatch(m.Value, "^[IVXCD]+$", RegexOptions.Singleline))
    {
        // is roman number
        return m.Value;
    }
    var str = new StringBuilder("[");
    str.Append(m.Value[0]);
    for (int i = 1; i < m.Value.Length; i++) str.Append(Char.ToLower(m.Value[i]));
    str.Append("]{.smallcaps}");
    return str.ToString();
});
EachVerseOnNewLine = true;

Log("Added epub rule.");

//Program.ImportStrongs = true;