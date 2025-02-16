using UnityEngine;

public class Item : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            Debug.Log("HIT DETECTED");
        }
    }
}
