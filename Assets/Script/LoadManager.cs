using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
    public string url = "https://via.placeholder.com/114x272";
    public RawImage image;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(loadBmp());
    }

    // Update is called once per frame
    void Update() { }

    IEnumerator loadBmp()
    {
        WWW www = new WWW(url);
        yield return www;
        image.texture = www.texture;
    }
}
