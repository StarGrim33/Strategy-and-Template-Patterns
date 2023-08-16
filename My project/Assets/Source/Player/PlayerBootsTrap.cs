using UnityEngine;

public class PlayerBootsTrap : MonoBehaviour
{
    private PlayerShooting _playerShooting;

    private void Start()
    {
        _playerShooting = GetComponent<PlayerShooting>();
        _playerShooting.Init();
    }
}
