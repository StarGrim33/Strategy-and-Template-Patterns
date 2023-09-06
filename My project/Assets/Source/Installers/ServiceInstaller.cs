using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ServiceInstaller : MonoInstaller
{
    [SerializeField] private List<Ball> _balls;

    public override void InstallBindings()
    {
        BindGame();
    }

    private void BindGame()
    {
        Container.Bind<List<Ball>>().FromInstance(_balls).AsSingle();
    }
}