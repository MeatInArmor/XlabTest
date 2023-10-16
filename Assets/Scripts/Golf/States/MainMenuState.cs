using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Golf
{
    public class MainMenuState : GameState
    {
        public LevelController levelController;
        public GameState gameplayState;
        public TMP_Text scoreText;

        public void PlayGame()
        {
            Exit();
            gameplayState.Enter();
        }
        protected override void OnEnable()
        {
            base.OnEnable();
            scoreText.text = $"   HScore: {levelController.hightScore}";
        }
    }
}
