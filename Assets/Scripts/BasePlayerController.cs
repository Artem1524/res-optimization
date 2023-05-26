using System.Collections;
using UnityEngine;

namespace Runner
{
    [RequireComponent(typeof(Rigidbody), typeof(PlayerStatsComponent))]
    public abstract class BasePlayerController : MonoBehaviour
    {
        protected Rigidbody rigidbody;
        protected PlayerStatsComponent playerStatsComponent;
        
        protected virtual void Start()
        {
            rigidbody = GetComponent<Rigidbody>();
            playerStatsComponent = GetComponent<PlayerStatsComponent>();
        }
        
        protected virtual void Update()
        {
            MoveForward();
        }

        protected void Jump()
        {
            float jumpForce = playerStatsComponent.JumpForce;
            rigidbody.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }

        private void MoveForward()
        {
            float forwardSpeed = playerStatsComponent.ForwardSpeed;
            transform.position += transform.forward * forwardSpeed * Time.deltaTime;
        }
    }
}
