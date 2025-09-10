using System.ComponentModel;
using UnityEngine;

public class GlobalTrigger : MonoBehaviour
{
    public GameObject trigger1;
    public GameObject trigger2;
    public GameObject trigger3;

    public bool camReady = false;
    private int timer = 0;
    private bool _check1Align;
    private bool _check2Align;
    private bool _check3Align;
    public bool allAligned;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _check1Align = trigger1.GetComponent<LilTrigger>().t1Aligned;
        _check2Align = trigger2.GetComponent<Trigger2Code>().t2Aligned;
        _check3Align = trigger3.GetComponent<Trigger3Code>().t3Aligned;
        
        if (_check2Align == true && _check3Align == true && _check1Align == true)
        {
            allAligned = true;
            timer++;
        }
        
        if (timer >= 100)
        {
            camReady = true;
        }
        
        
        //create a public function that resets camready, all aligned, and the timer. then call this in bckg move
        
    }
    
    
    public void ResetGlobalTrigger()
    {
        camReady = false;
        allAligned = false;
        timer = 0;
    }
}
