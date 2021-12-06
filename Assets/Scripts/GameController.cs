using UnityEngine;
using UnityEngine.UI;
using Zenject;
 
namespace DIExamples
{
    public class GameController : MonoBehaviour
    {
        #region Private Variables

        private StateFactory _stateFactory;
        private StateEntity _stateEntity = null;
        [SerializeField] private GameState _currentGameState;
        [SerializeField] private GameState _previousGameState;
        [SerializeField] Text _currentStateText;

        #endregion

        #region Class Construct
 
        [Inject]
        private void Construct(StateFactory stateFactory)
        {
            _stateFactory = stateFactory;
        }

        #endregion

        #region Internal Methods

        internal void ChangeState(GameState gameState)
        {
            if(_stateEntity != null)
            {
                _stateEntity.Dispose();
                _stateEntity = null;
            }
 
            _previousGameState = _currentGameState;
            _currentGameState = gameState;
            _stateEntity = _stateFactory.CreateState(gameState);

             _currentStateText.text = gameState.ToString();
             
            _stateEntity.Start();
        }

        #endregion

        #region MonoBehavior
 
        void Start()
        {
            ChangeState(GameState.Default);
        }

        #endregion
 
    }
}