using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Unitycoding.UIWidgets{
	public class KeyTrigger : MonoBehaviour {
		/// <summary>
		/// The key to trigger an event.
		/// </summary>
		public KeyCode key=KeyCode.None;
		/// <summary>
		/// Events that will be invoked when this window opens.
		/// </summary>
		public KeyEvent onKeyDown;

		private void Update(){
			if (Input.GetKeyDown (key) && !(EventSystem.current != null && EventSystem.current.currentSelectedGameObject != null && EventSystem.current.currentSelectedGameObject.GetComponent<InputField>() != null)) {
				onKeyDown.Invoke();
			}
		}

		[System.Serializable]
		public class KeyEvent:UnityEvent{}
	}
}