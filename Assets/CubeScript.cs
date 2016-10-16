using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour { /* mbah143 */
	public float rotateSpeed = 1.0f;
	public Vector3 spinSpeed = Vector3.zero;
	Vector3 spinAxis = new Vector3(0,1,0);
	/* mbah143 */
	// Use this for initialization
	void Start () {
		/* mbah143 */
		spinSpeed = new Vector3 (Random.value, Random.value, Random.value);
		spinAxis = Vector3.up;
		spinAxis.x = (Random.value - Random.value) * .1f; 
		/* mbah143 */
	}

	public void SetSize(float size)
	{	/* mbah143 */
		this.transform.localScale = new Vector3 (size,size, size); /* mbah143 */
	}


	// Update is called once per frame
	void Update () {
		/* mbah143 */
		this.transform.Rotate (spinSpeed);
		this.transform.RotateAround (Vector3.zero, spinAxis, rotateSpeed);
		/* mbah143 */
	}
}

