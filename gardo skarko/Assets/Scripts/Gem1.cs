using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gem1 : MonoBehaviour
{
    private Renderer _renderer;
    public bool rcorrectColor;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _renderer.material.color = Color.blue;
        rcorrectColor = false;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("YARITO"))
        {
            _renderer.material.color = Color.red;
            StartCoroutine(ChangeCubeColor());
            rcorrectColor = true;
        }
    }
    private IEnumerator ChangeCubeColor()
    {
        yield return new WaitForSeconds(10);
        _renderer.material.color = Color.blue;
        rcorrectColor = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}