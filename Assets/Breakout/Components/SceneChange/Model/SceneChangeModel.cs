using UnityEngine;
using UnityEngine.SceneManagement;

namespace My.Breakout
{
    public class SceneChangeModel
    {
        public void ChangeScene(SceneType sceneType)
        {
            switch (sceneType)
            {
                case SceneType.Title:
                    SceneManager.LoadScene("TitleScene");
                    break;

                case SceneType.StageSelect:
                    SceneManager.LoadScene("StageSelectScene");
                    break;

                case SceneType.Game:
                    SceneManager.LoadScene("GameScene");
                    break;

                case SceneType.Result:
                    SceneManager.LoadScene("ResultScene");
                    break;
            }
        }
    }
}
