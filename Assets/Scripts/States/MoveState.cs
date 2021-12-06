using UnityEngine;
using Zenject;
 
namespace DIExamples
{
    public class MoveState : StateEntity
    {
        [SerializeField] private GameObject _player;
        [SerializeField] private PlayerController _playerController;

        [Inject]
        private void Construct(PlayerController playerController)
        {
            _player = playerController.gameObject;
            _playerController = playerController;
        }

        public override void Initialize()
        {
            Debug.Log("Move State");
        }
 
        public override void Start()
        {
            _playerController.PlayerMoving();
        }
 
        public override void Tick()
        {

        }
 
        public override void Dispose()
        {
           
        }
 
        public class Factory : Factory<MoveState>
        {
            
        }
    }
}