using UnityEngine;
using Zenject;
 
namespace DIExamples
{
    public class DefaultState : StateEntity
    {
        public override void Initialize()
        {
            Debug.Log("Default State");
        }
 
        public override void Start()
        {
            Debug.Log("Default State");
        }
 
        public override void Tick()
        {

        }
   
        public override void Dispose()
        {
            
        }
 
        public class Factory : Factory<DefaultState>
        {
            
        }
    }
}
