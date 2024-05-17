using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorlock : MonoBehaviour
{
    public GameObject rCorrect1;
    public GameObject rCorrect2;
    public GameObject rCorrect3;
    public GameObject rCorrect4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rCorrect1.activeSelf && rCorrect2.activeSelf && rCorrect3.activeSelf && rCorrect4.activeSelf) 
        {
           gameObject.SetActive(false);
        }
    
    }
}
