using System;
using Zenject;

public class LevelLoadingData
{
    private int _gameMode;

    [Inject]
    public LevelLoadingData(int gameMode)
    {
        GameMode = gameMode;
    }

    public int GameMode
    {
        get { return _gameMode; }
        set 
        { 
            if(value < 0)
                throw new ArgumentOutOfRangeException("value");

            _gameMode = value; 
        }
    }
}
