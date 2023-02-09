using UnityEngine;
using System;

public class Example : MonoBehaviour
{

}

[Serializable]
struct ChunkObject
{
    public GameObject gameObject;
    [Range(0, 128)]
    public float minimumSpacingForThis;
    [Range(0, 128)]
    public float minimumSpacingForOther;
    public int amount;
    public bool placeOnFlat;
    public float tolerance;
}
