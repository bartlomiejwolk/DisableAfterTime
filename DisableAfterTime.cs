using UnityEngine;
using System.Collections;

namespace DisableAfterTimeEx {

	public class DisableAfterTime : MonoBehaviour{

		/// Game object to disable.
		[SerializeField]
		private GameObject _target;

		/// Delay before disabling the target game object.
		[SerializeField]
		private float _delay = 0;

		private void Start () {
			if (!_target) {
				Utilities.MissingReference(this, "target");
			}

            Invoke("DisableTarget", _delay);
		}

	    private void DisableTargetGO() {
	        _target.SetActive(false);
	    }
	}
}
