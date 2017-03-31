using UnityEngine;
using System.Collections;

namespace Unitycoding.UIWidgets{
	public class MessageContainer : UIContainer<MessageOptions> {
		[SerializeField]
		public bool fadeMessage=true;

		public virtual bool Add(string message){
			MessageOptions options = new MessageOptions ();
			options.text = message;
			return Add (options);
		}
		
		public virtual bool Add(string message, Sprite icon){
			MessageOptions options = new MessageOptions ();
			options.text = message;
			options.icon = icon;
			return Add (options);
		}

		public virtual bool Remove(string message){
			for (int i=0; i< base.Items.Count; i++) {
				if(base.Items[i].text ==message){
					DestroyImmediate(base.Slots[i].gameObject);
					RefreshSlots();
					return true;
				}
			}
			return false;
		}
	}
}