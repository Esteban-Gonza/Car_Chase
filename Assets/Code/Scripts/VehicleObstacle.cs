using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleObstacle : MonoBehaviour{

    [SerializeField] float speed;

    private void Update(){
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}