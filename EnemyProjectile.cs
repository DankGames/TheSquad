using UnityEngine;
using System.Collections;

public class EnemyProjectile : MonoBehaviour {

	public Transform myTransform;
	public Transform player;

	public float moveSpeed;

	void Awake () {
		myTransform = transform;
		player = FindObjectOfType<PlayerHealth>().transform;
	}

	void Update () {
		myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
	}
}
