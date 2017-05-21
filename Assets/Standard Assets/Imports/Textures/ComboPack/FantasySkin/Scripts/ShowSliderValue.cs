using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;

//Not my script, I use it for more facility 

[RequireComponent(typeof(Text))]
public class ShowSliderValue : MonoBehaviour
{
	public void UpdateLabel (float value)
	{
		Text lbl = GetComponent<Text>();
		if (lbl != null)
			lbl.text = Mathf.RoundToInt (value) + "%";
	}
}
