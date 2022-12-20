using System.Collections;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GHJ_Lib
{
	public class Head: MonoBehaviour
	{
		[SerializeField]
		private Material material;

        [SerializeField]
        private Transform headTransform;

        string x = "_HeadX";
        string y = "_HeadY";
        string z = "_HeadX";

        void Update()
        {
            material.SetFloat(x, headTransform.position.x);
            material.SetFloat(y, headTransform.position.y);
            material.SetFloat(z, headTransform.position.z);
        }

    }
}