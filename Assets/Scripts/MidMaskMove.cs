using UnityEngine;

//general notes to remember:
//sources: https://discussions.unity.com/t/how-to-move-a-recttransform-on-pos-x-through-code/165851
// https://www.youtube.com/watch?v=ZoiNP5IfBBo --note: had to modify some things, would like to research stencil buffer further (REMEMBER)
//https://docs.unity3d.com/ScriptReference/RectTransform-anchoredPosition.html
//at first, applying this script did NOT work on mask1. then i realized it was because it was referencing transform,
//but appparently UI objects use RectTransform, so figured that out


public class MidMaskMove : MonoBehaviour
{
    public float speed = .05f;
    
    public bool midMaskAligned = false;
    //changed speed in Unity bc it was WAY too low
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    //originally tried to use RectTransform.anchoredPosition- this does not work, as RectTransform is a class LOL (duh)
    //so I create an instance of rect transform 
    //user CORN declares myRectTransform, demonstrates that we can use the built in function GetComponent
    //This accesses the specific transform info for that instance (YAY THANKS CORN). bit of breaking that up worked well

    private RectTransform _myRectTransform;
    private bool _gonnaMove;
 
    void Start()
    {
        _myRectTransform = GetComponent<RectTransform>();
        _gonnaMove = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            _gonnaMove = true;
        }
        if ((_gonnaMove) && ((Input.GetKeyDown(KeyCode.Alpha1)) || (Input.GetKeyDown(KeyCode.Alpha4))))
        {
            _gonnaMove = false;
        }
        
        Vector2 currentPos = _myRectTransform.anchoredPosition;
        if (_gonnaMove)
        {
            if (Input.GetKey(KeyCode.W))
            {
                currentPos.y += speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.S))
            {
                currentPos.y -= speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.D))
            {
                currentPos.x += speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.A))
            {
                currentPos.x -= speed * Time.deltaTime;
            }   
        }

        _myRectTransform.anchoredPosition = currentPos;
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log(collision.gameObject.name);
        if (collision.CompareTag("midTrigger"))
        {
            midMaskAligned = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("midTrigger"))
        {
            midMaskAligned = false;
        }
    }
}