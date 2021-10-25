using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;

public static class Html 
{
    // Start is called before the first frame update
    public static IEnumerator GetHtml(string url, Action<string, bool> callback)
    {
        UnityWebRequest req = UnityWebRequest.Get(url);
        yield return req.SendWebRequest();
        if (req.result == UnityWebRequest.Result.ConnectionError)
        {
            //Debug.Log(req.error);
            callback(req.error, false);
        }
        else
        {
            callback(req.downloadHandler.text, true);
        }
    }
}
