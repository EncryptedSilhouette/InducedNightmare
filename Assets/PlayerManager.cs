using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public PlayerController controller { get; private set;  }

    void Start()
    {
        controller = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
