using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem
{ 
    public class KeyItemController : MonoBehaviour
    {
        [SerializeField] private bool redDoor = false;
        [SerializeField] private bool redKey = false;

        [SerializeField] private KeyInventory _keyInventory = null;

        private KeyDoorController doorobject;

        private void Start ()
        {
            if(redDoor)
            doorobject = GetComponent<KeyDoorController>();

        }

        public void ObjectInteraction()
        {
            if(redDoor)
            {
            
            }

            else if (redKey)
            {
                _keyInventory.hasKey = true;
                gameObject.SetActive(false);
            }
        }
    }
}
