#pragma once

#include <iostream>

namespace Vanguard
{
	static unsigned int last_id = 0;

#pragma region CardEnum

	enum UNIT_TYPE
	{
		NO_TYPE = 0,
		NORMAL,
		TRIGGER,
		SENTINEL,
		G,

		TYPE_NB
	};

	enum UNIT_CLAN
	{
		NO_CLAN = 0,

		//United Sanctuary
		ROYAL_PALADIN,
		GOLD_PALADIN,
		SHADOW_PALADIN,
		ORACLE_THINK_TANK,
		ANGEL_FEATHER,
		GENESIS,

		//Dragon Empire
		KAGERO,
		NARUKAMI,
		TACHIKAZE,
		NUBATAMA,
		MURAKUMO,

		//Star Gate
		LINK_JOKER,
		NOVA_GRAPPLER,
		DIMENSION_POLICE,
		ETRANGER,

		//Dark Zone
		DARK_IRREGULARS,
		PALE_MOON,
		SPIKE_BROTHERS,
		GEAR_CHRONICLE,

		//Zoo
		NEO_NECTAR,
		GREAT_NATURE,
		MEGA_COLONY,

		//Magallanica
		GRANBLUE,
		BERMUDA_TRIANGLE,
		AQUA_FORCE,

		CLAN_NB

	};

	enum UNIT_NATION
	{
		NO_NATION = 0,
		UNITED_SANCTUARY, 
		// X Paladin, Oracle Think Tank, Angel Feather, Genesis
		DRAGON_EMPIRE,
		// Kagero, Narukami, Tachikaze, Nubatama, Murakumo
		STAR_GATE,
		// Link Joker, Nova Grappler, Dimension Police, Etranger
		DARK_ZONE,
		// Dark Irregulars, Pale Moon, Spike Brothers, Gear Chronicle
		ZOO,
		// Neo Nectar, Great Nature, Mega Colony
		MAGALLANICA,
		// Granblue, Bermuda Triangle, Aqua Force

		NATION_NB
	};

#pragma endregion

	class BaseCard
	{
	public:
		BaseCard(std::string name, unsigned int grade,
				 unsigned int atk, unsigned int def,
				 UNIT_TYPE type, UNIT_CLAN clan,
				 std::string flavourTxt, std::string effectDesc);

		void Show();

	private:
		//Function
		UNIT_NATION GetNationFromClan(UNIT_CLAN clan);
		std::string GetTypeNameFromTypeEnum(UNIT_TYPE type);
		std::string GetClanNameFromClanEnum(UNIT_CLAN clan);
		std::string GetNationNameFromNationEnum(UNIT_NATION nation);


		//Variable
		std::string _name = "None";

		//image ?

		unsigned int _grade = 0;
		unsigned int _atk = 0;
		unsigned int _def = 0;

		UNIT_TYPE _type = NO_TYPE;
		UNIT_CLAN _clan = NO_CLAN;
		UNIT_NATION _nation = NO_NATION;

		std::string _flavourTxt;
		std::string _effectDescript;

		int _id;
	};

}