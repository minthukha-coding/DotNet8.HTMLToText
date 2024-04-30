using System.Globalization;
using System.Text.RegularExpressions;

string ExtractTextFromHtml(string html)
{
    if (html == null)
    {
        return "null";
    }

    string plainText = Regex.Replace(html, "<[^>]+?>", " ");
    plainText = System.Net.WebUtility.HtmlDecode(plainText).Trim();

    return plainText;
}

string htmlContent = "<p>Hello World</p>";
string text = ExtractTextFromHtml(htmlContent);
Console.WriteLine(text);