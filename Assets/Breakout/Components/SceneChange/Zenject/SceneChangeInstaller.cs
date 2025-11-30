using UnityEngine;
using Zenject;

namespace My.Breakout
{
    public class SceneChangeInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Debug.Log("SceneChangeInstaller : run");

            //Model
            Container.Bind<SceneChangeModel>().AsSingle();

            //ViewModel
            Container.Bind<SceneChangeViewModel>().AsSingle();
        }
    }
}