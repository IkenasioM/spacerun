using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjectCanvas : MonoBehaviour {
    [SerializeField] GameObject Vehicule;
    void Start () {
        GameObject enemy = Instantiate(Vehicule, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
        enemy.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
    }
}
