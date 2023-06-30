using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextDialoUpdate : MonoBehaviour
{
    string[] evgen =  new[]{"Я задремал и мне приснился кошмар","Да, поел","Можно мне погулять?","Да"};
	string[] mat =  new[]{"Не ушибся?","Ладно, ладно ты поел?","Хорошо, иди погуляй"};
	string[] otets =  new[]{"Ты что упал?"," ","Надо было ночью спать","Ты вчера бересты из леса принёс?"};
	string[] dialog1_1 =  new[]{"Я туда не пойду"};
	string[] imena =  new[]{" ","Геша","Мать","Отец","Старик","Гонец","Сергей","Миха","Гонец"};
	string[] dialog1_2 =  new[]{"БЕГИ!"};
	string[] dialogDed =  new[]{"Внучок, будь добр, помоги мне муку до мельницы донести","Да, могу помочь","Как звать тебя?","Геша","Хорошее имя, а меня Павлом Михайловичем зовут","Сколько тебе лет?","Десять","А зачем продавать муку, если продают готовый хлеб?","Она дешевле, поэтому все её могут купить","А почему она дешевле?","Потому что хлеб ещё нужно выпечь из муки","Тогда почему ты не продаёшь хлеб?","Я не умею печь хлеб, моя работа молоть зёрна","И тебе это нравится?","Да, ведь я служу людям","Кем ты хочешь стать?","Я хочу защищать людей"};
	string[] dialogMih =  new[]{"Внимание! Начались рекрутские наборы.","С каждого двора по одному человеку. Кто пойдёт?","От нас идёт Михаил Александрович","Да, я иду","Хорошо, записал","А ты что тут забыл?"};
	
	public static int replWhat;
	public static int WhatFace;
	
	[SerializeField] Text text2;
	[SerializeField] Text text3;
	[SerializeField] private GameObject okon;// это окна
	
	private bool one;
	
    void Start()
    {
		if(Dialog.whatDialog == 1)
		{
			replWhat = 1;
		}
    }

    void Update()
    {
		if(Dialog.whoSay == 0)
		{
			okon.SetActive(false);
			text3.text = imena[Dialog.whoSay];
		}
		else
		{
			okon.SetActive(true); 
			text3.text = imena[Dialog.whoSay];
		}

        if(Dialog.whatDialog == 1)
		{
			
			if(Input.GetKeyDown(KeyCode.E))
			{
				replWhat += 1;
			}
				switch(replWhat)
                {
					case 1: { text2.text = otets[0]; Dialog.whoSay = 3; break; }
					case 2: { text2.text = mat[0]; Dialog.whoSay = 2; break; }
					case 3: { text2.text = evgen[0]; Dialog.whoSay = 1; break; }
					case 4: { text2.text = otets[2]; Dialog.whoSay = 3; break; }
					case 5: { text2.text = mat[1]; Dialog.whoSay = 2; break; }
					case 6: { text2.text = evgen[1]; Dialog.whoSay = 1; break; }
					case 7: { text2.text = evgen[2]; Dialog.whoSay = 1; break; }
					case 8: { text2.text = otets[3]; Dialog.whoSay = 3; break; }
					case 9: { text2.text = evgen[3]; Dialog.whoSay = 1; break; }
					case 10: { text2.text = mat[2]; Dialog.whoSay = 2; WhatFace = 1;break; }
					case 11: { text2.text = otets[1]; Dialog.whatDialog = 0; replWhat = 0; Dialog.whoSay = 0; WhatFace = 0; break; }
					default: break;
				} 
			
		}

		if(Dialog.whatDialog == 2)
		{
			
			if(Input.GetKeyDown(KeyCode.E))
			{
				replWhat += 1;
			}
				switch (replWhat)
				{
					case 0: { text2.text = dialogDed[0]; Dialog.whoSay = 4; break; }
					case 1: { text2.text = dialogDed[1]; Dialog.whoSay = 1; TimeLine.DialogDed = 1; StartCoroutine(Ded()); break; }
					case 2: { text2.text = dialogDed[2]; Dialog.whoSay = 4; break; }
					case 3: { text2.text = dialogDed[3]; Dialog.whoSay = 1; break; }
					case 4: { text2.text = dialogDed[4]; Dialog.whoSay = 4; break; }
					case 5: { text2.text = dialogDed[5]; Dialog.whoSay = 4; break; }
					case 6: { text2.text = dialogDed[6]; Dialog.whoSay = 1; break; }
					case 7: { text2.text = dialogDed[7]; Dialog.whoSay = 1; break; }
					case 8: { text2.text = dialogDed[8]; Dialog.whoSay = 4; break; }
					case 9: { text2.text = dialogDed[9]; Dialog.whoSay = 1; break; }
					case 10: { text2.text = dialogDed[10]; Dialog.whoSay = 4; break; }
					case 11: { text2.text = dialogDed[11]; Dialog.whoSay = 1; break; }
					case 12: { text2.text = dialogDed[12]; Dialog.whoSay = 4; break; }
					case 13: { text2.text = dialogDed[13]; Dialog.whoSay = 1; break; }
					case 14: { text2.text = dialogDed[14]; Dialog.whoSay = 4; break; }
					case 15: { text2.text = dialogDed[15]; Dialog.whoSay = 4; break; }
					case 16: { text2.text = dialogDed[16]; Dialog.whoSay = 1; break; }
					case 17: { text2.text = otets[1]; Dialog.whatDialog = 4; Dialog.whoSay = 0; replWhat = 0; WhatFace = 0; break; }
					default: break;
				} 
		}

		 if(Dialog.whatDialog == 3)
		{
			
			if(Input.GetKeyDown(KeyCode.E))
			{
				replWhat += 1;
			}
				switch (replWhat)
				{
					case 0: { text2.text = dialogMih[0]; Dialog.whoSay = 5; break; }
					case 1: { text2.text = dialogMih[1]; Dialog.whoSay = 5; break; }
					case 2: { text2.text = dialogMih[2]; Dialog.whoSay = 6; break; }
					case 3: { text2.text = dialogMih[3]; Dialog.whoSay = 7; WhatFace = 1; break; }
					case 4: { text2.text = dialogMih[4]; Dialog.whoSay = 5; TimeLine.DialogDed = 2; break; }
					case 5: { text2.text = dialogMih[5]; Dialog.whoSay = 5; WhatFace = 1; break; }
					case 6: { text2.text = otets[1]; Dialog.whatDialog = 0; Dialog.whoSay = 0; replWhat = 0; WhatFace = 0; break; }
					default: break;
				}
				
			
		 }

		if(Dialog.whatDialog == 5)
		{
			
			if(Input.GetKeyDown(KeyCode.E))
			{
				replWhat += 1;
			}
				switch(replWhat)
                {
					case 0: { text2.text = dialog1_1[0]; Dialog.whoSay = 1; break; }
					case 1: { text2.text = otets[1]; Dialog.whatDialog = 0; Dialog.whoSay = 0; replWhat = 0;  WhatFace = 0;break; }
					default: break;
				}
			
		}

		if(Dialog.whatDialog == 4 && one == true)
		{
			
			
				switch (replWhat)
				{
					case 0: 
					{ 
						TimeLine.DialogDed = 3;
						text2.text = dialog1_2[0]; 
						Dialog.whoSay = 4; 
						WhatFace = 1;
						Time.timeScale = 0.5f;
						Time.fixedDeltaTime = Time.timeScale * 0.1f;
						WhatFace = 0;
						break;
					}
						//case 1: { text2.text = otets[1]; Dialog.whatDialog = 0; Dialog.whoSay = 0; replWhat = 0; break; }
						default: break;
				}
				
			
		}
			IEnumerator Ded()
			{
				yield return  new WaitForSeconds(30f);
				one = true;
			}
    }
	
}
