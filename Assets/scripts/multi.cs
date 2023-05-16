using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;
public class MultiplePrefabs : MonoBehaviour
{
    public List<GameObject> Prefabs;
    private ARPlacementInteractable interacatable;
    private int prefabIndex;
    // Start is called before the first frame update
    void Awake()
    {
        SetPrefabIndex();
        interacatable = GetComponent<ARPlacementInteractable>();
        interacatable.placementPrefab = Prefabs[prefabIndex];
    }
    void SetPrefabIndex()
    {
        prefabIndex = Random.Range(0, Prefabs.Count);
    }
    public void ResetPrefab()
    {
        SetPrefabIndex();
        interacatable.placementPrefab = Prefabs[prefabIndex];
    }
}