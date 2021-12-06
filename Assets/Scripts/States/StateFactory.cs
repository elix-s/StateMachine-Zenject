using ModestTree;
 
namespace DIExamples
{
    internal enum GameState
    {
        Default,
        Move,
        Destroy
    }
 
    public class StateFactory
    {
        #region Readonly Variables

        readonly DefaultState.Factory _defaultFactory;
        readonly MoveState.Factory _moveFactory;
        readonly DestroyState.Factory _destroyFactory;

        #endregion

        #region Internal Methods

        internal StateEntity CreateState(GameState gameState)
        {
            switch (gameState)
            {
                case GameState.Default:
                    return _defaultFactory.Create();
 
                case GameState.Move:
                    return _moveFactory.Create();
 
                case GameState.Destroy:
                    return _destroyFactory.Create();
 
            }
 
            throw Assert.CreateException("");
        }

        #endregion

        #region Private Methods
 
        private StateFactory(DefaultState.Factory defaultFactory,
                            MoveState.Factory moveFactory,
                            DestroyState.Factory destroyFactory)
        {
            _defaultFactory = defaultFactory;
            _moveFactory = moveFactory;
            _destroyFactory = destroyFactory;
        }

        #endregion
    }
}
