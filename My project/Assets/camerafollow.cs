using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Target;
    public float Cameraspeed;

    public float minX, maxX;
    public float minY,maxY;
    void Start()
    {
        
    }
     void FixedUpdate(){
        if(Target!=null){
            Vector2 newCamPosition = Vector2.Lerp(transform.position , Target.position,Time.deltaTime*Cameraspeed);
            float ClampX = Mathf.Clamp(newCamPosition.x,minX,maxX);
            float ClampY = Mathf.Clamp(newCamPosition.y,minY,maxY);
            transform.position=new Vector3(ClampX,ClampY,-10f);
        }
     }

    // Update is called once per frame
    void Update()
    {
        
    }
}
