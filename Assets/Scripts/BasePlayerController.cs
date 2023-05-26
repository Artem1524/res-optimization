using System.Collections;
using UnityEngine;

namespace Runner
{
    [RequireComponent(typeof(Rigidbody), typeof(PlayerStatsComponent))]
    public abstract class BasePlayerController : MonoBehaviour
    {
<<<<<<< HEAD
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
=======
        protected virtual void Start()
        {
            StartCoroutine(MoveForward());
>>>>>>> ffa051f9242556a2c0ba2b000c77b01557862420
        }

        protected void Jump()
        {
<<<<<<< HEAD
            float jumpForce = playerStatsComponent.JumpForce;
            rigidbody.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }

        private void MoveForward()
        {
            float forwardSpeed = playerStatsComponent.ForwardSpeed;
            transform.position += transform.forward * forwardSpeed * Time.deltaTime;
        }
=======
            GetComponent<Rigidbody>().AddForce(transform.up * GetComponent<PlayerStatsComponent>().JumpForce, ForceMode.Impulse);
        }

        private IEnumerator MoveForward()
        {
            while(true)
            {
                transform.position += transform.forward * GetComponent<PlayerStatsComponent>().ForwardSpeed * Time.deltaTime;
                yield return null;
			}
		}
>>>>>>> ffa051f9242556a2c0ba2b000c77b01557862420
    }
}
