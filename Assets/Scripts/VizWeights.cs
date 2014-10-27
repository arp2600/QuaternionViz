// Instantiates a number of weights from a .weight file
using UnityEngine;
using System.Collections;
using System.IO;

public class VizWeights : MonoBehaviour 
{
	public string file_path;
	public GameObject weight_prefab;

	// Use this for initialization
	void Start () 
	{
		CreateViz(file_path);
	}
	
	// Create a visualization of a weight file given a path to the file
	void CreateViz (string path)
	{
		string file_text = File.ReadAllText(path);
		string[] lines = file_text.Split('\n');

		// the weights data starts on line 6
		for (int i=6; i<lines.Length; i++)
		{
			if (lines[i] == "")
				continue;

			// convert each line into an array of 4 floats
			string[] components = lines[i].Split(' ');
			float[] floats = new float[4];
			try
			{
				for (int j=0; j<4; j++)
						floats[j] = float.Parse(components[j]);
				// Create the weight object
				Weight.CreateWeight(weight_prefab, floats);
			}
			catch (System.FormatException)
			{
				print(lines[i]);
			}
		}
	}
}
