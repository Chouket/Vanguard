#include "stdafx.h"
#include "BaseCard.h"

namespace Vanguard
{
	//public 
	BaseCard::BaseCard(std::string name, unsigned int grade,
						unsigned int atk, unsigned int def,
						UNIT_TYPE type, UNIT_CLAN clan,
						std::string flavourTxt, std::string effectDesc)
	{
		_name = name;
		_grade = grade;
		_atk = atk;
		_def = def;
		_type = type;
		_clan = clan;
		_nation = GetNationFromClan(clan);
		_flavourTxt = flavourTxt;
		_effectDescript = effectDesc;
		_id = last_id;
		last_id++;
	}

	void BaseCard::Show()
	{
		//put into str
		std::cout << " ~~~~~~~~~~~~~~~~~~ " << std::endl;
		std::cout << " Name : " << _name.c_str() << "       id : " << _id << std::endl;
		std::cout << std::endl;
		std::cout << " -> Grade : " << _grade << std::endl;
		std::cout << " -> Attaque : " << _atk << std::endl;
		std::cout << " -> Defense : " << _def << std::endl;
		std::cout << std::endl;
		std::cout << " -> Type : " << GetTypeNameFromTypeEnum(_type).c_str() << std::endl;
		std::cout << " -> Clan : " << _clan << std::endl;
		std::cout << " -> Nation : " << GetNationNameFromNationEnum(_nation).c_str() << std::endl;
		std::cout << std::endl;
		std::cout << " -> Flavour Text : " << _flavourTxt.c_str() << std::endl;
		std::cout << " -> Effect Description : " << _effectDescript.c_str() << std::endl;
		std::cout << std::endl;
	}
	

	//private

	UNIT_NATION BaseCard::GetNationFromClan(UNIT_CLAN clan)
	{
		if (clan == ROYAL_PALADIN || clan == GOLD_PALADIN ||
			clan == SHADOW_PALADIN || clan == ORACLE_THINK_TANK ||
			clan == ANGEL_FEATHER || clan == GENESIS)
			return UNIT_NATION::UNITED_SANCTUARY;

		if (clan == KAGERO || clan == NARUKAMI ||
			clan == TACHIKAZE || clan == NUBATAMA ||
			clan == MURAKUMO)
			return UNIT_NATION::DRAGON_EMPIRE;

		if (clan == LINK_JOKER || clan == NOVA_GRAPPLER ||
			clan == DIMENSION_POLICE || clan == ETRANGER)
			return UNIT_NATION::STAR_GATE;

		if (clan == DARK_IRREGULARS || clan == PALE_MOON ||
			clan == SPIKE_BROTHERS || clan == GEAR_CHRONICLE)
			return UNIT_NATION::DARK_ZONE;

		if (clan == NEO_NECTAR || clan == GREAT_NATURE ||
			clan == MEGA_COLONY)
			return UNIT_NATION::ZOO;

		if (clan == GRANBLUE || clan == BERMUDA_TRIANGLE ||
			clan == AQUA_FORCE)
			return UNIT_NATION::MAGALLANICA;
	}

	std::string BaseCard::GetTypeNameFromTypeEnum(UNIT_TYPE type)
	{
		if (type == NO_TYPE || type == TYPE_NB)
			return "NONE";
		
		if (type == NORMAL || type == SENTINEL)
			return "Normal Unit";

		if (type == TRIGGER)
			return "Trigger Unit";

		if (type == G)
			return "G Unit";

		else
			return "ERROR";
	}

	std::string BaseCard::GetClanNameFromClanEnum(UNIT_CLAN clan)
	{
		return "";
	}

	std::string BaseCard::GetNationNameFromNationEnum(UNIT_NATION nation)
	{
		if (nation == NO_NATION || nation == NATION_NB)
			return "NONE";

		if (nation == UNITED_SANCTUARY)
			return "United Sanctuary";

		if (nation == DRAGON_EMPIRE)
			return "Dragon Empire";

		if (nation == STAR_GATE)
			return "Star Gate";

		if (nation == DARK_ZONE)
			return "Dark Zone";

		if (nation == ZOO)
			return "Zoo";

		if (nation == MAGALLANICA)
			return "Magallanica";

		else
			return "ERROR";
	}

}