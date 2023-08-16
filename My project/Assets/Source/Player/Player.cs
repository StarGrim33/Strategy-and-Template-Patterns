using UnityEngine;

public class Player : MonoBehaviour
{
    public int Reputation { get; private set; } = 2; // По-хорошему это не должно тут быть, надо вынести в отдельный класс со своей логикой, просто для наглядности

    public void IncreaseReputation()
    {
        Reputation += 1;
    }
}
