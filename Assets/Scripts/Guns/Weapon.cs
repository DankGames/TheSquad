using UnityEngine;
// using System.Collections;

public class Weapon : MonoBehaviour {
	public GameObject object_MuzzleFlash ; // The muzzle flash game object (will be different for all guns)
	public GameObject object_gunRef ; // The reference of the gun for shaking or rotation purpose
	[RangeAttribute(0.1f,10f)] public float MuzzleSpan = 1; // The total span of muzzle taken to be destroyed ( will depend upon animation )
	[RangeAttribute(1,25)] public int MaxShots = 1 ; // Max shots fired . Required for guns like shotgun 
	[RangeAttribute(0.01f , 10f)] public float ShotSpan = 0.5f ; // The total amount of time span for next shot fired
	[RangeAttribute(1f , 10f)] public float ReloadTime = 3f ; // Not implemented yet
	[HideInInspector] public float NextShot = 0.5f ; // Used while playing to track the gun period
	
}
