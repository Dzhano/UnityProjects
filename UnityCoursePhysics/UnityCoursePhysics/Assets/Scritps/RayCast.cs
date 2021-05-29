using UnityEngine;

public class RayCast : MonoBehaviour 
{
	public float hitForce = 50;

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit, 20f))
			{
				hit.rigidbody.AddForce(Vector3.forward * hitForce, ForceMode.Impulse);
				Debug.Log("hit : " + hit.collider.name);
				Debug.Log("hit : " + hit.rigidbody.velocity);
			}
		}
        
	}
}
