using System;
using System.Collections;
using UnityEngine;
using Zenject;
 
namespace DIExamples
{
    public class DestroyState : StateEntity
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
            Debug.Log("Destroy State");
        }
 
        public override void Start()
        {
            _playerController.PlayerDestroyed();
        }
 
        public override void Tick()
        {

        }
   
        public override void Dispose()
        {
            
        }
 
        public class Factory : Factory<DestroyState>
        {
            
        }
    }
}