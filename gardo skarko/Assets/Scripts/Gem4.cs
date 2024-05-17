using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gem4 : MonoBehaviour
{
    private Renderer _renderer;
    public GameObject bCorrect;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _renderer.material.color = Color.white;
        bCorrect.SetActive(false);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("YARITO"))
        {
            _renderer.material.color = Color.black;
            StartCoroutine(ChangeCubeColor());
            bCorrect.SetActive(true);
        }
    }
    private IEnumerator ChangeCubeColor()
    {
        yield return new WaitForSeconds(10);
        _renderer.material.color = Color.white;
        bCorrect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
