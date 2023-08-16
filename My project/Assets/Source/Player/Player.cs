using UnityEngine;

public class Player : MonoBehaviour
{
    public int Reputation { get; private set; } = 2; // ��-�������� ��� �� ������ ��� ����, ���� ������� � ��������� ����� �� ����� �������, ������ ��� �����������

    public void IncreaseReputation()
    {
        Reputation += 1;
    }
}
