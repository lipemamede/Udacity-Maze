using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {



    public GameObject coinPoofPrefab;
    DieAfterSeconds timeToDestroy;


    void Update () {
        transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
    }


	public void OnCoinClicked () {
		// Prints to the console when the method is called
		Debug.Log ("'Coin.OnCoinClicked()' was called");

        Instantiate<GameObject>(coinPoofPrefab, transform.position, transform.rotation);

	}
}
