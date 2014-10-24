// Provides an interface for controlling all the current weights
using UnityEngine;
using System.Collections;

public class WeightsManager : MonoBehaviour 
{
	public float _position_scale = 1; // Visible and editable in the inspector
	public static float position_scale = 1; // Queryable value

	public float _size_scale = 1;
	public static float size_scale = 1;

	void OnValidate ()
	{
		// Sync up static value with non static values
		if (position_scale != _position_scale)
		{
			position_scale = _position_scale;
			BroadcastMessage("UpdatePosition", SendMessageOptions.DontRequireReceiver); 
		}
		if (size_scale != _size_scale)
		{
			size_scale = _size_scale;
			BroadcastMessage("UpdateSize", SendMessageOptions.DontRequireReceiver); 
		}
	}

}
