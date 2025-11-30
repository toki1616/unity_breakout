using UnityEngine;
using UnityEngine.UI;
using R3;
using Zenject;

namespace My.Breakout
{
    public class TestSceneChange : MonoBehaviour
    {
        [Inject]
        private SceneChangeViewModel _sceneChangeViewModel;

        [SerializeField]
        private SceneType _sceneType;

        private Button _button;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _button = this.GetComponent<Button>();
            var buttonText = _button.GetComponentInChildren<Text>();
            buttonText.text = _sceneType.ToJapaneseString();

            _button.OnClickAsObservable().Subscribe(_ => OnClickButton()).AddTo(this);
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnClickButton()
        {
            _sceneChangeViewModel.ChangeScene(_sceneType);
        }
    }
}