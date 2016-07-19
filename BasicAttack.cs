using UnityEngine;

public class BasicAttack : MonoBehaviour {

	public GameObject target;

	public int damage;

	public float range = 4;
	public float attackTimer;
	public float cooldown = 2.0f;

	public GameObject projectile;

	PlayerHealth ph;

	void Start () {

		attackTimer = 0;

		ph = FindObjectOfType<PlayerHealth>();
	}

	void Update () {

		if (attackTimer > 0) {
			attackTimer -= Time.deltaTime;
		}
		if (attackTimer <= 0) {
			attackTimer = 0;
		}
	}

	public void Attack() {

		if (!ph.isDead) {

			if (attackTimer == 0) {

				float distance = Vector3.Distance(target.transform.position, transform.position); //calculating distance

				//calculating direction
				Vector3 dir = (target.transform.position - transform.position).normalized;
				float direction = Vector3.Dot(dir, transform.forward);

				if (distance < range) { //making player not be able to attack if too far

					if (direction > 0) { //making player not be able to attack if target not in front of him

						Debug.Log("Attack");
						Instantiate(projectile, transform.position, transform.rotation);

						ph = (PlayerHealth)target.GetComponent("PlayerHealth");
						ph.TakeDamage(-damage);
					}
				}
				attackTimer = cooldown;
			}
		}
	}
}
