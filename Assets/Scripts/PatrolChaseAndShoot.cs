using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "AI/Actions/Chase And Shoot")]
public class PatrolChaseAndShoot : Action {
	public override void Act(StateController controller) {
		Chase(controller);
	}

	private void Chase(StateController controller) {
		controller.agent.destination = controller.target.position;
		controller.agent.Resume();

		RaycastHit hit;
		
		if (Physics.SphereCast(controller.eyes.position, 2.0f, controller.eyes.forward, out hit, 15.0f) &&
		    hit.collider.CompareTag("Player")) {
			var bullet = Instantiate(controller.BulletPrefab, controller.BulletSpawnPoint.position, new Quaternion(0, 0, 0, 0));
			bullet.transform.LookAt(hit.transform);
			var rb = bullet.GetComponent<Rigidbody>();
			rb.velocity = new Vector3(0,10,0);
		}

		
	}
}
