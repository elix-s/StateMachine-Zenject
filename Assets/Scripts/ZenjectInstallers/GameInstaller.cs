using UnityEngine;
using Zenject;

namespace DIExamples
{
    public class GameInstaller : MonoInstaller<GameInstaller>
    {
        [SerializeField] private GameObject _playerPrefab;
        public PlayerController Player;

        #region Private Methods

        private void InstallGameController()
        {
            Player = Container.InstantiatePrefabForComponent<PlayerController>(_playerPrefab);

            Container.BindInstance(Player).AsSingle();

            Container.Bind<StateFactory>().AsSingle();
 
            Container.BindInterfacesAndSelfTo<DefaultState>().AsSingle();
            Container.BindInterfacesAndSelfTo<MoveState>().AsSingle();
            Container.BindInterfacesAndSelfTo<DestroyState>().AsSingle();
 
            Container.BindFactory<DefaultState, DefaultState.Factory>().WhenInjectedInto<StateFactory>();
            Container.BindFactory<MoveState, MoveState.Factory>().WhenInjectedInto<StateFactory>();
            Container.BindFactory<DestroyState, DestroyState.Factory>().WhenInjectedInto<StateFactory>();
        }

        #endregion

        #region Public Methods

        public override void InstallBindings()
        {
            InstallGameController();
        }

        #endregion
    }
}