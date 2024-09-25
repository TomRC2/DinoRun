using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptEjs : MonoBehaviour
{
    public Vector3 tama�oMinimo = new Vector3(1f, 1f, 1f);
    public Vector3 tama�oMaximo = new Vector3(2f, 2f, 2f);
    public float intervalo = 1f;
    void Start()
    {
        StartCoroutine(CambiarTama�o());
    }
    IEnumerator CambiarTama�o()
    {
        while (true)
        {
            transform.localScale = tama�oMinimo;
            yield return new WaitForSeconds(intervalo);
            transform.localScale = tama�oMaximo;
            yield return new WaitForSeconds(intervalo);
        }
    }
}
