using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace GHJ_Lib
{
	public class StartLoading: MonoBehaviour
	{
		AsyncOperation async;
        [SerializeField] Image LoadingBar;
        [SerializeField] Text Loadingtext;
        string[] loadingText = { "�ε���", "�ε���.", "�ε���..", "�ε���...","�ε��Ϸ�!"};
        WaitForSeconds loadingSecond = new WaitForSeconds(0.1f);
        WaitForSeconds loadingTextSecond = new WaitForSeconds(0.5f);

        [SerializeField] string NextSceneName;
        void Start()
		{
            GameManager.Instance.nextSceneName = NextSceneName;
            StartCoroutine(LoadingNextScene(NextSceneName));
            StartCoroutine(LoadingText());
        }

		IEnumerator LoadingNextScene(string nextSceneName)
		{
            async = SceneManager.LoadSceneAsync(nextSceneName); //������ ����� ������ ���� ��ȯx
            async.allowSceneActivation = false; //�̰� true�� �Ǹ� ����ȯ�� ��
            while (async.progress < 0.9f) //90�ۼ�Ʈ �ε��� �ȵǾ��ִٸ�
            {
                LoadingBar.fillAmount = async.progress;
                yield return true;
            }

            while (async.progress >= 0.9f)
            {
                yield return loadingTextSecond;
                LoadingBar.fillAmount = 1.0f;
                break;
            }
            async.allowSceneActivation = true;
            yield return true;
        }

        IEnumerator LoadingText()
        {
            int i = 0;

            while (async.progress < 0.9f) //90�ۼ�Ʈ �ε��� �ȵǾ��ִٸ�
            {
                if (i > 3)
                {
                    i = 0;
                }
                Loadingtext.text = loadingText[i];
                yield return loadingTextSecond;
                i++;
            }
            while (async.progress >= 0.9f)
            {
                Loadingtext.text = loadingText[4];
                yield return loadingSecond;
                break;
            }
            yield return true;
        }

    }
}