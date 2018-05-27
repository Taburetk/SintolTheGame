using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Клас в котором происходит все основоное
//В нем также хранятся важные переменные
//Эсли что все добавления коментировать
//Также в нем можно помещать методы управления кнопками

public class Game : MonoBehaviour {

	//эта переменая отвечает за деньги
	public int money; //Можно взять и лонг но я хз
	
	//А это текст на котором будет отображатся статистика(деньги)
	[SerializeField] Text text;
	void Update () {
		//Условие проверки денег на ноль
		if (money < 0) {
			money = 0;
		}
		
		//Присваиваю текущее количество денег.
		text.text = money + "$";
	}

	//Этот метод вызывается из кнопки
	//Также при выполнении он скрывает или показывает
	//магазин
	//Принимает в себя canvas
	public void ShowShop(GameObject panel) {
		panel.SetActive(!panel.activeSelf);
	}

}
