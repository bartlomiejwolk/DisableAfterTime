using UnityEngine;
using System.Collections;

namespace DisableAfterTimeEx {

    public class DisableAfterTime : MonoBehaviour{

        /// Game object to disable.
        [SerializeField]
        private GameObject targetGO;

        /// Delay before disabling the target game object.
        [SerializeField]
        private float delay = 0;

        private void Start () {
            if (!targetGO) {
                Utilities.MissingReference(this, "target");
            }

            Invoke("DisableTarget", delay);
        }

        private void DisableTargetGO() {
            targetGO.SetActive(false);
        }
    }
}
