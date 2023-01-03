using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

namespace GHJ_Lib
{
	public class Uicontrol: MonoBehaviour
	{
		/*--- Public Fields ---*/


		/*--- Protected Fields ---*/


		/*--- Private Fields ---*/


		/*--- MonoBehaviour Callbacks ---*/
		void Start()
		{
			transform.DOMove(new Vector3(100, 100), 2f);		
		}
		void Update()
		{
		
		}


		/*--- Public Methods ---*/


		/*--- Protected Methods ---*/


		/*--- Private Methods ---*/
	}
}