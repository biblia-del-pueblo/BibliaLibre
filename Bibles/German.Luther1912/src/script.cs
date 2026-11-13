using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

// Epub.Links = false;
// Epub.OmitTitles = false;
// Epub.OmitFootnotes = false;
// Epub.CreateChapterLinks = false;
// Epub.TableOfContentsPage = "ch001.xhtml";

Epub.OmitParagraphs = false;
Epub.Page = book => {
    book = book+3;
    return $"ch{book:d3}.xhtml";
};
Language = "german";
Create.Replace = "/HErrn/[Herrn]{.smallcaps}/HErr/[Herr]{.smallcaps}";
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

EachVerseOnNewLine = true;

Import.ImportStrongs = true;

Program.Log("Added epub rule.");
