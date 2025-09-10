using UnityEngine;
public class Trigger2Code : MonoBehaviour
{
    // // Start is called once before the first execution of Update after the MonoBehaviour is created
    // //once all three booleans for mask 1, 2, and 3 are true, move camera
    //
    // private float _t2LocationXMin;
    // private float _t2LocationXMax;
    // private float _t2LocationYMin;
    // private float _t2LocationYMax;
    // //declare renderer before start, this will be used to find the size of the mask 1 trigger
    // private SpriteRenderer _t2Renderer;
    // private float _t2Width;
    // private float _t2Height;
    public bool t2Aligned = false;
    //
    // //declare variables related to Mask1
    // public GameObject Mask2;
    // private Vector3 mask2Pos;
    // private float mask2XPos;
    // private float mask2YPos;
    //
    //
    // void Start()
    // {
    //     _t2Renderer = GetComponent<SpriteRenderer>();
    //     _t2Width =  _t2Renderer.bounds.size.x;
    //     _t2Height = _t2Renderer.bounds.size.y;
    //     
    //     //declare the bounds of the x and y positions for the TRIGGER BOX
    //     _t2LocationXMin = _t2Renderer.bounds.min.x;
    //     _t2LocationXMax = _t2Renderer.bounds.max.x;
    //     _t2LocationYMin = _t2Renderer.bounds.min.y;
    //     _t2LocationYMax = _t2Renderer.bounds.max.y;
    //     
    // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //     //constantly check for the location of the MASK
    //     mask2Pos =  Mask2.transform.position;
    //     mask2XPos= mask2Pos.x;
    //     mask2YPos = mask2Pos.y; 
    //     //compare x and y location of mask and trigger
    //     if ((mask2XPos < _t2LocationXMax + 20 &&  mask2XPos > _t2LocationXMin - 20) && 
    //         (mask2YPos < _t2LocationYMax + 20 &&  mask2YPos > _t2LocationYMin - 20))
    //     {
    //         t2Aligned = true;
    //     }
    //     else
    //     {
    //         t2Aligned = false;
    //     }
    //     
    // }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.CompareTag("midMask"))
        {
            t2Aligned = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("midMask"))
        {
            t2Aligned = false;
        }
    }

}