﻿using UnityEngine;
using System.Collections;

public class portalctrl2 : MonoBehaviour {
	public float countdown;
	public float countdownc;
	public SpriteRenderer rend;
	public GameObject cube;
	public bar bar1;
	public SpriteRenderer rendb;
	public Vector3 pp;
	public GameObject red;
	public GameObject blue;
	void  Start (){
		countdown=0.0f;
		countdownc=Random.Range(0,3);
		rend=gameObject.GetComponent<SpriteRenderer>();
		cube=GameObject.FindGameObjectWithTag("energy");
		bar1=cube.GetComponent<bar>();
	}
	
	void  FixedUpdate (){

			if(countdown<=0.0f)
		{
			blue.transform.position=new Vector3(blue.transform.position.x,blue.transform.position.y,0);
			red.transform.position=new Vector3(red.transform.position.x,red.transform.position.y,-1);
				rend.color= new Color(.5f,.5f,.5f,.5f);
				gameObject.transform.collider2D.isTrigger=false;
				
				
				if(countdownc<=0.0f)
				{
					countdown=1.0f;

				}
				else if(countdownc>0.0f)
				{countdownc-=Time.deltaTime;
				}
				
				
				
			}
			
			
			else if(countdown>0.0f)
		{
			red.transform.position=new Vector3(red.transform.position.x,red.transform.position.y,0);
			blue.transform.position=new Vector3(blue.transform.position.x,blue.transform.position.y,-1);
				rend.color=new Color(1,1,1,1);
				gameObject.transform.collider2D.isTrigger=true;
				countdown-=Time.deltaTime;
				countdownc=Random.Range(0,3);
			}
		

		
		
		
	}
	void  OnTriggerEnter2D ( Collider2D collider  ){

		bar1.add1();
		bar1.flip();
		
	}
	void  OnCollisionEnter2D ( Collision2D col  ){
		if(col.gameObject.tag == "Player")
		{

			
			Application.LoadLevel("1");}
	}
}
