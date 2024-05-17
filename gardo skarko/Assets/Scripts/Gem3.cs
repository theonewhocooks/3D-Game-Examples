using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Gem3 : MonoBehaviour
{
    private Renderer _renderer;
    public GameObject cyCorrect;
    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _renderer.material.color = Color.magenta;
        cyCorrect.SetActive(false);
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("YARITO"))
        {
            _renderer.material.color = Color.cyan;
            StartCoroutine(ChangeCubeColor());
            cyCorrect.SetActive(true);

        }
    }
    private IEnumerator ChangeCubeColor()
    {
        yield return new WaitForSeconds(10);
        _renderer.material.color = Color.magenta;
        cyCorrect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
