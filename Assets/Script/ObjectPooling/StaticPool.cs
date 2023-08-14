using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Modulized.Utilities.ObjectPooling
{
    [System.Serializable]
    public class StaticPool<T> : Pool<T> where T : Component
    {
        public Action<T> onEveryObjectCreated;
        private Queue<T> queue;
        private Vector3 hidePosition;
        private T prefab;
        public int Count => queue.Count;

        public StaticPool(T prefab, Vector3 hidePosition, Action<T> onEveryObjectCreated = null)
        {
            this.prefab = prefab;
            this.hidePosition = hidePosition;
            if (onEveryObjectCreated != null) this.onEveryObjectCreated += onEveryObjectCreated;
            queue = new Queue<T>();
        }

        public override T GetObject()
        {
            try
            {
                var result = queue.Dequeue();
                queue.Enqueue(result);
                return result;
            }
            catch (Exception e)
            {
                Debug.Log(e.Message);
                return null;
            }
        }

        public override void CreateObjects(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                T obj = GameObject.Instantiate(prefab, hidePosition, Quaternion.identity);
                obj.gameObject.SetActive(false);
                queue.Enqueue(obj);
                if (onEveryObjectCreated != null) onEveryObjectCreated(obj);
            }
        }

        public override IEnumerable GetActiveObjects()
        {
            foreach (T obj in queue)
                if (obj.gameObject.activeInHierarchy) yield return obj;
        }

        public override IEnumerable GetInactiveObjects()
        {
            foreach (T obj in queue)
                if (!obj.gameObject.activeInHierarchy) yield return obj;
        }

        public override IEnumerable GetAllObjects()
        {
            foreach (T obj in queue)
                yield return obj;
        }
    }
}