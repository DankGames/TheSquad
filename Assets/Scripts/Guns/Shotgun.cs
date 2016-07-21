using UnityEngine;
// using System.Collections;
using Squad.MathS ;
public class Shotgun : Weapon {
	[RangeAttribute(0.001f , 1f)] public float GunPointRadius = 1f ;
	
	public void Start() {
		NextShot = 0.5f ;
	}
	public void Update() {
		if(Time.time > NextShot) { // This is overall same for all weapons 
			NextShot += ShotSpan ;
			Fire() ;
			ShakeGun() ;
		}
	}
	public void Fire() { // MathS function is custom and can be used by including the library by Squad.MathS
	
		// var pos = new Vector3() ;
		// var angle = 0f ;
		// var shotRadius = 0f ;
		for(var i = 0 ; i < MaxShots ; i++) {
			var angle = Random.Range(0,MathS.PI2) ;
			var shotRadius = Random.Range(0,GunPointRadius);
			var pos = MathS.RotateAroundAxis(shotRadius , angle , transform.rotation.eulerAngles.y * Mathf.PI/180 , transform.position) ;
			var clone = Instantiate(object_MuzzleFlash , pos , Quaternion.identity) ;
			Destroy(clone , MuzzleSpan) ;
		}
	}
	public void ShakeGun() { // This is function to be used after shots to shake the gun .

	}
	public void OnDrawGizmos() {
		Gizmos.DrawWireSphere(transform.position , GunPointRadius) ;
	}
}
