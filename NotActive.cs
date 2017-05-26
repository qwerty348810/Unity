using UnityEngine;

public class NotActive : MonoBehaviour {
    public GameObject active;
    void Start()
    {
        active.SetActive(false);
    }

}
