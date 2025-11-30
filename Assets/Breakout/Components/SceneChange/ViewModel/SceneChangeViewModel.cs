using UnityEngine;
using Zenject;

namespace My.Breakout
{
    public class SceneChangeViewModel
    {
        private SceneChangeModel _sceneChangeModel;

        [Inject]
        public SceneChangeViewModel
            (
                SceneChangeModel sceneChangeModel
            )
        {
            _sceneChangeModel = sceneChangeModel;
        }

        public void ChangeScene(SceneType sceneType)
        {
            _sceneChangeModel.ChangeScene(sceneType);
        }
    }
}