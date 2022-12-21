using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GHJ_Lib
{
	public class GameManager: MonoBehaviour
	{
		static GameManager instance;
		static public GameManager Instance
		{
			get 
			{
				if (instance == null)
				{
					GameObject newGameObject = new GameObject("_GameManager");
					instance = newGameObject.AddComponent<GameManager>();
				}
				return instance;
			}
		}

		public string nextSceneName;


		void Start()
		{
			DontDestroyOnLoad(this.gameObject);
		}

		public void ChangeScene(string sceneName)
		{
			SceneManager.LoadScene(sceneName);
		}

	}
}