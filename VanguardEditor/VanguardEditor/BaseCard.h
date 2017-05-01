#pragma once

#include <string>

namespace Vanguard
{

#pragma region CardEnum

	enum UNIT_TYPE
	{
		NONE = 0,
		NORMAL_UNIT,
		TRIGGER_UNIT,
		G_UNIT,

		TYPE_NB
	};

	enum UNIT_CLAN
	{
		NONE = 0,

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

		//Magallanica
		GRANBLUE,
		BERMUDA_TRIANGLE,
		AQUA_FORCE,

		CLAN_NB

	};

	enum UNIT_NATION
	{
		NONE = 0,
		UNITED_SANCTUARY, 
		// X Paladin, Oracle Think Tank, Angel Feather, Genesis
		DRAGON_EMPIRE,
		// Kagero, Narukami, Tachikaze, Nubatama, Murakumo
		STAR_GATE,
		// Link Joker, Nova Grappler, Dimension Police, Etranger
		DARK_ZONE,
		// Dark Irregulars, Pale Moon, Spike Brothers, Gear Chronicle
		MAGALLANICA,
		// Granblue, Bermuda Triangle, Aqua Force

		NATION_NB
	};

#pragma endregion

	class BaseCard abstract
	{
		std::string _name;

		int _grade;
		int _atk;
		int _def;

		UNIT_TYPE _type;
		UNIT_CLAN _clan;
		UNIT_NATION _nation;

		std::string _flavourText;
		std::string _effectDescript;
	};

}