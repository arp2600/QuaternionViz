// Attaches to a weight object to control the weights positions and size
using UnityEngine;
using System.Collections;

public class Weight : MonoBehaviour 
{
	float _i,_j,_k,_w;

	public static void CreateWith (GameObject prefab, float[] f)
	{
		// Create the object and attach a weight component
		GameObject go = Instantiate(prefab) as GameObject;
		go.transform.parent = GameObject.Find("Manager").transform;

		Weight w = go.AddComponent("Weight") as Weight;
		w.SetComponents(f[0], f[1], f[2], f[3]);
	}

	public void SetComponents (float i, float j, float k, float w)
	{
		_i = i;
		_j = j;
		_k = k;
		_w = w;

		UpdatePosition();
		UpdateSize();
	}

	public void UpdatePosition ()
	{
		transform.position = new Vector3(_i, _j, _k) * WeightsManager.position_scale;
	}

	public void UpdateSize ()
	{
		float i = WeightsManager.size_scale;
		transform.localScale = new Vector3(i,i,i);
	}
}
