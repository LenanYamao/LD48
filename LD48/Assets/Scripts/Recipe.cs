using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Recipe : ScriptableObject
{
    public List<ItemAmount> materials;
    public List<ItemAmount> result;
}
