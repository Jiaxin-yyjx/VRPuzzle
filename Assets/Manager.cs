using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public int index;
    public GameObject closeobj;
    public GameObject openobj;
    public GameObject jiantou;
    public GameObject TextDis;
    public static Manager instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(index>=4)
        {
            closeobj.SetActive(false);
            jiantou.SetActive(false);
            openobj.SetActive(true);
            TextDis.SetActive(false);
        }
    }
}
