using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour {

	public void ResetScene (string scene) {
		/// Called when the 'SignPost' game object is clicked
		/// - Reloads the scene

		// Prints to the console when the method is called
		Debug.Log ("'SignPost.ResetScene()' was called");

        SceneManager.LoadScene(scene);
    }
}
