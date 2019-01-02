using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour {

    PlayerData pData;

    string dataFilePath;

    public static bool saveData;
    public static float saveTimer;
    
    public const int numOres = 19;
    public const int numMetals = 45;
    public const int numGems = 30;
    public const int numPotions = 31;
    public const int numMagicSpells = 7;
    public const int numHerbs = 30;
    public const int numFruits = 6;
    public const int numMobs = 22;
    public const int numBosses = 22;

    #region To view data in runtime only
    public double Coins;
    public double PlayerHP;

    //Level and Wave
    public int Level;
    public int Wave;

    //Armour and Weapon
    public int ArmourTier;
    public int WeaponTier;

    //Metals and Alloys
    public double CopperOre;
    public double TinOre;
    public double IronOre;
    public double CoalOre;
    public double AluminiumOre;
    public double NickelOre;
    public double MagnesiumOre;
    public double ZincOre;
    public double LeadOre;
    public double SilverOre;
    public double GoldOre;
    public double PlatinumOre;
    public double ObsidianOre;
    public double MeteoriteOre;
    public double MithrilOre;
    public double AdamanteusOre;
    public double QuicksilverOre;
    public double AetherOre;
    public double CrimsoniteOre;
    public double Copper;
    public double Tin;
    public double Bronze;
    public double Iron;
    public double Steel;
    public double Aluminium;
    public double Duralumin;
    public double Nickel;
    public double Invar;
    public double Magnesium;
    public double Hydronalium;
    public double Zinc;
    public double Brass;
    public double Zamakium;
    public double Lead;
    public double WhiteMetal;
    public double DamascusSteel;
    public double Silver;
    public double Gold;
    public double RoseGold;
    public double Elinvar;
    public double Electrum;
    public double CorinthianBronze;
    public double Platinum;
    public double RefinedObsidian;
    public double Darksteel;
    public double RefinedMeteorite;
    public double MeteoricIron;
    public double Shadowsteel;
    public double MeteoricSteel;
    public double Mithril;
    public double MysticalSteel;
    public double Adamanteus;
    public double DivineSteel;
    public double Quicksilver;
    public double CelestialSteel;
    public double Luminium;
    public double Aether;
    public double Etherium;
    public double CosmicSteel;
    public double Crimsonite;
    public double SoulSteel;
    public double Neutronium;
    public double Orichalcum;
    public double Infinitium;

    //Gems
    public double Amber;
    public double Quartz;
    public double Opal;
    public double Jade;
    public double Cinnabar;
    public double Ametrine;
    public double SmokyQuartz;
    public double Garnet;
    public double Onyx;
    public double Pyrite;
    public double Heliodor;
    public double Citrine;
    public double RoseQuartz;
    public double LapisLazuli;
    public double Aquamarine;
    public double Peridot;
    public double Turquoise;
    public double IcyQuartz;
    public double Coralite;
    public double Amethyst;
    public double Prismarium;
    public double Topaz;
    public double Ruby;
    public double Moonstone;
    public double Sapphire;
    public double Sunstone;
    public double Emerald;
    public double Bloodstone;
    public double StarCrystal;
    public double Diamond;

    //Potions
    public double LuckPotion1;
    public double LuckPotion2;
    public double LuckPotion3;
    public double LuckPotion4;
    public double LuckPotion5;
    public double LuckPotion6;
    public double DefencePotion1;
    public double DefencePotion2;
    public double DefencePotion3;
    public double DefencePotion4;
    public double DefencePotion5;
    public double DefencePotion6;
    public double HealthPotion1;
    public double HealthPotion2;
    public double HealthPotion3;
    public double HealthPotion4;
    public double HealthPotion5;
    public double HealthPotion6;
    public double AttackPotion1;
    public double AttackPotion2;
    public double AttackPotion3;
    public double AttackPotion4;
    public double AttackPotion5;
    public double AttackPotion6;
    public double MagicPotion1;
    public double MagicPotion2;
    public double MagicPotion3;
    public double MagicPotion4;
    public double MagicPotion5;
    public double MagicPotion6;
    public double MarvelousPotion;

    //Herbs
    public double Clover;
    public double DaisyPetal;
    public double Holly;
    public double RoseThorn;
    public double IvySprig;
    public double Windrush;
    public double WillowTwig;
    public double Goosegrass;
    public double Firegrass;
    public double Moly;
    public double Starthistle;
    public double Knotweed;
    public double Bitterroot;
    public double Baneberry;
    public double MandrakeRoot;
    public double TawnymothWeed;
    public double Spleenwort;
    public double HelleboreSyrup;
    public double ValerianRoot;
    public double DragonIvy;
    public double Asphodel;
    public double Wormwood;
    public double Silverweed;
    public double Wolfsbane;
    public double Moondew;
    public double Fluxweed;
    public double Tormentil;
    public double Belladonna;
    public double Nightshade;
    public double Bloodroot;

    //Fruits
    public double RubyApple;
    public double BloodOrange;
    public double CinderBanana;
    public double DewLemon;
    public double GoldenMango;
    public double WildNectarine;

    //Spells
    public double LightningSpell;
    public double WaterSpell;
    public double FireSpell;
    public double WindSpell;
    public double IceSpell;
    public double EarthSpell;
    public double SummoningSpell;
    #endregion

    private void Awake()
    {
        pData = GetComponent<PlayerData>();
        dataFilePath = GetApplicationPath() + "data.json";
        if (!File.Exists(dataFilePath))
        {
            TextAsset tempData = (TextAsset)Resources.Load("defaultData", typeof(TextAsset));
            var writer = new StreamWriter(dataFilePath);
            writer.Write(tempData.text);
            writer.Flush();
            writer.Close();
        }
        if (SceneManager.GetActiveScene().name == "Main")
        {
            LoadGameData();
        }
    }

    private void Update()
    {
        saveTimer += Time.deltaTime;
        if (saveTimer >= 0.5f)
        {
            saveTimer = 0;
            SaveGameData();
        }
        if (saveData)
        {
            saveData = false;
            SaveGameData();
        }

        #region To view data in runtime only

        Coins = PlayerData.coins;
        PlayerHP = PlayerData.playerHealth;
        Level = LevelScript.level;
        Wave = LevelScript.wave;
        ArmourTier = PlayerData.armourTier;
        WeaponTier = PlayerData.weaponTier;
        CopperOre = pData.ores[0].amount;
        TinOre = pData.ores[1].amount;
        IronOre = pData.ores[2].amount;
        CoalOre = pData.ores[3].amount;
        AluminiumOre = pData.ores[4].amount;
        NickelOre = pData.ores[5].amount;
        MagnesiumOre = pData.ores[6].amount;
        ZincOre = pData.ores[7].amount;
        LeadOre = pData.ores[8].amount;
        SilverOre = pData.ores[9].amount;
        GoldOre = pData.ores[10].amount;
        PlatinumOre = pData.ores[11].amount;
        ObsidianOre = pData.ores[12].amount;
        MeteoriteOre = pData.ores[13].amount;
        MithrilOre = pData.ores[14].amount;
        AdamanteusOre = pData.ores[15].amount;
        QuicksilverOre = pData.ores[16].amount;
        AetherOre = pData.ores[17].amount;
        CrimsoniteOre = pData.ores[18].amount;
        Copper = pData.metals[0].amount;
        Tin = pData.metals[1].amount;
        Bronze = pData.metals[2].amount;
        Iron = pData.metals[3].amount;
        Steel = pData.metals[4].amount;
        Aluminium = pData.metals[5].amount;
        Duralumin = pData.metals[6].amount;
        Nickel = pData.metals[7].amount;
        Invar = pData.metals[8].amount;
        Magnesium = pData.metals[9].amount;
        Hydronalium = pData.metals[10].amount;
        Zinc = pData.metals[11].amount;
        Brass = pData.metals[12].amount;
        Zamakium = pData.metals[13].amount;
        Lead = pData.metals[14].amount;
        WhiteMetal = pData.metals[15].amount;
        DamascusSteel = pData.metals[16].amount;
        Silver = pData.metals[17].amount;
        Gold = pData.metals[18].amount;
        RoseGold = pData.metals[19].amount;
        Elinvar = pData.metals[20].amount;
        Electrum = pData.metals[21].amount;
        CorinthianBronze = pData.metals[22].amount;
        Platinum = pData.metals[23].amount;
        RefinedObsidian = pData.metals[24].amount;
        Darksteel = pData.metals[25].amount;
        RefinedMeteorite = pData.metals[26].amount;
        MeteoricIron = pData.metals[27].amount;
        Shadowsteel = pData.metals[28].amount;
        MeteoricSteel = pData.metals[29].amount;
        Mithril = pData.metals[30].amount;
        MysticalSteel = pData.metals[31].amount;
        Adamanteus = pData.metals[32].amount;
        DivineSteel = pData.metals[33].amount;
        Quicksilver = pData.metals[34].amount;
        CelestialSteel = pData.metals[35].amount;
        Luminium = pData.metals[36].amount;
        Aether = pData.metals[37].amount;
        Etherium = pData.metals[38].amount;
        CosmicSteel = pData.metals[39].amount;
        Crimsonite = pData.metals[40].amount;
        SoulSteel = pData.metals[41].amount;
        Neutronium = pData.metals[42].amount;
        Orichalcum = pData.metals[43].amount;
        Infinitium = pData.metals[44].amount;
        Amber = pData.gems[0].amount;
        Quartz = pData.gems[1].amount;
        Opal = pData.gems[2].amount;
        Jade = pData.gems[3].amount;
        Cinnabar = pData.gems[4].amount;
        Ametrine = pData.gems[5].amount;
        SmokyQuartz = pData.gems[6].amount;
        Garnet = pData.gems[7].amount;
        Onyx = pData.gems[8].amount;
        Pyrite = pData.gems[9].amount;
        Heliodor = pData.gems[10].amount;
        Citrine = pData.gems[11].amount;
        RoseQuartz = pData.gems[12].amount;
        LapisLazuli = pData.gems[13].amount;
        Aquamarine = pData.gems[14].amount;
        Peridot = pData.gems[15].amount;
        Turquoise = pData.gems[16].amount;
        IcyQuartz = pData.gems[17].amount;
        Coralite = pData.gems[18].amount;
        Amethyst = pData.gems[19].amount;
        Prismarium = pData.gems[20].amount;
        Topaz = pData.gems[21].amount;
        Ruby = pData.gems[22].amount;
        Moonstone = pData.gems[23].amount;
        Sapphire = pData.gems[24].amount;
        Sunstone = pData.gems[25].amount;
        Emerald = pData.gems[26].amount;
        Bloodstone = pData.gems[27].amount;
        StarCrystal = pData.gems[28].amount;
        Diamond = pData.gems[29].amount;
        LuckPotion1 = pData.potions[0].amount;
        LuckPotion2 = pData.potions[5].amount;
        LuckPotion3 = pData.potions[10].amount;
        LuckPotion4 = pData.potions[15].amount;
        LuckPotion5 = pData.potions[20].amount;
        LuckPotion6 = pData.potions[25].amount;
        DefencePotion1 = pData.potions[1].amount;
        DefencePotion2 = pData.potions[6].amount;
        DefencePotion3 = pData.potions[11].amount;
        DefencePotion4 = pData.potions[16].amount;
        DefencePotion5 = pData.potions[21].amount;
        DefencePotion6 = pData.potions[26].amount;
        HealthPotion1 = pData.potions[2].amount;
        HealthPotion2 = pData.potions[7].amount;
        HealthPotion3 = pData.potions[12].amount;
        HealthPotion4 = pData.potions[17].amount;
        HealthPotion5 = pData.potions[22].amount;
        HealthPotion6 = pData.potions[27].amount;
        AttackPotion1 = pData.potions[3].amount;
        AttackPotion2 = pData.potions[8].amount;
        AttackPotion3 = pData.potions[13].amount;
        AttackPotion4 = pData.potions[18].amount;
        AttackPotion5 = pData.potions[23].amount;
        AttackPotion6 = pData.potions[28].amount;
        MagicPotion1 = pData.potions[4].amount;
        MagicPotion2 = pData.potions[9].amount;
        MagicPotion3 = pData.potions[14].amount;
        MagicPotion4 = pData.potions[19].amount;
        MagicPotion5 = pData.potions[24].amount;
        MagicPotion6 = pData.potions[29].amount;
        MarvelousPotion = pData.potions[30].amount;
        Clover = pData.herbs[0].amount;
        DaisyPetal = pData.herbs[1].amount;
        Holly = pData.herbs[2].amount;
        RoseThorn = pData.herbs[3].amount;
        IvySprig = pData.herbs[4].amount;
        Windrush = pData.herbs[5].amount;
        WillowTwig = pData.herbs[6].amount;
        Goosegrass = pData.herbs[7].amount;
        Firegrass = pData.herbs[8].amount;
        Moly = pData.herbs[9].amount;
        Starthistle = pData.herbs[10].amount;
        Knotweed = pData.herbs[11].amount;
        Bitterroot = pData.herbs[12].amount;
        Baneberry = pData.herbs[13].amount;
        MandrakeRoot = pData.herbs[14].amount;
        TawnymothWeed = pData.herbs[15].amount;
        Spleenwort = pData.herbs[16].amount;
        HelleboreSyrup = pData.herbs[17].amount;
        ValerianRoot = pData.herbs[18].amount;
        DragonIvy = pData.herbs[19].amount;
        Asphodel = pData.herbs[20].amount;
        Wormwood = pData.herbs[21].amount;
        Silverweed = pData.herbs[22].amount;
        Wolfsbane = pData.herbs[23].amount;
        Moondew = pData.herbs[24].amount;
        Fluxweed = pData.herbs[25].amount;
        Tormentil = pData.herbs[26].amount;
        Belladonna = pData.herbs[27].amount;
        Nightshade = pData.herbs[28].amount;
        Bloodroot = pData.herbs[29].amount;
        RubyApple = pData.fruits[0].amount;
        BloodOrange = pData.fruits[1].amount;
        CinderBanana = pData.fruits[2].amount;
        DewLemon = pData.fruits[3].amount;
        GoldenMango = pData.fruits[4].amount;
        WildNectarine = pData.fruits[5].amount;
        LightningSpell = pData.magicSpells[0].amount;
        WaterSpell = pData.magicSpells[1].amount;
        FireSpell = pData.magicSpells[2].amount;
        WindSpell = pData.magicSpells[3].amount;
        IceSpell = pData.magicSpells[4].amount;
        EarthSpell = pData.magicSpells[5].amount;
        SummoningSpell = pData.magicSpells[6].amount;
        #endregion
    }

    public void LoadGameData()
    {
        if (File.Exists(dataFilePath))
        {
            string data = File.ReadAllText(dataFilePath);
            PlayerDataJSON loadedData = JsonUtility.FromJson<PlayerDataJSON>(data);
            PlayerData.coins = loadedData.Coins;
            PlayerData.weaponTier = loadedData.WeaponTier;
            pData.ores[0].amount = loadedData.CopperOre;
            pData.ores[1].amount = loadedData.TinOre;
            pData.ores[2].amount = loadedData.IronOre;
            pData.ores[3].amount = loadedData.CoalOre;
            pData.ores[4].amount = loadedData.AluminiumOre;
            pData.ores[5].amount = loadedData.NickelOre;
            pData.ores[6].amount = loadedData.MagnesiumOre;
            pData.ores[7].amount = loadedData.ZincOre;
            pData.ores[8].amount = loadedData.LeadOre;
            pData.ores[9].amount = loadedData.SilverOre;
            pData.ores[10].amount = loadedData.GoldOre;
            pData.ores[11].amount = loadedData.PlatinumOre;
            pData.ores[12].amount = loadedData.ObsidianOre;
            pData.ores[13].amount = loadedData.MeteoriteOre;
            pData.ores[14].amount = loadedData.MithrilOre;
            pData.ores[15].amount = loadedData.AdamanteusOre;
            pData.ores[16].amount = loadedData.QuicksilverOre;
            pData.ores[17].amount = loadedData.AetherOre;
            pData.ores[18].amount = loadedData.CrimsoniteOre;
            pData.metals[0].amount = loadedData.Copper;
            pData.metals[1].amount = loadedData.Tin;
            pData.metals[2].amount = loadedData.Bronze;
            pData.metals[3].amount = loadedData.Iron;
            pData.metals[4].amount = loadedData.Steel;
            pData.metals[5].amount = loadedData.Aluminium;
            pData.metals[6].amount = loadedData.Duralumin;
            pData.metals[7].amount = loadedData.Nickel;
            pData.metals[8].amount = loadedData.Invar;
            pData.metals[9].amount = loadedData.Magnesium;
            pData.metals[10].amount = loadedData.Hydronalium;
            pData.metals[11].amount = loadedData.Zinc;
            pData.metals[12].amount = loadedData.Brass;
            pData.metals[13].amount = loadedData.Zamakium;
            pData.metals[14].amount = loadedData.Lead;
            pData.metals[15].amount = loadedData.WhiteMetal;
            pData.metals[16].amount = loadedData.DamascusSteel;
            pData.metals[17].amount = loadedData.Silver;
            pData.metals[18].amount = loadedData.Gold;
            pData.metals[19].amount = loadedData.RoseGold;
            pData.metals[20].amount = loadedData.Elinvar;
            pData.metals[21].amount = loadedData.Electrum;
            pData.metals[22].amount = loadedData.CorinthianBronze;
            pData.metals[23].amount = loadedData.Platinum;
            pData.metals[24].amount = loadedData.RefinedObsidian;
            pData.metals[25].amount = loadedData.Darksteel;
            pData.metals[26].amount = loadedData.RefinedMeteorite;
            pData.metals[27].amount = loadedData.MeteoricIron;
            pData.metals[28].amount = loadedData.Shadowsteel;
            pData.metals[29].amount = loadedData.MeteoricSteel;
            pData.metals[30].amount = loadedData.Mithril;
            pData.metals[31].amount = loadedData.MysticalSteel;
            pData.metals[32].amount = loadedData.Adamanteus;
            pData.metals[33].amount = loadedData.DivineSteel;
            pData.metals[34].amount = loadedData.Quicksilver;
            pData.metals[35].amount = loadedData.CelestialSteel;
            pData.metals[36].amount = loadedData.Luminium;
            pData.metals[37].amount = loadedData.Aether;
            pData.metals[38].amount = loadedData.Etherium;
            pData.metals[39].amount = loadedData.CosmicSteel;
            pData.metals[40].amount = loadedData.Crimsonite;
            pData.metals[41].amount = loadedData.SoulSteel;
            pData.metals[42].amount = loadedData.Neutronium;
            pData.metals[43].amount = loadedData.Orichalcum;
            pData.metals[44].amount = loadedData.Infinitium;
            pData.gems[0].amount = loadedData.Amber;
            pData.gems[1].amount = loadedData.Quartz;
            pData.gems[2].amount = loadedData.Opal;
            pData.gems[3].amount = loadedData.Jade;
            pData.gems[4].amount = loadedData.Cinnabar;
            pData.gems[5].amount = loadedData.Ametrine;
            pData.gems[6].amount = loadedData.SmokyQuartz;
            pData.gems[7].amount = loadedData.Garnet;
            pData.gems[8].amount = loadedData.Onyx;
            pData.gems[9].amount = loadedData.Pyrite;
            pData.gems[10].amount = loadedData.Heliodor;
            pData.gems[11].amount = loadedData.Citrine;
            pData.gems[12].amount = loadedData.RoseQuartz;
            pData.gems[13].amount = loadedData.LapisLazuli;
            pData.gems[14].amount = loadedData.Aquamarine;
            pData.gems[15].amount = loadedData.Peridot;
            pData.gems[16].amount = loadedData.Turquoise;
            pData.gems[17].amount = loadedData.IcyQuartz;
            pData.gems[18].amount = loadedData.Coralite;
            pData.gems[19].amount = loadedData.Amethyst;
            pData.gems[20].amount = loadedData.Prismarium;
            pData.gems[21].amount = loadedData.Topaz;
            pData.gems[22].amount = loadedData.Ruby;
            pData.gems[23].amount = loadedData.Moonstone;
            pData.gems[24].amount = loadedData.Sapphire;
            pData.gems[25].amount = loadedData.Sunstone;
            pData.gems[26].amount = loadedData.Emerald;
            pData.gems[27].amount = loadedData.Bloodstone;
            pData.gems[28].amount = loadedData.StarCrystal;
            pData.gems[29].amount = loadedData.Diamond;
            pData.potions[0].amount = loadedData.LuckPotion1;
            pData.potions[5].amount = loadedData.LuckPotion2;
            pData.potions[10].amount = loadedData.LuckPotion3;
            pData.potions[15].amount = loadedData.LuckPotion4;
            pData.potions[20].amount = loadedData.LuckPotion5;
            pData.potions[25].amount = loadedData.LuckPotion6;
            pData.potions[1].amount = loadedData.DefencePotion1;
            pData.potions[6].amount = loadedData.DefencePotion2;
            pData.potions[11].amount = loadedData.DefencePotion3;
            pData.potions[16].amount = loadedData.DefencePotion4;
            pData.potions[21].amount = loadedData.DefencePotion5;
            pData.potions[26].amount = loadedData.DefencePotion6;
            pData.potions[2].amount = loadedData.HealthPotion1;
            pData.potions[7].amount = loadedData.HealthPotion2;
            pData.potions[12].amount = loadedData.HealthPotion3;
            pData.potions[17].amount = loadedData.HealthPotion4;
            pData.potions[22].amount = loadedData.HealthPotion5;
            pData.potions[27].amount = loadedData.HealthPotion6;
            pData.potions[3].amount = loadedData.AttackPotion1;
            pData.potions[8].amount = loadedData.AttackPotion2;
            pData.potions[13].amount = loadedData.AttackPotion3;
            pData.potions[18].amount = loadedData.AttackPotion4;
            pData.potions[23].amount = loadedData.AttackPotion5;
            pData.potions[28].amount = loadedData.AttackPotion6;
            pData.potions[4].amount = loadedData.MagicPotion1;
            pData.potions[9].amount = loadedData.MagicPotion2;
            pData.potions[14].amount = loadedData.MagicPotion3;
            pData.potions[19].amount = loadedData.MagicPotion4;
            pData.potions[24].amount = loadedData.MagicPotion5;
            pData.potions[29].amount = loadedData.MagicPotion6;
            pData.potions[30].amount = loadedData.MarvelousPotion;
            pData.herbs[0].amount = loadedData.Clover;
            pData.herbs[1].amount = loadedData.DaisyPetal;
            pData.herbs[2].amount = loadedData.Holly;
            pData.herbs[3].amount = loadedData.RoseThorn;
            pData.herbs[4].amount = loadedData.IvySprig;
            pData.herbs[5].amount = loadedData.Windrush;
            pData.herbs[6].amount = loadedData.WillowTwig;
            pData.herbs[7].amount = loadedData.Goosegrass;
            pData.herbs[8].amount = loadedData.Firegrass;
            pData.herbs[9].amount = loadedData.Moly;
            pData.herbs[10].amount = loadedData.Starthistle;
            pData.herbs[11].amount = loadedData.Knotweed;
            pData.herbs[12].amount = loadedData.Bitterroot;
            pData.herbs[13].amount = loadedData.Baneberry;
            pData.herbs[14].amount = loadedData.MandrakeRoot;
            pData.herbs[15].amount = loadedData.TawnymothWeed;
            pData.herbs[16].amount = loadedData.Spleenwort;
            pData.herbs[17].amount = loadedData.HelleboreSyrup;
            pData.herbs[18].amount = loadedData.ValerianRoot;
            pData.herbs[19].amount = loadedData.DragonIvy;
            pData.herbs[20].amount = loadedData.Asphodel;
            pData.herbs[21].amount = loadedData.Wormwood;
            pData.herbs[22].amount = loadedData.Silverweed;
            pData.herbs[23].amount = loadedData.Wolfsbane;
            pData.herbs[24].amount = loadedData.Moondew;
            pData.herbs[25].amount = loadedData.Fluxweed;
            pData.herbs[26].amount = loadedData.Tormentil;
            pData.herbs[27].amount = loadedData.Belladonna;
            pData.herbs[28].amount = loadedData.Nightshade;
            pData.herbs[29].amount = loadedData.Bloodroot;
            pData.fruits[0].amount = loadedData.RubyApple;
            pData.fruits[1].amount = loadedData.BloodOrange;
            pData.fruits[2].amount = loadedData.CinderBanana;
            pData.fruits[3].amount = loadedData.DewLemon;
            pData.fruits[4].amount = loadedData.GoldenMango;
            pData.fruits[5].amount = loadedData.WildNectarine;
            pData.magicSpells[0].amount = loadedData.LightningSpell;
            pData.magicSpells[1].amount = loadedData.WaterSpell;
            pData.magicSpells[2].amount = loadedData.FireSpell;
            pData.magicSpells[3].amount = loadedData.WindSpell;
            pData.magicSpells[4].amount = loadedData.IceSpell;
            pData.magicSpells[5].amount = loadedData.EarthSpell;
            pData.magicSpells[6].amount = loadedData.SummoningSpell;
        }
    }

    public void SaveGameData()
    {
        if(PlayerData.playerHealth < 0)
        {
            PlayerData.playerHealth = 0;
        }
        PlayerDataJSON playerDataJSON = new PlayerDataJSON()
        {
            Coins = PlayerData.coins,
            PlayerHP = PlayerData.playerHealth,
            Level = LevelScript.level,
            Wave = LevelScript.wave,
            DayOfYear = DateTime.Now.DayOfYear,
            Hour = DateTime.Now.Hour,
            ArmourTier = PlayerData.armourTier,
            WeaponTier = PlayerData.weaponTier,
            CopperOre = pData.ores[0].amount,
            TinOre = pData.ores[1].amount,
            IronOre = pData.ores[2].amount,
            CoalOre = pData.ores[3].amount,
            AluminiumOre = pData.ores[4].amount,
            NickelOre = pData.ores[5].amount,
            MagnesiumOre = pData.ores[6].amount,
            ZincOre = pData.ores[7].amount,
            LeadOre = pData.ores[8].amount,
            SilverOre = pData.ores[9].amount,
            GoldOre = pData.ores[10].amount,
            PlatinumOre = pData.ores[11].amount,
            ObsidianOre = pData.ores[12].amount,
            MeteoriteOre = pData.ores[13].amount,
            MithrilOre = pData.ores[14].amount,
            AdamanteusOre = pData.ores[15].amount,
            QuicksilverOre = pData.ores[16].amount,
            AetherOre = pData.ores[17].amount,
            CrimsoniteOre = pData.ores[18].amount,
            Copper = pData.metals[0].amount,
            Tin = pData.metals[1].amount,
            Bronze = pData.metals[2].amount,
            Iron = pData.metals[3].amount,
            Steel = pData.metals[4].amount,
            Aluminium = pData.metals[5].amount,
            Duralumin = pData.metals[6].amount,
            Nickel = pData.metals[7].amount,
            Invar = pData.metals[8].amount,
            Magnesium = pData.metals[9].amount,
            Hydronalium = pData.metals[10].amount,
            Zinc = pData.metals[11].amount,
            Brass = pData.metals[12].amount,
            Zamakium = pData.metals[13].amount,
            Lead = pData.metals[14].amount,
            WhiteMetal = pData.metals[15].amount,
            DamascusSteel = pData.metals[16].amount,
            Silver = pData.metals[17].amount,
            Gold = pData.metals[18].amount,
            RoseGold = pData.metals[19].amount,
            Elinvar = pData.metals[20].amount,
            Electrum = pData.metals[21].amount,
            CorinthianBronze = pData.metals[22].amount,
            Platinum = pData.metals[23].amount,
            RefinedObsidian = pData.metals[24].amount,
            Darksteel = pData.metals[25].amount,
            RefinedMeteorite = pData.metals[26].amount,
            MeteoricIron = pData.metals[27].amount,
            Shadowsteel = pData.metals[28].amount,
            MeteoricSteel = pData.metals[29].amount,
            Mithril = pData.metals[30].amount,
            MysticalSteel = pData.metals[31].amount,
            Adamanteus = pData.metals[32].amount,
            DivineSteel = pData.metals[33].amount,
            Quicksilver = pData.metals[34].amount,
            CelestialSteel = pData.metals[35].amount,
            Luminium = pData.metals[36].amount,
            Aether = pData.metals[37].amount,
            Etherium = pData.metals[38].amount,
            CosmicSteel = pData.metals[39].amount,
            Crimsonite = pData.metals[40].amount,
            SoulSteel = pData.metals[41].amount,
            Neutronium = pData.metals[42].amount,
            Orichalcum = pData.metals[43].amount,
            Infinitium = pData.metals[44].amount,
            Amber = pData.gems[0].amount,
            Quartz = pData.gems[1].amount,
            Opal = pData.gems[2].amount,
            Jade = pData.gems[3].amount,
            Cinnabar = pData.gems[4].amount,
            Ametrine = pData.gems[5].amount,
            SmokyQuartz = pData.gems[6].amount,
            Garnet = pData.gems[7].amount,
            Onyx = pData.gems[8].amount,
            Pyrite = pData.gems[9].amount,
            Heliodor = pData.gems[10].amount,
            Citrine = pData.gems[11].amount,
            RoseQuartz = pData.gems[12].amount,
            LapisLazuli = pData.gems[13].amount,
            Aquamarine = pData.gems[14].amount,
            Peridot = pData.gems[15].amount,
            Turquoise = pData.gems[16].amount,
            IcyQuartz = pData.gems[17].amount,
            Coralite = pData.gems[18].amount,
            Amethyst = pData.gems[19].amount,
            Prismarium = pData.gems[20].amount,
            Topaz = pData.gems[21].amount,
            Ruby = pData.gems[22].amount,
            Moonstone = pData.gems[23].amount,
            Sapphire = pData.gems[24].amount,
            Sunstone = pData.gems[25].amount,
            Emerald = pData.gems[26].amount,
            Bloodstone = pData.gems[27].amount,
            StarCrystal = pData.gems[28].amount,
            Diamond = pData.gems[29].amount,
            LuckPotion1 = pData.potions[0].amount,
            LuckPotion2 = pData.potions[5].amount,
            LuckPotion3 = pData.potions[10].amount,
            LuckPotion4 = pData.potions[15].amount,
            LuckPotion5 = pData.potions[20].amount,
            LuckPotion6 = pData.potions[25].amount,
            DefencePotion1 = pData.potions[1].amount,
            DefencePotion2 = pData.potions[6].amount,
            DefencePotion3 = pData.potions[11].amount,
            DefencePotion4 = pData.potions[16].amount,
            DefencePotion5 = pData.potions[21].amount,
            DefencePotion6 = pData.potions[26].amount,
            HealthPotion1 = pData.potions[2].amount,
            HealthPotion2 = pData.potions[7].amount,
            HealthPotion3 = pData.potions[12].amount,
            HealthPotion4 = pData.potions[17].amount,
            HealthPotion5 = pData.potions[22].amount,
            HealthPotion6 = pData.potions[27].amount,
            AttackPotion1 = pData.potions[3].amount,
            AttackPotion2 = pData.potions[8].amount,
            AttackPotion3 = pData.potions[13].amount,
            AttackPotion4 = pData.potions[18].amount,
            AttackPotion5 = pData.potions[23].amount,
            AttackPotion6 = pData.potions[28].amount,
            MagicPotion1 = pData.potions[4].amount,
            MagicPotion2 = pData.potions[9].amount,
            MagicPotion3 = pData.potions[14].amount,
            MagicPotion4 = pData.potions[19].amount,
            MagicPotion5 = pData.potions[24].amount,
            MagicPotion6 = pData.potions[29].amount,
            MarvelousPotion = pData.potions[30].amount,
            Clover = pData.herbs[0].amount,
            DaisyPetal = pData.herbs[1].amount,
            Holly = pData.herbs[2].amount,
            RoseThorn = pData.herbs[3].amount,
            IvySprig = pData.herbs[4].amount,
            Windrush = pData.herbs[5].amount,
            WillowTwig = pData.herbs[6].amount,
            Goosegrass = pData.herbs[7].amount,
            Firegrass = pData.herbs[8].amount,
            Moly = pData.herbs[9].amount,
            Starthistle = pData.herbs[10].amount,
            Knotweed = pData.herbs[11].amount,
            Bitterroot = pData.herbs[12].amount,
            Baneberry = pData.herbs[13].amount,
            MandrakeRoot = pData.herbs[14].amount,
            TawnymothWeed = pData.herbs[15].amount,
            Spleenwort = pData.herbs[16].amount,
            HelleboreSyrup = pData.herbs[17].amount,
            ValerianRoot = pData.herbs[18].amount,
            DragonIvy = pData.herbs[19].amount,
            Asphodel = pData.herbs[20].amount,
            Wormwood = pData.herbs[21].amount,
            Silverweed = pData.herbs[22].amount,
            Wolfsbane = pData.herbs[23].amount,
            Moondew = pData.herbs[24].amount,
            Fluxweed = pData.herbs[25].amount,
            Tormentil = pData.herbs[26].amount,
            Belladonna = pData.herbs[27].amount,
            Nightshade = pData.herbs[28].amount,
            Bloodroot = pData.herbs[29].amount,
            RubyApple = pData.fruits[0].amount,
            BloodOrange = pData.fruits[1].amount,
            CinderBanana = pData.fruits[2].amount,
            DewLemon = pData.fruits[3].amount,
            GoldenMango = pData.fruits[4].amount,
            WildNectarine = pData.fruits[5].amount,
            LightningSpell = pData.magicSpells[0].amount,
            WaterSpell = pData.magicSpells[1].amount,
            FireSpell = pData.magicSpells[2].amount,
            WindSpell = pData.magicSpells[3].amount,
            IceSpell = pData.magicSpells[4].amount,
            EarthSpell = pData.magicSpells[5].amount,
            SummoningSpell = pData.magicSpells[6].amount,
        };
        string dataJSON = JsonUtility.ToJson(playerDataJSON);
        File.WriteAllText(dataFilePath, dataJSON);
        //Debug.Log("Data Written");
    }

    public void ResetData()
    {
        PlayerData.coins = 0;
        PlayerData.playerHealth = 96;
        PlayerData.armourTier = 0;
        PlayerData.weaponTier = 0;
        for (int i = 0; i < numOres; i++)
        {
            pData.ores[i].amount = 0;
        }
        for (int i = 0; i < numMetals; i++)
        {
            pData.metals[i].amount = 0;
        }
        for (int i = 0; i < numGems; i++)
        {
            pData.gems[i].amount = 0;
        }
        for (int i = 0; i < numPotions; i++)
        {
            pData.potions[i].amount = 0;
        }
        for (int i = 0; i < numHerbs; i++)
        {
            pData.herbs[i].amount = 0;
        }
        for (int i = 0; i < numFruits; i++)
        {
            pData.fruits[i].amount = 0;
        }
        for (int i = 0; i < numMagicSpells; i++)
        {
            pData.magicSpells[i].amount = 0;
        }
        PlayerDataJSON playerDataJSON = new PlayerDataJSON()
        {
            Coins = PlayerData.coins,
            CopperOre = pData.ores[0].amount,
            TinOre = pData.ores[1].amount,
            IronOre = pData.ores[2].amount,
            CoalOre = pData.ores[3].amount,
            AluminiumOre = pData.ores[4].amount,
            NickelOre = pData.ores[5].amount,
            MagnesiumOre = pData.ores[6].amount,
            ZincOre = pData.ores[7].amount,
            LeadOre = pData.ores[8].amount,
            SilverOre = pData.ores[9].amount,
            GoldOre = pData.ores[10].amount,
            PlatinumOre = pData.ores[11].amount,
            ObsidianOre = pData.ores[12].amount,
            MeteoriteOre = pData.ores[13].amount,
            MithrilOre = pData.ores[14].amount,
            AdamanteusOre = pData.ores[15].amount,
            QuicksilverOre = pData.ores[16].amount,
            AetherOre = pData.ores[17].amount,
            CrimsoniteOre = pData.ores[18].amount,
            Copper = pData.metals[0].amount,
            Tin = pData.metals[1].amount,
            Bronze = pData.metals[2].amount,
            Iron = pData.metals[3].amount,
            Steel = pData.metals[4].amount,
            Aluminium = pData.metals[5].amount,
            Duralumin = pData.metals[6].amount,
            Nickel = pData.metals[7].amount,
            Invar = pData.metals[8].amount,
            Magnesium = pData.metals[9].amount,
            Hydronalium = pData.metals[10].amount,
            Zinc = pData.metals[11].amount,
            Brass = pData.metals[12].amount,
            Zamakium = pData.metals[13].amount,
            Lead = pData.metals[14].amount,
            WhiteMetal = pData.metals[15].amount,
            DamascusSteel = pData.metals[16].amount,
            Silver = pData.metals[17].amount,
            Gold = pData.metals[18].amount,
            RoseGold = pData.metals[19].amount,
            Elinvar = pData.metals[20].amount,
            Electrum = pData.metals[21].amount,
            CorinthianBronze = pData.metals[22].amount,
            Platinum = pData.metals[23].amount,
            RefinedObsidian = pData.metals[24].amount,
            Darksteel = pData.metals[25].amount,
            RefinedMeteorite = pData.metals[26].amount,
            MeteoricIron = pData.metals[27].amount,
            Shadowsteel = pData.metals[28].amount,
            MeteoricSteel = pData.metals[29].amount,
            Mithril = pData.metals[30].amount,
            MysticalSteel = pData.metals[31].amount,
            Adamanteus = pData.metals[32].amount,
            DivineSteel = pData.metals[33].amount,
            Quicksilver = pData.metals[34].amount,
            CelestialSteel = pData.metals[35].amount,
            Luminium = pData.metals[36].amount,
            Aether = pData.metals[37].amount,
            Etherium = pData.metals[38].amount,
            CosmicSteel = pData.metals[39].amount,
            Crimsonite = pData.metals[40].amount,
            SoulSteel = pData.metals[41].amount,
            Neutronium = pData.metals[42].amount,
            Orichalcum = pData.metals[43].amount,
            Infinitium = pData.metals[44].amount,
            Amber = pData.gems[0].amount,
            Quartz = pData.gems[1].amount,
            Opal = pData.gems[2].amount,
            Jade = pData.gems[3].amount,
            Cinnabar = pData.gems[4].amount,
            Ametrine = pData.gems[5].amount,
            SmokyQuartz = pData.gems[6].amount,
            Garnet = pData.gems[7].amount,
            Onyx = pData.gems[8].amount,
            Pyrite = pData.gems[9].amount,
            Heliodor = pData.gems[10].amount,
            Citrine = pData.gems[11].amount,
            RoseQuartz = pData.gems[12].amount,
            LapisLazuli = pData.gems[13].amount,
            Aquamarine = pData.gems[14].amount,
            Peridot = pData.gems[15].amount,
            Turquoise = pData.gems[16].amount,
            IcyQuartz = pData.gems[17].amount,
            Coralite = pData.gems[18].amount,
            Amethyst = pData.gems[19].amount,
            Prismarium = pData.gems[20].amount,
            Topaz = pData.gems[21].amount,
            Ruby = pData.gems[22].amount,
            Moonstone = pData.gems[23].amount,
            Sapphire = pData.gems[24].amount,
            Sunstone = pData.gems[25].amount,
            Emerald = pData.gems[26].amount,
            Bloodstone = pData.gems[27].amount,
            StarCrystal = pData.gems[28].amount,
            Diamond = pData.gems[29].amount,
            LuckPotion1 = pData.potions[0].amount,
            LuckPotion2 = pData.potions[5].amount,
            LuckPotion3 = pData.potions[10].amount,
            LuckPotion4 = pData.potions[15].amount,
            LuckPotion5 = pData.potions[20].amount,
            LuckPotion6 = pData.potions[25].amount,
            DefencePotion1 = pData.potions[1].amount,
            DefencePotion2 = pData.potions[6].amount,
            DefencePotion3 = pData.potions[11].amount,
            DefencePotion4 = pData.potions[16].amount,
            DefencePotion5 = pData.potions[21].amount,
            DefencePotion6 = pData.potions[26].amount,
            HealthPotion1 = pData.potions[2].amount,
            HealthPotion2 = pData.potions[7].amount,
            HealthPotion3 = pData.potions[12].amount,
            HealthPotion4 = pData.potions[17].amount,
            HealthPotion5 = pData.potions[22].amount,
            HealthPotion6 = pData.potions[27].amount,
            AttackPotion1 = pData.potions[3].amount,
            AttackPotion2 = pData.potions[8].amount,
            AttackPotion3 = pData.potions[13].amount,
            AttackPotion4 = pData.potions[18].amount,
            AttackPotion5 = pData.potions[23].amount,
            AttackPotion6 = pData.potions[28].amount,
            MagicPotion1 = pData.potions[4].amount,
            MagicPotion2 = pData.potions[9].amount,
            MagicPotion3 = pData.potions[14].amount,
            MagicPotion4 = pData.potions[19].amount,
            MagicPotion5 = pData.potions[24].amount,
            MagicPotion6 = pData.potions[29].amount,
            MarvelousPotion = pData.potions[30].amount,
            Clover = pData.herbs[0].amount,
            DaisyPetal = pData.herbs[1].amount,
            Holly = pData.herbs[2].amount,
            RoseThorn = pData.herbs[3].amount,
            IvySprig = pData.herbs[4].amount,
            Windrush = pData.herbs[5].amount,
            WillowTwig = pData.herbs[6].amount,
            Goosegrass = pData.herbs[7].amount,
            Firegrass = pData.herbs[8].amount,
            Moly = pData.herbs[9].amount,
            Starthistle = pData.herbs[10].amount,
            Knotweed = pData.herbs[11].amount,
            Bitterroot = pData.herbs[12].amount,
            Baneberry = pData.herbs[13].amount,
            MandrakeRoot = pData.herbs[14].amount,
            TawnymothWeed = pData.herbs[15].amount,
            Spleenwort = pData.herbs[16].amount,
            HelleboreSyrup = pData.herbs[17].amount,
            ValerianRoot = pData.herbs[18].amount,
            DragonIvy = pData.herbs[19].amount,
            Asphodel = pData.herbs[20].amount,
            Wormwood = pData.herbs[21].amount,
            Silverweed = pData.herbs[22].amount,
            Wolfsbane = pData.herbs[23].amount,
            Moondew = pData.herbs[24].amount,
            Fluxweed = pData.herbs[25].amount,
            Tormentil = pData.herbs[26].amount,
            Belladonna = pData.herbs[27].amount,
            Nightshade = pData.herbs[28].amount,
            Bloodroot = pData.herbs[29].amount,
            RubyApple = pData.fruits[0].amount,
            BloodOrange = pData.fruits[1].amount,
            CinderBanana = pData.fruits[2].amount,
            DewLemon = pData.fruits[3].amount,
            GoldenMango = pData.fruits[4].amount,
            WildNectarine = pData.fruits[5].amount,
            LightningSpell = pData.magicSpells[0].amount,
            WaterSpell = pData.magicSpells[1].amount,
            FireSpell = pData.magicSpells[2].amount,
            WindSpell = pData.magicSpells[3].amount,
            IceSpell = pData.magicSpells[4].amount,
            EarthSpell = pData.magicSpells[5].amount,
            SummoningSpell = pData.magicSpells[6].amount,
        };
        string dataJSON = JsonUtility.ToJson(playerDataJSON);
        File.WriteAllText(dataFilePath, dataJSON);
        //Debug.Log("Data Reset");
    }

    public void OneOfEach()
    {
        PlayerData.coins++;
        for (int i = 0; i < numOres; i++)
        {
            pData.ores[i].amount++;
        }
        for (int i = 0; i < numMetals; i++)
        {
            pData.metals[i].amount++;
        }
        for (int i = 0; i < numGems; i++)
        {
            pData.gems[i].amount++;
        }
        for (int i = 0; i < numPotions; i++)
        {
            pData.potions[i].amount++;
        }
        for (int i = 0; i < numHerbs; i++)
        {
            pData.herbs[i].amount++;
        }
        for (int i = 0; i < numFruits; i++)
        {
            pData.fruits[i].amount++;
        }
        for (int i = 0; i < numMagicSpells; i++)
        {
            pData.magicSpells[i].amount++;
        }
        PlayerDataJSON playerDataJSON = new PlayerDataJSON()
        {
            Coins = PlayerData.coins,
            CopperOre = pData.ores[0].amount,
            TinOre = pData.ores[1].amount,
            IronOre = pData.ores[2].amount,
            CoalOre = pData.ores[3].amount,
            AluminiumOre = pData.ores[4].amount,
            NickelOre = pData.ores[5].amount,
            MagnesiumOre = pData.ores[6].amount,
            ZincOre = pData.ores[7].amount,
            LeadOre = pData.ores[8].amount,
            SilverOre = pData.ores[9].amount,
            GoldOre = pData.ores[10].amount,
            PlatinumOre = pData.ores[11].amount,
            ObsidianOre = pData.ores[12].amount,
            MeteoriteOre = pData.ores[13].amount,
            MithrilOre = pData.ores[14].amount,
            AdamanteusOre = pData.ores[15].amount,
            QuicksilverOre = pData.ores[16].amount,
            AetherOre = pData.ores[17].amount,
            CrimsoniteOre = pData.ores[18].amount,
            Copper = pData.metals[0].amount,
            Tin = pData.metals[1].amount,
            Bronze = pData.metals[2].amount,
            Iron = pData.metals[3].amount,
            Steel = pData.metals[4].amount,
            Aluminium = pData.metals[5].amount,
            Duralumin = pData.metals[6].amount,
            Nickel = pData.metals[7].amount,
            Invar = pData.metals[8].amount,
            Magnesium = pData.metals[9].amount,
            Hydronalium = pData.metals[10].amount,
            Zinc = pData.metals[11].amount,
            Brass = pData.metals[12].amount,
            Zamakium = pData.metals[13].amount,
            Lead = pData.metals[14].amount,
            WhiteMetal = pData.metals[15].amount,
            DamascusSteel = pData.metals[16].amount,
            Silver = pData.metals[17].amount,
            Gold = pData.metals[18].amount,
            RoseGold = pData.metals[19].amount,
            Elinvar = pData.metals[20].amount,
            Electrum = pData.metals[21].amount,
            CorinthianBronze = pData.metals[22].amount,
            Platinum = pData.metals[23].amount,
            RefinedObsidian = pData.metals[24].amount,
            Darksteel = pData.metals[25].amount,
            RefinedMeteorite = pData.metals[26].amount,
            MeteoricIron = pData.metals[27].amount,
            Shadowsteel = pData.metals[28].amount,
            MeteoricSteel = pData.metals[29].amount,
            Mithril = pData.metals[30].amount,
            MysticalSteel = pData.metals[31].amount,
            Adamanteus = pData.metals[32].amount,
            DivineSteel = pData.metals[33].amount,
            Quicksilver = pData.metals[34].amount,
            CelestialSteel = pData.metals[35].amount,
            Luminium = pData.metals[36].amount,
            Aether = pData.metals[37].amount,
            Etherium = pData.metals[38].amount,
            CosmicSteel = pData.metals[39].amount,
            Crimsonite = pData.metals[40].amount,
            SoulSteel = pData.metals[41].amount,
            Neutronium = pData.metals[42].amount,
            Orichalcum = pData.metals[43].amount,
            Infinitium = pData.metals[44].amount,
            Amber = pData.gems[0].amount,
            Quartz = pData.gems[1].amount,
            Opal = pData.gems[2].amount,
            Jade = pData.gems[3].amount,
            Cinnabar = pData.gems[4].amount,
            Ametrine = pData.gems[5].amount,
            SmokyQuartz = pData.gems[6].amount,
            Garnet = pData.gems[7].amount,
            Onyx = pData.gems[8].amount,
            Pyrite = pData.gems[9].amount,
            Heliodor = pData.gems[10].amount,
            Citrine = pData.gems[11].amount,
            RoseQuartz = pData.gems[12].amount,
            LapisLazuli = pData.gems[13].amount,
            Aquamarine = pData.gems[14].amount,
            Peridot = pData.gems[15].amount,
            Turquoise = pData.gems[16].amount,
            IcyQuartz = pData.gems[17].amount,
            Coralite = pData.gems[18].amount,
            Amethyst = pData.gems[19].amount,
            Prismarium = pData.gems[20].amount,
            Topaz = pData.gems[21].amount,
            Ruby = pData.gems[22].amount,
            Moonstone = pData.gems[23].amount,
            Sapphire = pData.gems[24].amount,
            Sunstone = pData.gems[25].amount,
            Emerald = pData.gems[26].amount,
            Bloodstone = pData.gems[27].amount,
            StarCrystal = pData.gems[28].amount,
            Diamond = pData.gems[29].amount,
            LuckPotion1 = pData.potions[0].amount,
            LuckPotion2 = pData.potions[5].amount,
            LuckPotion3 = pData.potions[10].amount,
            LuckPotion4 = pData.potions[15].amount,
            LuckPotion5 = pData.potions[20].amount,
            LuckPotion6 = pData.potions[25].amount,
            DefencePotion1 = pData.potions[1].amount,
            DefencePotion2 = pData.potions[6].amount,
            DefencePotion3 = pData.potions[11].amount,
            DefencePotion4 = pData.potions[16].amount,
            DefencePotion5 = pData.potions[21].amount,
            DefencePotion6 = pData.potions[26].amount,
            HealthPotion1 = pData.potions[2].amount,
            HealthPotion2 = pData.potions[7].amount,
            HealthPotion3 = pData.potions[12].amount,
            HealthPotion4 = pData.potions[17].amount,
            HealthPotion5 = pData.potions[22].amount,
            HealthPotion6 = pData.potions[27].amount,
            AttackPotion1 = pData.potions[3].amount,
            AttackPotion2 = pData.potions[8].amount,
            AttackPotion3 = pData.potions[13].amount,
            AttackPotion4 = pData.potions[18].amount,
            AttackPotion5 = pData.potions[23].amount,
            AttackPotion6 = pData.potions[28].amount,
            MagicPotion1 = pData.potions[4].amount,
            MagicPotion2 = pData.potions[9].amount,
            MagicPotion3 = pData.potions[14].amount,
            MagicPotion4 = pData.potions[19].amount,
            MagicPotion5 = pData.potions[24].amount,
            MagicPotion6 = pData.potions[29].amount,
            MarvelousPotion = pData.potions[30].amount,
            Clover = pData.herbs[0].amount,
            DaisyPetal = pData.herbs[1].amount,
            Holly = pData.herbs[2].amount,
            RoseThorn = pData.herbs[3].amount,
            IvySprig = pData.herbs[4].amount,
            Windrush = pData.herbs[5].amount,
            WillowTwig = pData.herbs[6].amount,
            Goosegrass = pData.herbs[7].amount,
            Firegrass = pData.herbs[8].amount,
            Moly = pData.herbs[9].amount,
            Starthistle = pData.herbs[10].amount,
            Knotweed = pData.herbs[11].amount,
            Bitterroot = pData.herbs[12].amount,
            Baneberry = pData.herbs[13].amount,
            MandrakeRoot = pData.herbs[14].amount,
            TawnymothWeed = pData.herbs[15].amount,
            Spleenwort = pData.herbs[16].amount,
            HelleboreSyrup = pData.herbs[17].amount,
            ValerianRoot = pData.herbs[18].amount,
            DragonIvy = pData.herbs[19].amount,
            Asphodel = pData.herbs[20].amount,
            Wormwood = pData.herbs[21].amount,
            Silverweed = pData.herbs[22].amount,
            Wolfsbane = pData.herbs[23].amount,
            Moondew = pData.herbs[24].amount,
            Fluxweed = pData.herbs[25].amount,
            Tormentil = pData.herbs[26].amount,
            Belladonna = pData.herbs[27].amount,
            Nightshade = pData.herbs[28].amount,
            Bloodroot = pData.herbs[29].amount,
            RubyApple = pData.fruits[0].amount,
            BloodOrange = pData.fruits[1].amount,
            CinderBanana = pData.fruits[2].amount,
            DewLemon = pData.fruits[3].amount,
            GoldenMango = pData.fruits[4].amount,
            WildNectarine = pData.fruits[5].amount,
            LightningSpell = pData.magicSpells[0].amount,
            WaterSpell = pData.magicSpells[1].amount,
            FireSpell = pData.magicSpells[2].amount,
            WindSpell = pData.magicSpells[3].amount,
            IceSpell = pData.magicSpells[4].amount,
            EarthSpell = pData.magicSpells[5].amount,
            SummoningSpell = pData.magicSpells[6].amount,
        };
        string dataJSON = JsonUtility.ToJson(playerDataJSON);
        File.WriteAllText(dataFilePath, dataJSON);
    }
    
    private string GetApplicationPath()
    {
#if UNITY_EDITOR
        return Application.dataPath + "/Data/";
#elif UNITY_ANDROID
        return Application.persistentDataPath;
#elif UNITY_IPHONE
        return Application.persistentDataPath+"/";
#else
        return Application.dataPath +"/";
#endif
    }
}