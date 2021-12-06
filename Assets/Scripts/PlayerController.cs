using UnityEngine;
using Zenject;

namespace DIExamples
{
    public class PlayerController : MonoBehaviour
    {
        #region Public Methods

        public void PlayerMoving()
        {
            transform.Translate(5.0f, 0.0f, 0.0f);
        }

        public void PlayerDestroyed()
        {
            Destroy(gameObject);
        }

        #endregion
    }
}
