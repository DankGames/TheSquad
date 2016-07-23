using UnityEngine;
// using System.Collections;
using Squad.MathS ;
public class MachineGun : Weapon {

	[RangeAttribute(0.001f , 1f)] public float GunPointRadius = 0.5f ;
	private float nextAngle = 0 ;
	[RangeAttribute(0,360)] public float arcDistance = 30f ;

	public bool Rotation = true ;
	public float ArcDistance {
		get {
			return arcDistance * Mathf.PI/180 ;
		}
	}
	public float RotationSpeed ;
	private void Update () {
		var deltaTime = Time.deltaTime ;
		if(Time.time > NextShot) { // Same for all guns scripts
			NextShot += ShotSpan ;
			Fire() ;

			if(Rotation) object_gunRef.transform.Rotate(0,RotationSpeed * deltaTime ,0) ; //RotateGun() ;
			ShakeGun() ;
		}
	}
	private void Fire() { // MathS function is custom and can be used by including the library by Squad.MathS
		nextAngle += ArcDistance ;
		var pos = MathS.RotateAroundAxis(GunPointRadius , nextAngle , transform.rotation.eulerAngles.y * Mathf.PI/180 , transform.position) ;
		var clone = Instantiate(object_MuzzleFlash , pos , Quaternion.identity) ;
		Destroy(clone , MuzzleSpan);
	}
	// private void RotateGun() {
	// 	// var rot = object_gunRef.transform.rotation.eulerAngles ;
		
	// 	// object_gunRef.transform.rotation.SetAxisAngle(rot , nextAngle * 180 / Mathf.PI ) ; // = Quaternion.Euler (	rot.x ,
	// 															// nextAngle * 180 / Mathf.PI ,
	// 															// rot.z
	// 														// ) ;


	// }
	private void ShakeGun() {
		
	}
	public void OnDrawGizmos() {
		Gizmos.DrawWireSphere(transform.position , GunPointRadius) ;
	}
}
