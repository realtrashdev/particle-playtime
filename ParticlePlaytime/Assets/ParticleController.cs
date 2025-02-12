using UnityEngine;

public class ParticleController : MonoBehaviour
{
    [SerializeField] private GameObject system;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            system.SetActive(!system.activeInHierarchy);
        }
    }
}
