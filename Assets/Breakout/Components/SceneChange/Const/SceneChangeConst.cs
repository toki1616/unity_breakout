using UnityEngine;

namespace My.Breakout
{
    public enum SceneType
    {
        Title,
        StageSelect,
        Game,
        Result
    }

    public static class SceneTypeExtensions
    {
        public static string ToJapaneseString(this SceneType sceneType)
        {
            switch (sceneType)
            {
                case SceneType.Title:
                    return "タイトル";

                case SceneType.StageSelect:
                    return "ステージセレクト";

                case SceneType.Game:
                    return "ゲーム";

                case SceneType.Result:
                    return "リザルト";

                default:
                    return string.Empty;
            }
        }
    }
}