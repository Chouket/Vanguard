// VanguardEditor.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "iostream"
#include "BaseCard.h"

int main()
{
	std::cout << "coucou" << std::endl;

	Vanguard::BaseCard firstCard = Vanguard::BaseCard("Harri", 3, 11000, 5000,
		Vanguard::UNIT_TYPE::NORMAL,
		Vanguard::UNIT_CLAN::PALE_MOON,
		"Enjoy The Show !",
		"[Generation Break 2]");

	Vanguard::BaseCard secondCard = Vanguard::BaseCard("Harriiiii", 3, 11000, 5000,
		Vanguard::UNIT_TYPE::NORMAL,
		Vanguard::UNIT_CLAN::PALE_MOON,
		"Enjoy The Show !",
		"[Generation Break 2]");

	firstCard.Show();
	secondCard.Show();

	while (1)
	{

	}

    return 0;
}

