using UnityEngine;
// using System.Collections;
using UnityEngine.UI ;
public class EnemyHealth : MonoBehaviour {

	private float health ;
	private float maxHealth ;
	public float Health {
		set {
			health = value ;
		}
		get {
			return health ;
		}
	}
	
	public Slider slider_Health ;

	public void Start() {
		slider_Health.maxValue = maxHealth ;
		slider_Health.value = maxHealth ;
	}
	public void Update() {
		// if(slider_Health.)
	}

}
