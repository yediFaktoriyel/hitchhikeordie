//This script created by Dogu Can Seyidoglu as whole to pause the game temprorary 
using UnityEngine;
using System.Collections;

public static class myCoroutine
{
	public static IEnumerator WaitForRealSeconds (float time)
	{
		float start = Time.realtimeSinceStartup;
		while (Time.realtimeSinceStartup < (start + time)) {
			yield return null;
		}
	}
}


