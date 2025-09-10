using UnityEditor;
using UnityEngine;

public class LilTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   //once all three booleans for mask 1, 2, and 3 are true, move camera
    
   //private float _t1LocationXMin;
   //private float _t1LocationXMax;
   //private float _t1LocationYMin;
   //private float _t1LocationYMax;
   //declare renderer before start, this will be used to find the size of the mask 1 trigger
   // private SpriteRenderer _t1Renderer;
   // private float _t1Width;
   // private float _t1Height;
    public bool t1Aligned = false;
   //
   // //declare variables related to Mask1
   // public GameObject Mask1;
   // private Vector3 mask1Pos;
   // private float mask1XPos;
   // private float mask1YPos;
   //
   //
   // void Start()
   //  {
   //      _t1Renderer = GetComponent<SpriteRenderer>();
   //      _t1Width =  _t1Renderer.bounds.size.x;
   //      _t1Height = _t1Renderer.bounds.size.y;
   //      
   //      //declare the bounds of the x and y positions for the TRIGGER BOX
   //      _t1LocationXMin = _t1Renderer.bounds.min.x;
   //      _t1LocationXMax = _t1Renderer.bounds.max.x;
   //      _t1LocationYMin = _t1Renderer.bounds.min.y;
   //      _t1LocationYMax = _t1Renderer.bounds.max.y;
   //      
   //  }
   //
   //  // Update is called once per frame
   //  void Update()
   //  {
   //      //constantly check for the location of the MASK
   //      mask1Pos =  Mask1.transform.position;
   //      mask1XPos= mask1Pos.x;
   //      mask1YPos = mask1Pos.y; 
   //      //compare x and y location of mask and trigger
   //      if ((mask1XPos < _t1LocationXMax + 20 &&  mask1XPos > _t1LocationXMin - 20) && 
   //          (mask1YPos < _t1LocationYMax + 20 &&  mask1YPos > _t1LocationYMin - 20))
   //      {
   //          t1Aligned = true;
   //      }
   //      else
   //      {
   //          t1Aligned = false;
   //      }
   //      
   //  }

   
   
   
}
