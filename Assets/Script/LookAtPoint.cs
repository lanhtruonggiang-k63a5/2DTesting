//C# Example (LookAtPoint.cs)
using UnityEngine;

[ExecuteInEditMode]
public class LookAtPoint : MonoBehaviour
{
    public Transform thing;
    
    void Update()
    {
        transform.LookAt(thing.transform.position);
        
    }
}