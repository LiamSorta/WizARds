using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections;

[RequireComponent(typeof(Slider))]
public class ToggleSlider : MonoBehaviour {
	public ToggleSliderEvent onTurnOn;
	public ToggleSliderEvent onTurnOff;

	private void Start(){
		Slider slider = GetComponent<Slider> ();
		slider.onValueChanged.AddListener (OnValueChanged);
	}

	private void OnValueChanged(float value){
		if (value < 0.5f) {
		//Off
			onTurnOff.Invoke();
		} else {
		//On
			onTurnOn.Invoke();
		}
	}

	[System.Serializable]
	public class ToggleSliderEvent:UnityEvent{}
}
