using UnityEngine;

namespace Runner
{
    public class OldPlayerController : BasePlayerController
    {
        protected override void Start()
        {
            base.Start();
        }

        void FixedUpdate()
        {
            if (Input.GetKeyDown(KeyCode.Space)) Jump();

<<<<<<< HEAD
            var direction = Input.GetAxis("Horizontal") * playerStatsComponent.SideSpeed * Time.fixedDeltaTime;

            if (direction == 0f) return;
            rigidbody.velocity += direction * transform.right;
=======
            var direction = Input.GetAxis("Horizontal") * GetComponent<PlayerStatsComponent>().SideSpeed * Time.fixedDeltaTime;

            if (direction == 0f) return;
            GetComponent<Rigidbody>().velocity += direction * transform.right;
>>>>>>> ffa051f9242556a2c0ba2b000c77b01557862420
        }
	}
}
