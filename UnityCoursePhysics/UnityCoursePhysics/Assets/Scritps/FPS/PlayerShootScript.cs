﻿using UnityEngine;
using System.Collections;

public class PlayerShootScript : MonoBehaviour
{

	//Допълнете скрипта, по следния начин:
	//С левия бутон на мишката трябва да стреля
	//Трябва да има два режима на стрелба, които се сменят с клавиши 1 и 2 Keycode.Alpha1/Keycode.Alpha2. За режимите използвайте промениливата isInBulletHoleMode
	//Режим 1 прави "дупка в стената" като просто инстанцира bulletholepfb и го слага в точката на удара (raycast) и му прави ротацията като на уцеления обект
	//Режим 2 инстанцира bulletPfb и го изтрелва от позиция/ротация newBulletPosition чрез rigibody.AddRelativeForce

	public GameObject bulletHolePfb;
    public GameObject bulletPfb;
    public GameObject newBulletPosition;

    bool isInBulletHoleMode;

    void Start()
    {
	    //Time.timeScale = 0.2f;
	    //Time.fixedDeltaTime = 0.005f;
    }

	// Update is called once per frame
	void Update()
	{
		
		if (Input.GetKeyDown(KeyCode.LeftShift))
		{
			Time.timeScale = 0.2f;
			Time.fixedDeltaTime = 0.005f;
		}

		if (Input.GetKeyUp(KeyCode.LeftShift))
		{
			Time.timeScale = 1f;
			Time.fixedDeltaTime = 0.02f;
		}
	}

}