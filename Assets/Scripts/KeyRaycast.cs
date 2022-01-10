using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KeySystem
{
    public class KeyRaycast : MonoBehaviour
    {
        //just making some variables here idk
        [SerializeField] private int rayLength = 5;
        [SerializeField] private LayerMask LayerMaskInteract;
        [SerializeField] private string exluseLayerName = null;

        private KeyItemController raycastedobject;
        
    }
}