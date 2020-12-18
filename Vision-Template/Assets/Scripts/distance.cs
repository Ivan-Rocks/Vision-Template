using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class distance : MonoBehaviour
{
    public GameObject stimulus;
    public GameObject cell;
    public double dist;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(stimulus.transform.position, cell.transform.position);
        text.text = dist.ToString();
        print(dist);
    }
}
