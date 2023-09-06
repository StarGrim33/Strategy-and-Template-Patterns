using UnityEngine;
using UnityEngine.Events;

public abstract class Ball : MonoBehaviour
{
    public event UnityAction<Ball> BallPopped;

    public Color Color { get; protected set; }

    private int _clicksToPop = 2;

    private void OnMouseDown()
    {
        _clicksToPop--;

        if (_clicksToPop == 0)
            BallPopped?.Invoke(this);
    }
}
