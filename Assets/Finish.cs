using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Finish : MonoBehaviour
{

    public GameObject Sphere1;
    public GameObject CylindrFinish1;
    public GameObject TextFinal;

    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider CylindrFinish)
    {
        print("Welldone");
        //EditorUtility.DisplayDialog("Welldone", "Ñongratulations, you win","OK");
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
