﻿using UnityEngine;
using System.Collections;

public class controller : MonoBehaviour {
	public Transform cube;
	public int position;
	public Vector3 startpos;
	public Vector3 endpos;
	public int SW;
	public float finx;
	public Vector2 touchDeltaPosition;
	public Vector2 touchPosition;
	public Vector2 firstpos;
	public Vector2 cswipe;
	public float pq;
	public float sw;
	public float sh;
	public float xi;
	public float yi;
	public float xf;
	public float yf;
	public float asp;
	void  Start (){
		position=1;
		sw = Screen.width;
		sh = Screen.height;
		asp = sw / sh;
		xi = (17f/246)*1.6f*asp*sw;
		yi = (95f / 394) * sh;
		xf = xi + ((64f / 246) * sw);
		yf = yi + ((131f / 394) * sh);


	}
	
	void  Update (){
		
		/*if(Input.GetKeyDown(KeyCode.UpArrow)&&position==-1)
{
position=1;
gameObject.rigidbody2D.velocity=Vector2(0,0);
gameObject.rigidbody2D.gravityScale=-9;
}
if(Input.GetKeyDown(KeyCode.DownArrow)&&position==1)

{

position=-1;
gameObject.rigidbody2D.velocity=Vector2(0,0);
gameObject.rigidbody2D.gravityScale=9;
} */	
		if(Input.GetMouseButtonDown(0)){

			if((Input.mousePosition.x>xi)&&(Input.mousePosition.x<xf)&&
			   (Input.mousePosition.y>yi)&&(Input.mousePosition.y<yf))
			{firstpos=Input.mousePosition;
				Debug.Log (Input.mousePosition);}

			
		}
		if(Input.GetMouseButtonUp(0)&&(Input.mousePosition.x>xi)&&(Input.mousePosition.x<xf)&&
		   (Input.mousePosition.y>yi)&&(Input.mousePosition.y<yf)){
			cswipe=Input.mousePosition;
			pq=cswipe.y-firstpos.y;
			if(pq>0&&position==-1)
			{
				position=1;
				Go.defaultEaseType = GoEaseType.SineIn;
				cube.positionTo(.3f, new Vector3(-12.63762f,-6.522903f,-10f));

			}
			if(pq<0&&position==1)
				
			{
				
				position=-1;
				cube.positionTo(.3f, new Vector3(-12.63762f,-26.54479f,-10f));

			}
			
		}
		
		
		/*if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began) 
        {
            finx = 0;
            
            SW = 0;
            touchDeltaPosition = Input.GetTouch (0).position;
            startpos = new Vector3 (touchDeltaPosition.x, touchDeltaPosition.y, 0);
        }      
        if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Moved) 
        {
            SW = 1;
        }
 
    
        if (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Ended) 
        {
            if (SW) 
            {
                 touchPosition = Input.GetTouch (0).position;
                endpos = new Vector3 (touchPosition.x,touchPosition.y,0);
                finx = endpos.y - startpos.y;
				if(finx>0&&position==-1)
				{
				position=1;
				gameObject.rigidbody2D.velocity=Vector2(0,0);
				gameObject.rigidbody2D.gravityScale=-9;
				}
				if(finx<0&&position==1)

				{

				position=-1;
				gameObject.rigidbody2D.velocity=Vector2(0,0);
				gameObject.rigidbody2D.gravityScale=9;
				}


			}
		}*/
		
		
		
		
	}
}
