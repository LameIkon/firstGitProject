using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    public Cookie cookieScript;

    // Start is called before the first frame update
    void Start()
    {
        // cookieScript = GameObject.Find("cookie").GetComponent<Cookie>();
    }

    // Update is called once per frame
    void Update()
    {
        cookieScript.score++;
        cookieScript.PrintScore();
    }
}
