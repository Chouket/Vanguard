﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CardStats
{
    [SerializeField] private string _name = "None";

    [SerializeField] private uint _grade;
    [SerializeField] private uint _atk;
    [SerializeField] private uint _def;
    [SerializeField] private uint _crit;
}


public class BaseCard : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        _nation = GetNationFromClan(_clan);

    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    #region Enum

    enum UNIT_TYPE
    {
        NO_TYPE = 0,
        NORMAL,
        TRIGGER,
        SENTINEL,
        G,
        G_GUARDIAN,

        TYPE_NB
    };

    enum UNIT_CLAN
    {
        NO_CLAN = 0,

        //United Sanctuary
        ROYAL_PALADIN,
        SHADOW_PALADIN,
        GOLD_PALADIN,
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
        NOVA_GRAPPLER,
        DIMENSION_POLICE,
        LINK_JOKER,
        ETRANGER,

        //Dark Zone
        PALE_MOON,
        DARK_IRREGULARS,
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
        NEUTRAL,
        //Touken Ranbu ? and Cray Elemental

        NATION_NB
    };

    #endregion

    //Function
    private UNIT_NATION GetNationFromClan(UNIT_CLAN clan)
    {
        if (clan <= UNIT_CLAN.NO_CLAN || clan >= UNIT_CLAN.CLAN_NB)
            return UNIT_NATION.NO_NATION;

        if (clan >= UNIT_CLAN.ROYAL_PALADIN && clan <= UNIT_CLAN.GENESIS)
            return UNIT_NATION.UNITED_SANCTUARY;

        if (clan >= UNIT_CLAN.KAGERO && clan <= UNIT_CLAN.MURAKUMO)
            return UNIT_NATION.DRAGON_EMPIRE;

        if (clan >= UNIT_CLAN.NOVA_GRAPPLER && clan <= UNIT_CLAN.ETRANGER)
            return UNIT_NATION.STAR_GATE;

        if (clan >= UNIT_CLAN.PALE_MOON && clan <= UNIT_CLAN.GEAR_CHRONICLE)
            return UNIT_NATION.DARK_ZONE;

        if (clan >= UNIT_CLAN.NEO_NECTAR && clan <= UNIT_CLAN.MEGA_COLONY)
            return UNIT_NATION.ZOO;

        if (clan >= UNIT_CLAN.GRANBLUE && clan <= UNIT_CLAN.AQUA_FORCE)
            return UNIT_NATION.MAGALLANICA;

        return UNIT_NATION.MAGALLANICA;
    }

    #region Getter/Setter



    #endregion
    
    //Variable

    [SerializeField] private CardStats _currentStats;
    private CardStats _buffedStats;

    //[SerializeField] private Texture _img;

    [SerializeField] private UNIT_TYPE _type;
    [SerializeField] private UNIT_CLAN _clan;
    private UNIT_NATION _nation;
  }

