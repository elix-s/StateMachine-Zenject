using UnityEngine;
using Zenject;
using DIExamples;
 
namespace UI
{
    public class ChangeState : MonoBehaviour
    {
        [Inject]
        readonly GameController _gameController;

        #region Public Methods
 
        public void Default()
        {
            _gameController.ChangeState(GameState.Default);
        }
 
        public void Move()
        {
            _gameController.ChangeState(GameState.Move);
        }
 
        public void Destroy()
        {
            _gameController.ChangeState(GameState.Destroy);
        }

        #endregion
    }
}