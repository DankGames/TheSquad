using UnityEngine;

public class EnemyLongRange : MonoBehaviour {

	public float moveSpeed;
	public float rotationSpeed;
	public float minDistance = 50f; //the minimum distance at which he can approach

	private float distance;			//current distance between enemy and player

	public bool isOnMinDistance;	//is distance = minDistance

	public Transform player;

	private Transform myTransform; //enemy transform

	public string playerTag = "Player";

	public string parameter;
	public int attackID;
	public int runID;

	private Animator anim;

	private BasicAttack attack;

	void Awake () {
		myTransform = transform;
	}

	void Start () {

		attack = GetComponent<BasicAttack>();
		anim = GetComponent<Animator> ();

		GameObject go = GameObject.FindGameObjectWithTag (playerTag);

		player = go.transform;

	}

	void Update () {

		Follow ();
	}

	void Follow () {

		//look at target
		myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (player.position - myTransform.position), rotationSpeed * Time.deltaTime);

		distance = Vector3.Distance (player.transform.position, myTransform.transform.position);

		if (distance <= minDistance) {
			isOnMinDistance = true;
		}
		else if (distance >= minDistance) {
			isOnMinDistance = false;
		}
		if (isOnMinDistance) {
			//attack
			attack.Attack();
			anim.SetInteger(parameter, attackID);
		}
		else if (!isOnMinDistance) {
			//look at target
			//myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (player.position - myTransform.position), rotationSpeed * Time.deltaTime);

			//follow target
			myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;

			anim.SetInteger(parameter, runID);
		}
	}
}
