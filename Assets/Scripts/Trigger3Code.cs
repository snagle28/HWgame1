using UnityEngine;
public class Trigger3Code : MonoBehaviour
{
    // // Start is called once before the first execution of Update after the MonoBehaviour is created
    // //once all three booleans for mask 1, 2, and 3 are true, move camera
    //
    // private float _t3LocationXMin;
    // private float _t3LocationXMax;
    // private float _t3LocationYMin;
    // private float _t3LocationYMax;
    // //declare renderer before start, this will be used to find the size of the mask 1 trigger
    // private SpriteRenderer _t3Renderer;
    // private float _t3Width;
    // private float _t3Height;
     public bool t3Aligned = false;
    //
    // //declare variables related to Mask1
    // public GameObject Mask3;
    // private Vector3 mask3Pos;
    // private float mask3XPos;
    // private float mask3YPos;
    //
    //
    // void Start()
    // {
    //     _t3Renderer = GetComponent<SpriteRenderer>();
    //     _t3Width =  _t3Renderer.bounds.size.x;
    //     _t3Height = _t3Renderer.bounds.size.y;
    //     
    //     //declare the bounds of the x and y positions for the TRIGGER BOX
    //     _t3LocationXMin = _t3Renderer.bounds.min.x;
    //     _t3LocationXMax = _t3Renderer.bounds.max.x;
    //     _t3LocationYMin = _t3Renderer.bounds.min.y;
    //     _t3LocationYMax = _t3Renderer.bounds.max.y;
    //     
    // }
    //
    // // Update is called once per frame
    // void Update()
    // {
    //     //constantly check for the location of the MASK
    //     mask3Pos =  Mask3.transform.position;
    //     mask3XPos= mask3Pos.x;
    //     mask3YPos = mask3Pos.y; 
    //     //compare x and y location of mask and trigger
    //     if ((mask3XPos < _t3LocationXMax + 20 &&  mask3XPos > _t3LocationXMin - 20) && 
    //         (mask3YPos < _t3LocationYMax + 20 &&  mask3YPos > _t3LocationYMin - 20))
    //     {
    //         t3Aligned = true;
    //     }
    //     else
    //     {
    //         t3Aligned = false;
    //     }
    //     
    //    
    // }
    
    
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.CompareTag("bigMask"))
        {
            t3Aligned = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("midMask"))
        {
            t3Aligned = false;
        }
    }
}