using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Block : MonoBehaviour {
	

	//public AudioSource blockFall;
	//private BlockManager manager;
	//private bool blockCollision = false;
	
	
	void Awake() {
		//GameObject cubeManager = GameObject.FindGameObjectWithTag("manager");
		//manager = cubeManager.GetComponent<BlockManager>();	
	}
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	
	// Update is called once per frame
	void Update () {

		
	}	
	
			
	void OnCollisionExit(Collision col) {
		/*
		if(col.gameObject.CompareTag("block") || col.gameObject.CompareTag("ground")) {
			if(!this.blockCollision) {
				
				this.blockCollision = true;
			}
			if(manager.newCubes && gameObject.rigidbody.velocity.y >= 0f && manager.blockFall) {
				manager.disableBlockFall();			
				blockFall.Play();
			}
		}*/
				
	}
	
	
	public void nukeBlock() {
	
		StartCoroutine(delayNuke());
		
	}
	
	
	IEnumerator delayNuke() {
	
		GameObject cubeManager = GameObject.FindGameObjectWithTag("manager");
		BlockManager manager = cubeManager.GetComponent<BlockManager>();
		yield return new WaitForSeconds(0.2f);
		manager.removeBlock(gameObject);
		
	}

	
}
