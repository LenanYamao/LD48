using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif

[CreateAssetMenu]
public class Item : ScriptableObject
{
	[SerializeField] string id;
	public string ID { get { return id; } }
	public new string name;
    public string desc;
    public Sprite sprite;

	#if UNITY_EDITOR
	protected virtual void OnValidate()
	{
		string path = AssetDatabase.GetAssetPath(this);
		id = AssetDatabase.AssetPathToGUID(path);
	}
	#endif
}
