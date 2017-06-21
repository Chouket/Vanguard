using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class CardStats
{
    public string _name = "None";

    public uint _grade;
    public uint _atk;

    //[ReadOnly] public enum Power -> Boost / Intercept / Double Drive 

    [ReadOnly] public uint _def;
    [ReadOnly] public uint _crit;
    [ReadOnly] public uint _drive;
}


public class BaseCard : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        Flip();
        _nation = GetNationFromClan(_clan);
        _currentStats._crit = 1;
        _currentStats._drive = GetDriveFromGrade(_currentStats._grade);
        _currentStats._def = GetDefenseFromGrade(_currentStats._grade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        if (_currentZone == BaseZone.ZONE.BIND || _currentZone == BaseZone.ZONE.DAMAGE ||
            _currentZone == BaseZone.ZONE.HAND || _currentZone == BaseZone.ZONE.REARGUARD ||
            _currentZone == BaseZone.ZONE.VANGUARD)
            GuiManager.Instance._cardInspectorUI.CardToDisplay(this);
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

    public void CardSelect()
    {

    }

    //public void Activate()
    //{

    //}


    //public void Show()
    //{

    //}

    public void Flip()
    {
        if (IsFlip)
            transform.Rotate(Vector3.up, 180.0f);
        else
            transform.Rotate(Vector3.up, 0f);
    }

    #region Getter/Setter

    public string GetName()
    {
        return _currentStats._name;
    }

    public void SetCurrentZone(BaseZone.ZONE zone)
    {
        _currentZone = zone;
    }

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
    private uint GetDriveFromGrade(uint grade)
    {
        if (grade == 4)
            return 3;
        if (grade == 3)
            return 2;

        return 1;
    }
    private uint GetDefenseFromGrade(uint grade)
    {
        //Check Trigger -> 5000 for draw trigger
        if (grade == 0)
            return 10000;
        if (grade == 1 || grade == 2)
            return 5000;
        if (grade >= 3)
            return 0;

        return 1;
    }
    #endregion

    void OnMouseDown()
    {
        Debug.Log("Click on card : " + name);
        if (_currentZone == BaseZone.ZONE.HAND)
            PlayerManager.Instance._player.Ride(this);
        else if (_currentZone == BaseZone.ZONE.DECK)
            PlayerManager.Instance._player.TakeDamage();
    }

    //Variable

    [SerializeField] private CardStats _currentStats;
    public CardStats CurrentStats { get { return _currentStats; } }
    private CardStats _buffedStats;
    public CardStats BuffedStats { get { return _buffedStats; } }

    [SerializeField] private UNIT_TYPE _type;
    [SerializeField] private UNIT_CLAN _clan;
    private UNIT_NATION _nation;
    private BaseZone.ZONE _currentZone;

    //Status
    private bool _isStand;
    public bool IsStand { get { return _isStand; } set { _isStand = value; } }
    private bool _isFlip = false;
    public bool IsFlip { get{return _isFlip;} set{_isFlip = value; Flip(); } }
    // bool etc...;
  }


