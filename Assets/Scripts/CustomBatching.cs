using UnityEngine;

public class CustomBatching : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StaticBatchingUtility.Combine(gameObject);
    }
}
