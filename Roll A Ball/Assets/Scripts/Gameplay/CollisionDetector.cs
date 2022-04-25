using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionDetector : MonoBehaviour
{
    [Serializable]
    public struct Actions
    {
        public string tag;
        public bool destroy;
        public UnityEvent action;
    }

    [SerializeField] private Actions[] triggerActions;

    private void OnTriggerEnter(Collider other)
    {
        foreach (Actions n in triggerActions)
        {
            if (n.tag != other.tag) { continue; }
            n.action.Invoke();

            if (!n.destroy) { continue; }
            Destroy(other.gameObject);
        }
    }
}
