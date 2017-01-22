using UnityEngine;
using System.Collections;

public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T> {
	protected static T instance;

	public static T Instance{
		get{
			if(!instance){
				instance = FindObjectOfType(typeof(T)) as T;

				if(!instance){Debug.LogWarning(typeof(T) + "is nothing");}
			}

			return instance;
		}
	}

	protected void Awake(){
		CheckInstance();
	}

	protected bool CheckInstance(){
		if(!instance){
			instance = (T)this;
			return true;

		}else if(Instance == this){
			return true;
		}

		Destroy(this);
		return false;
	}
}
