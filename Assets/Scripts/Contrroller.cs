using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Winista.Text.HtmlParser;
using Winista.Text.HtmlParser.Filters;
using Winista.Text.HtmlParser.Nodes;
using Winista.Text.HtmlParser.Tags;
using Winista.Text.HtmlParser.Data;
using Winista.Text.HtmlParser.Util;

public class Contrroller : MonoBehaviour
{
    public string url = "";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Html.GetHtml(url, HandleHtml));
    }

    void HandleHtml(string result, bool statu)
    {
        if (!statu)
        {
            Debug.Log(result);
        }
        else
        {
            Debug.Log(result);
        }
    }
    
}
