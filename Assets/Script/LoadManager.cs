using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LoadManager : MonoBehaviour
{
    public string url = "https://via.placeholder.com/114x272";
    public RawImage image;
    public Text text;
    public TextMeshPro textMeshPro;

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
        text.text = "改变了";
        textMeshPro = GetComponent<TextMeshPro>();
    }
}
