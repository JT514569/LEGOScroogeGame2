using System.Net;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Xml;

public class Website : MonoBehaviour
{

    public GameObject txt;
    public string weblink = "https://jt514569.github.io/lego/help.html";

    // Start is called before the first frame update
    void Start()
    {


        string html = new WebClient().DownloadString(weblink);

        var cleanString = StripHtml(html);


        txt.GetComponent<TMPro.TextMeshProUGUI>().text = cleanString;
        

    }

    public static string StripHtml(string input)
    {
        // Will this simple expression replace all tags???
        var tagsExpression = new Regex(@"</?.+?>");
        return tagsExpression.Replace(input, " ");
    }




}


