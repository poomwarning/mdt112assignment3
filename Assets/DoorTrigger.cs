using System.Collections;
using System.Collections.Generic; 
using UnityEngine;
public class DoorTrigger : MonoBehaviour
{
	[SerializeField]
	public GameObject door;
	
	bool isOpened = false;
	
	void OntriggerEnter(Collider col)
	{
		if(!isOpened)
		{
			isOpened = true;
			door.transform.position += new Vector3 (0,4,0);
		}
    }

}