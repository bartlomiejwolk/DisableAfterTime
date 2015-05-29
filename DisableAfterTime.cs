using UnityEngine;

namespace DisableAfterTimeEx {

    public class DisableAfterTime : MonoBehaviour{

        /// Game object to disable.
        [SerializeField]
        private GameObject targetGO;

        /// Delay before disabling the target game object.
        [SerializeField]
        private float delay;

        /// Game object to disable.
        public GameObject TargetGO {
            get { return targetGO; }
            set { targetGO = value; }
        }

        /// Delay before disabling the target game object.
        public float Delay {
            get { return delay; }
            set { delay = value; }
        }

        private void Start () {
            if (!TargetGO) {
                Utilities.MissingReference(this, "target");
            }

            Invoke("DisableTarget", Delay);
        }

        private void DisableTargetGO() {
            TargetGO.SetActive(false);
        }
    }
}
