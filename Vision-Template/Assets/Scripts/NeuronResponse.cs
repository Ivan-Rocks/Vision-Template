using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NeuronResponse : MonoBehaviour
{
    public Texture2D m_texture;
    public RawImage m_rawImage;
    public int graphWidth=200;
    public int graphHeight=200;
    public Color[] pixels;
    public List<int> data;
    public Color GraphBackground;
    public Color LineColor;
    public int datapoint;

    // Start is called before the first frame update
    void Start()
    {
        m_texture = new Texture2D(graphWidth, graphHeight);
        m_rawImage.texture = m_texture;
        m_rawImage.SetNativeSize();
        pixels = new Color[graphWidth * graphHeight];
        data = new List<int>();
        data.Add(0);//0 时刻接受的数据值为0 
        for (int i = 0; i < pixels.Length; i++)
        {
            pixels[i] = GraphBackground;
        }
        m_texture.SetPixels (pixels);
        m_texture.Apply();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        datapoint++;
        datapoint %= graphHeight;  
        data.Add(datapoint);
        for (int j = data.Count - 1; j >= Mathf.Max(0, data.Count - graphWidth); j--)
        {
            pixels[data[j] * graphWidth + graphWidth - data.Count + j] = LineColor;
        }
        m_texture.SetPixels(pixels);
        m_texture.Apply();
        for (int j = data.Count - 1; j >= Mathf.Max(0, data.Count - graphWidth); j--)
        {
            pixels[data[j] * graphWidth + graphWidth - data.Count + j] = GraphBackground;
        }
    }
}
