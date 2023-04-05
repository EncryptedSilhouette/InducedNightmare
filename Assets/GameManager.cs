using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameControls controls { get; private set;  }

    [SerializeField]
    private GameObject _playerPrefab;
    public GameObject playerPrefab => _playerPrefab;

    private void Awake()
    {
        controls = new GameControls();
    }
}
