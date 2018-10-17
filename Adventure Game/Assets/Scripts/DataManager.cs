using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataManager : MonoBehaviour {
    
    string dataFilePath;

    public static bool saveData;
    public static float saveTimer;

    public const int numArmour = 8;
    public const int numOres = 19;
    public const int numMetals = 45;
    public const int numGems = 30;
    public const int numPotions = 31;
    public const int numHerbs = 30;
    public const int numFruits = 6;

    #region To view data in runtime only
    public int Coins;

    //Armour, Weapons and Tools
    public int HelmTier;
    public int ChestplateTier;
    public int GauntletsTier;
    public int LeggingsTier;
    public int BootsTier;
    public int ShieldTier;
    public int WeaponTier;
    public int PickaxeTier;

    //Metals and Alloys
    public int CopperOre;
    public int TinOre;
    public int IronOre;
    public int CoalOre;
    public int AluminiumOre;
    public int NickelOre;
    public int MagnesiumOre;
    public int ZincOre;
    public int LeadOre;
    public int SilverOre;
    public int GoldOre;
    public int PlatinumOre;
    public int ObsidianOre;
    public int MeteoriteOre;
    public int MithrilOre;
    public int AdamanteusOre;
    public int QuicksilverOre;
    public int AetherOre;
    public int CrimsoniteOre;
    public int Copper;
    public int Tin;
    public int Bronze;
    public int Iron;
    public int Steel;
    public int Aluminium;
    public int Duralumin;
    public int Nickel;
    public int Invar;
    public int Magnesium;
    public int Hydronalium;
    public int Zinc;
    public int Brass;
    public int Zamakium;
    public int Lead;
    public int WhiteMetal;
    public int DamascusSteel;
    public int Silver;
    public int Gold;
    public int RoseGold;
    public int Elinvar;
    public int Electrum;
    public int CorinthianBronze;
    public int Platinum;
    public int RefinedObsidian;
    public int Darksteel;
    public int RefinedMeteorite;
    public int MeteoricIron;
    public int Shadowsteel;
    public int MeteoricSteel;
    public int Mithril;
    public int MysticalSteel;
    public int Adamanteus;
    public int DivineSteel;
    public int Quicksilver;
    public int CelestialSteel;
    public int Luminium;
    public int Aether;
    public int Etherium;
    public int CosmicSteel;
    public int Crimsonite;
    public int SoulSteel;
    public int Neutronium;
    public int Orichalcum;
    public int Infinitium;

    //Gems
    public int Amber;
    public int Quartz;
    public int Opal;
    public int Jade;
    public int Cinnabar;
    public int Ametrine;
    public int SmokyQuartz;
    public int Garnet;
    public int Onyx;
    public int Pyrite;
    public int Heliodor;
    public int Citrine;
    public int RoseQuartz;
    public int LapisLazuli;
    public int Aquamarine;
    public int Peridot;
    public int Turquoise;
    public int IcyQuartz;
    public int Coralite;
    public int Amethyst;
    public int Prismarium;
    public int Topaz;
    public int Ruby;
    public int Moonstone;
    public int Sapphire;
    public int Sunstone;
    public int Emerald;
    public int Bloodstone;
    public int StarCrystal;
    public int Diamond;

    //Potions
    public int LuckPotion1;
    public int LuckPotion2;
    public int LuckPotion3;
    public int LuckPotion4;
    public int LuckPotion5;
    public int LuckPotion6;
    public int DefencePotion1;
    public int DefencePotion2;
    public int DefencePotion3;
    public int DefencePotion4;
    public int DefencePotion5;
    public int DefencePotion6;
    public int HealthPotion1;
    public int HealthPotion2;
    public int HealthPotion3;
    public int HealthPotion4;
    public int HealthPotion5;
    public int HealthPotion6;
    public int AttackPotion1;
    public int AttackPotion2;
    public int AttackPotion3;
    public int AttackPotion4;
    public int AttackPotion5;
    public int AttackPotion6;
    public int MagicPotion1;
    public int MagicPotion2;
    public int MagicPotion3;
    public int MagicPotion4;
    public int MagicPotion5;
    public int MagicPotion6;
    public int MarvelousPotion;

    //Herbs
    public int Clover;
    public int DaisyPetal;
    public int Holly;
    public int RoseThorn;
    public int IvySprig;
    public int Windrush;
    public int WillowTwig;
    public int Goosegrass;
    public int Firegrass;
    public int Moly;
    public int Starthistle;
    public int Knotweed;
    public int Bitterroot;
    public int Baneberry;
    public int MandrakeRoot;
    public int TawnymothWeed;
    public int Spleenwort;
    public int HelleboreSyrup;
    public int ValerianRoot;
    public int DragonIvy;
    public int Asphodel;
    public int Wormwood;
    public int Silverweed;
    public int Wolfsbane;
    public int Moondew;
    public int Fluxweed;
    public int Tormentil;
    public int Belladonna;
    public int Nightshade;
    public int Bloodroot;

    //Fruits
    public int RubyApple;
    public int BloodOrange;
    public int CinderBanana;
    public int DewLemon;
    public int GoldenMango;
    public int WildNectarine;
    #endregion

    private void Start()
    {
        dataFilePath = Path.Combine(Application.streamingAssetsPath, "data.json");
        if(SceneManager.GetActiveScene().name == "Main")
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
        HelmTier = PlayerData.armourTier[0];
        ChestplateTier = PlayerData.armourTier[1];
        GauntletsTier = PlayerData.armourTier[2];
        LeggingsTier = PlayerData.armourTier[3];
        BootsTier = PlayerData.armourTier[4];
        ShieldTier = PlayerData.armourTier[5];
        WeaponTier = PlayerData.armourTier[6];
        PickaxeTier = PlayerData.armourTier[7];
        CopperOre = PlayerData.ores[0];
        TinOre = PlayerData.ores[1];
        IronOre = PlayerData.ores[2];
        CoalOre = PlayerData.ores[3];
        AluminiumOre = PlayerData.ores[4];
        NickelOre = PlayerData.ores[5];
        MagnesiumOre = PlayerData.ores[6];
        ZincOre = PlayerData.ores[7];
        LeadOre = PlayerData.ores[8];
        SilverOre = PlayerData.ores[9];
        GoldOre = PlayerData.ores[10];
        PlatinumOre = PlayerData.ores[11];
        ObsidianOre = PlayerData.ores[12];
        MeteoriteOre = PlayerData.ores[13];
        MithrilOre = PlayerData.ores[14];
        AdamanteusOre = PlayerData.ores[15];
        QuicksilverOre = PlayerData.ores[16];
        AetherOre = PlayerData.ores[17];
        CrimsoniteOre = PlayerData.ores[18];
        Copper = PlayerData.metals[0];
        Tin = PlayerData.metals[1];
        Bronze = PlayerData.metals[2];
        Iron = PlayerData.metals[3];
        Steel = PlayerData.metals[4];
        Aluminium = PlayerData.metals[5];
        Duralumin = PlayerData.metals[6];
        Nickel = PlayerData.metals[7];
        Invar = PlayerData.metals[8];
        Magnesium = PlayerData.metals[9];
        Hydronalium = PlayerData.metals[10];
        Zinc = PlayerData.metals[11];
        Brass = PlayerData.metals[12];
        Zamakium = PlayerData.metals[13];
        Lead = PlayerData.metals[14];
        WhiteMetal = PlayerData.metals[15];
        DamascusSteel = PlayerData.metals[16];
        Silver = PlayerData.metals[17];
        Gold = PlayerData.metals[18];
        RoseGold = PlayerData.metals[19];
        Elinvar = PlayerData.metals[20];
        Electrum = PlayerData.metals[21];
        CorinthianBronze = PlayerData.metals[22];
        Platinum = PlayerData.metals[23];
        RefinedObsidian = PlayerData.metals[24];
        Darksteel = PlayerData.metals[25];
        RefinedMeteorite = PlayerData.metals[26];
        MeteoricIron = PlayerData.metals[27];
        Shadowsteel = PlayerData.metals[28];
        MeteoricSteel = PlayerData.metals[29];
        Mithril = PlayerData.metals[30];
        MysticalSteel = PlayerData.metals[31];
        Adamanteus = PlayerData.metals[32];
        DivineSteel = PlayerData.metals[33];
        Quicksilver = PlayerData.metals[34];
        CelestialSteel = PlayerData.metals[35];
        Luminium = PlayerData.metals[36];
        Aether = PlayerData.metals[37];
        Etherium = PlayerData.metals[38];
        CosmicSteel = PlayerData.metals[39];
        Crimsonite = PlayerData.metals[40];
        SoulSteel = PlayerData.metals[41];
        Neutronium = PlayerData.metals[42];
        Orichalcum = PlayerData.metals[43];
        Infinitium = PlayerData.metals[44];
        Amber = PlayerData.gems[0];
        Quartz = PlayerData.gems[1];
        Opal = PlayerData.gems[2];
        Jade = PlayerData.gems[3];
        Cinnabar = PlayerData.gems[4];
        Ametrine = PlayerData.gems[5];
        SmokyQuartz = PlayerData.gems[6];
        Garnet = PlayerData.gems[7];
        Onyx = PlayerData.gems[8];
        Pyrite = PlayerData.gems[9];
        Heliodor = PlayerData.gems[10];
        Citrine = PlayerData.gems[11];
        RoseQuartz = PlayerData.gems[12];
        LapisLazuli = PlayerData.gems[13];
        Aquamarine = PlayerData.gems[14];
        Peridot = PlayerData.gems[15];
        Turquoise = PlayerData.gems[16];
        IcyQuartz = PlayerData.gems[17];
        Coralite = PlayerData.gems[18];
        Amethyst = PlayerData.gems[19];
        Prismarium = PlayerData.gems[20];
        Topaz = PlayerData.gems[21];
        Ruby = PlayerData.gems[22];
        Moonstone = PlayerData.gems[23];
        Sapphire = PlayerData.gems[24];
        Sunstone = PlayerData.gems[25];
        Emerald = PlayerData.gems[26];
        Bloodstone = PlayerData.gems[27];
        StarCrystal = PlayerData.gems[28];
        Diamond = PlayerData.gems[29];
        LuckPotion1 = PlayerData.potions[0];
        LuckPotion2 = PlayerData.potions[5];
        LuckPotion3 = PlayerData.potions[10];
        LuckPotion4 = PlayerData.potions[15];
        LuckPotion5 = PlayerData.potions[20];
        LuckPotion6 = PlayerData.potions[25];
        DefencePotion1 = PlayerData.potions[1];
        DefencePotion2 = PlayerData.potions[6];
        DefencePotion3 = PlayerData.potions[11];
        DefencePotion4 = PlayerData.potions[16];
        DefencePotion5 = PlayerData.potions[21];
        DefencePotion6 = PlayerData.potions[26];
        HealthPotion1 = PlayerData.potions[2];
        HealthPotion2 = PlayerData.potions[7];
        HealthPotion3 = PlayerData.potions[12];
        HealthPotion4 = PlayerData.potions[17];
        HealthPotion5 = PlayerData.potions[22];
        HealthPotion6 = PlayerData.potions[27];
        AttackPotion1 = PlayerData.potions[3];
        AttackPotion2 = PlayerData.potions[8];
        AttackPotion3 = PlayerData.potions[13];
        AttackPotion4 = PlayerData.potions[18];
        AttackPotion5 = PlayerData.potions[23];
        AttackPotion6 = PlayerData.potions[28];
        MagicPotion1 = PlayerData.potions[4];
        MagicPotion2 = PlayerData.potions[9];
        MagicPotion3 = PlayerData.potions[14];
        MagicPotion4 = PlayerData.potions[19];
        MagicPotion5 = PlayerData.potions[24];
        MagicPotion6 = PlayerData.potions[29];
        MarvelousPotion = PlayerData.potions[30];
        Clover = PlayerData.herbs[0];
        DaisyPetal = PlayerData.herbs[1];
        Holly = PlayerData.herbs[2];
        RoseThorn = PlayerData.herbs[3];
        IvySprig = PlayerData.herbs[4];
        Windrush = PlayerData.herbs[5];
        WillowTwig = PlayerData.herbs[6];
        Goosegrass = PlayerData.herbs[7];
        Firegrass = PlayerData.herbs[8];
        Moly = PlayerData.herbs[9];
        Starthistle = PlayerData.herbs[10];
        Knotweed = PlayerData.herbs[11];
        Bitterroot = PlayerData.herbs[12];
        Baneberry = PlayerData.herbs[13];
        MandrakeRoot = PlayerData.herbs[14];
        TawnymothWeed = PlayerData.herbs[15];
        Spleenwort = PlayerData.herbs[16];
        HelleboreSyrup = PlayerData.herbs[17];
        ValerianRoot = PlayerData.herbs[18];
        DragonIvy = PlayerData.herbs[19];
        Asphodel = PlayerData.herbs[20];
        Wormwood = PlayerData.herbs[21];
        Silverweed = PlayerData.herbs[22];
        Wolfsbane = PlayerData.herbs[23];
        Moondew = PlayerData.herbs[24];
        Fluxweed = PlayerData.herbs[25];
        Tormentil = PlayerData.herbs[26];
        Belladonna = PlayerData.herbs[27];
        Nightshade = PlayerData.herbs[28];
        Bloodroot = PlayerData.herbs[29];
        RubyApple = PlayerData.fruits[0];
        BloodOrange = PlayerData.fruits[1];
        CinderBanana = PlayerData.fruits[2];
        DewLemon = PlayerData.fruits[3];
        GoldenMango = PlayerData.fruits[4];
        WildNectarine = PlayerData.fruits[5];
        #endregion
    }

    public void LoadGameData()
    {
        if (File.Exists(dataFilePath))
        {
            string data = File.ReadAllText(dataFilePath);
            PlayerDataJSON loadedData = JsonUtility.FromJson<PlayerDataJSON>(data);
            PlayerData.coins = loadedData.Coins;
            PlayerData.armourTier[0] = loadedData.HelmTier;
            PlayerData.armourTier[1] = loadedData.ChestplateTier;
            PlayerData.armourTier[2] = loadedData.GauntletsTier;
            PlayerData.armourTier[3] = loadedData.LeggingsTier;
            PlayerData.armourTier[4] = loadedData.BootsTier;
            PlayerData.armourTier[5] = loadedData.ShieldTier;
            PlayerData.armourTier[6] = loadedData.WeaponTier;
            PlayerData.armourTier[7] = loadedData.PickaxeTier;
            PlayerData.ores[0] = loadedData.CopperOre;
            PlayerData.ores[1] = loadedData.TinOre;
            PlayerData.ores[2] = loadedData.IronOre;
            PlayerData.ores[3] = loadedData.CoalOre;
            PlayerData.ores[4] = loadedData.AluminiumOre;
            PlayerData.ores[5] = loadedData.NickelOre;
            PlayerData.ores[6] = loadedData.MagnesiumOre;
            PlayerData.ores[7] = loadedData.ZincOre;
            PlayerData.ores[8] = loadedData.LeadOre;
            PlayerData.ores[9] = loadedData.SilverOre;
            PlayerData.ores[10] = loadedData.GoldOre;
            PlayerData.ores[11] = loadedData.PlatinumOre;
            PlayerData.ores[12] = loadedData.ObsidianOre;
            PlayerData.ores[13] = loadedData.MeteoriteOre;
            PlayerData.ores[14] = loadedData.MithrilOre;
            PlayerData.ores[15] = loadedData.AdamanteusOre;
            PlayerData.ores[16] = loadedData.QuicksilverOre;
            PlayerData.ores[17] = loadedData.AetherOre;
            PlayerData.ores[18] = loadedData.CrimsoniteOre;
            PlayerData.metals[0] = loadedData.Copper;
            PlayerData.metals[1] = loadedData.Tin;
            PlayerData.metals[2] = loadedData.Bronze;
            PlayerData.metals[3] = loadedData.Iron;
            PlayerData.metals[4] = loadedData.Steel;
            PlayerData.metals[5] = loadedData.Aluminium;
            PlayerData.metals[6] = loadedData.Duralumin;
            PlayerData.metals[7] = loadedData.Nickel;
            PlayerData.metals[8] = loadedData.Invar;
            PlayerData.metals[9] = loadedData.Magnesium;
            PlayerData.metals[10] = loadedData.Hydronalium;
            PlayerData.metals[11] = loadedData.Zinc;
            PlayerData.metals[12] = loadedData.Brass;
            PlayerData.metals[13] = loadedData.Zamakium;
            PlayerData.metals[14] = loadedData.Lead;
            PlayerData.metals[15] = loadedData.WhiteMetal;
            PlayerData.metals[16] = loadedData.DamascusSteel;
            PlayerData.metals[17] = loadedData.Silver;
            PlayerData.metals[18] = loadedData.Gold;
            PlayerData.metals[19] = loadedData.RoseGold;
            PlayerData.metals[20] = loadedData.Elinvar;
            PlayerData.metals[21] = loadedData.Electrum;
            PlayerData.metals[22] = loadedData.CorinthianBronze;
            PlayerData.metals[23] = loadedData.Platinum;
            PlayerData.metals[24] = loadedData.RefinedObsidian;
            PlayerData.metals[25] = loadedData.Darksteel;
            PlayerData.metals[26] = loadedData.RefinedMeteorite;
            PlayerData.metals[27] = loadedData.MeteoricIron;
            PlayerData.metals[28] = loadedData.Shadowsteel;
            PlayerData.metals[29] = loadedData.MeteoricSteel;
            PlayerData.metals[30] = loadedData.Mithril;
            PlayerData.metals[31] = loadedData.MysticalSteel;
            PlayerData.metals[32] = loadedData.Adamanteus;
            PlayerData.metals[33] = loadedData.DivineSteel;
            PlayerData.metals[34] = loadedData.Quicksilver;
            PlayerData.metals[35] = loadedData.CelestialSteel;
            PlayerData.metals[36] = loadedData.Luminium;
            PlayerData.metals[37] = loadedData.Aether;
            PlayerData.metals[38] = loadedData.Etherium;
            PlayerData.metals[39] = loadedData.CosmicSteel;
            PlayerData.metals[40] = loadedData.Crimsonite;
            PlayerData.metals[41] = loadedData.SoulSteel;
            PlayerData.metals[42] = loadedData.Neutronium;
            PlayerData.metals[43] = loadedData.Orichalcum;
            PlayerData.metals[44] = loadedData.Infinitium;
            PlayerData.gems[0] = loadedData.Amber;
            PlayerData.gems[1] = loadedData.Quartz;
            PlayerData.gems[2] = loadedData.Opal;
            PlayerData.gems[3] = loadedData.Jade;
            PlayerData.gems[4] = loadedData.Cinnabar;
            PlayerData.gems[5] = loadedData.Ametrine;
            PlayerData.gems[6] = loadedData.SmokyQuartz;
            PlayerData.gems[7] = loadedData.Garnet;
            PlayerData.gems[8] = loadedData.Onyx;
            PlayerData.gems[9] = loadedData.Pyrite;
            PlayerData.gems[10] = loadedData.Heliodor;
            PlayerData.gems[11] = loadedData.Citrine;
            PlayerData.gems[12] = loadedData.RoseQuartz;
            PlayerData.gems[13] = loadedData.LapisLazuli;
            PlayerData.gems[14] = loadedData.Aquamarine;
            PlayerData.gems[15] = loadedData.Peridot;
            PlayerData.gems[16] = loadedData.Turquoise;
            PlayerData.gems[17] = loadedData.IcyQuartz;
            PlayerData.gems[18] = loadedData.Coralite;
            PlayerData.gems[19] = loadedData.Amethyst;
            PlayerData.gems[20] = loadedData.Prismarium;
            PlayerData.gems[21] = loadedData.Topaz;
            PlayerData.gems[22] = loadedData.Ruby;
            PlayerData.gems[23] = loadedData.Moonstone;
            PlayerData.gems[24] = loadedData.Sapphire;
            PlayerData.gems[25] = loadedData.Sunstone;
            PlayerData.gems[26] = loadedData.Emerald;
            PlayerData.gems[27] = loadedData.Bloodstone;
            PlayerData.gems[28] = loadedData.StarCrystal;
            PlayerData.gems[29] = loadedData.Diamond;
            PlayerData.potions[0] = loadedData.LuckPotion1;
            PlayerData.potions[5] = loadedData.LuckPotion2;
            PlayerData.potions[10] = loadedData.LuckPotion3;
            PlayerData.potions[15] = loadedData.LuckPotion4;
            PlayerData.potions[20] = loadedData.LuckPotion5;
            PlayerData.potions[25] = loadedData.LuckPotion6;
            PlayerData.potions[1] = loadedData.DefencePotion1;
            PlayerData.potions[6] = loadedData.DefencePotion2;
            PlayerData.potions[11] = loadedData.DefencePotion3;
            PlayerData.potions[16] = loadedData.DefencePotion4;
            PlayerData.potions[21] = loadedData.DefencePotion5;
            PlayerData.potions[26] = loadedData.DefencePotion6;
            PlayerData.potions[2] = loadedData.HealthPotion1;
            PlayerData.potions[7] = loadedData.HealthPotion2;
            PlayerData.potions[12] = loadedData.HealthPotion3;
            PlayerData.potions[17] = loadedData.HealthPotion4;
            PlayerData.potions[22] = loadedData.HealthPotion5;
            PlayerData.potions[27] = loadedData.HealthPotion6;
            PlayerData.potions[3] = loadedData.AttackPotion1;
            PlayerData.potions[8] = loadedData.AttackPotion2;
            PlayerData.potions[13] = loadedData.AttackPotion3;
            PlayerData.potions[18] = loadedData.AttackPotion4;
            PlayerData.potions[23] = loadedData.AttackPotion5;
            PlayerData.potions[28] = loadedData.AttackPotion6;
            PlayerData.potions[4] = loadedData.MagicPotion1;
            PlayerData.potions[9] = loadedData.MagicPotion2;
            PlayerData.potions[14] = loadedData.MagicPotion3;
            PlayerData.potions[19] = loadedData.MagicPotion4;
            PlayerData.potions[24] = loadedData.MagicPotion5;
            PlayerData.potions[29] = loadedData.MagicPotion6;
            PlayerData.potions[30] = loadedData.MarvelousPotion;
            PlayerData.herbs[0] = loadedData.Clover;
            PlayerData.herbs[1] = loadedData.DaisyPetal;
            PlayerData.herbs[2] = loadedData.Holly;
            PlayerData.herbs[3] = loadedData.RoseThorn;
            PlayerData.herbs[4] = loadedData.IvySprig;
            PlayerData.herbs[5] = loadedData.Windrush;
            PlayerData.herbs[6] = loadedData.WillowTwig;
            PlayerData.herbs[7] = loadedData.Goosegrass;
            PlayerData.herbs[8] = loadedData.Firegrass;
            PlayerData.herbs[9] = loadedData.Moly;
            PlayerData.herbs[10] = loadedData.Starthistle;
            PlayerData.herbs[11] = loadedData.Knotweed;
            PlayerData.herbs[12] = loadedData.Bitterroot;
            PlayerData.herbs[13] = loadedData.Baneberry;
            PlayerData.herbs[14] = loadedData.MandrakeRoot;
            PlayerData.herbs[15] = loadedData.TawnymothWeed;
            PlayerData.herbs[16] = loadedData.Spleenwort;
            PlayerData.herbs[17] = loadedData.HelleboreSyrup;
            PlayerData.herbs[18] = loadedData.ValerianRoot;
            PlayerData.herbs[19] = loadedData.DragonIvy;
            PlayerData.herbs[20] = loadedData.Asphodel;
            PlayerData.herbs[21] = loadedData.Wormwood;
            PlayerData.herbs[22] = loadedData.Silverweed;
            PlayerData.herbs[23] = loadedData.Wolfsbane;
            PlayerData.herbs[24] = loadedData.Moondew;
            PlayerData.herbs[25] = loadedData.Fluxweed;
            PlayerData.herbs[26] = loadedData.Tormentil;
            PlayerData.herbs[27] = loadedData.Belladonna;
            PlayerData.herbs[28] = loadedData.Nightshade;
            PlayerData.herbs[29] = loadedData.Bloodroot;
            PlayerData.fruits[0] = loadedData.RubyApple;
            PlayerData.fruits[1] = loadedData.BloodOrange;
            PlayerData.fruits[2] = loadedData.CinderBanana;
            PlayerData.fruits[3] = loadedData.DewLemon;
            PlayerData.fruits[4] = loadedData.GoldenMango;
            PlayerData.fruits[5] = loadedData.WildNectarine;
        }
        //Debug.Log("Data Loaded");
    }

    public void SaveGameData()
    {
        PlayerDataJSON playerDataJSON = new PlayerDataJSON()
        {
            Coins = PlayerData.coins,
            HelmTier = PlayerData.armourTier[0],
            ChestplateTier = PlayerData.armourTier[1],
            GauntletsTier = PlayerData.armourTier[2],
            LeggingsTier = PlayerData.armourTier[3],
            BootsTier = PlayerData.armourTier[4],
            ShieldTier = PlayerData.armourTier[5],
            WeaponTier = PlayerData.armourTier[6],
            PickaxeTier = PlayerData.armourTier[7],
            CopperOre = PlayerData.ores[0],
            TinOre = PlayerData.ores[1],
            IronOre = PlayerData.ores[2],
            CoalOre = PlayerData.ores[3],
            AluminiumOre = PlayerData.ores[4],
            NickelOre = PlayerData.ores[5],
            MagnesiumOre = PlayerData.ores[6],
            ZincOre = PlayerData.ores[7],
            LeadOre = PlayerData.ores[8],
            SilverOre = PlayerData.ores[9],
            GoldOre = PlayerData.ores[10],
            PlatinumOre = PlayerData.ores[11],
            ObsidianOre = PlayerData.ores[12],
            MeteoriteOre = PlayerData.ores[13],
            MithrilOre = PlayerData.ores[14],
            AdamanteusOre = PlayerData.ores[15],
            QuicksilverOre = PlayerData.ores[16],
            AetherOre = PlayerData.ores[17],
            CrimsoniteOre = PlayerData.ores[18],
            Copper = PlayerData.metals[0],
            Tin = PlayerData.metals[1],
            Bronze = PlayerData.metals[2],
            Iron = PlayerData.metals[3],
            Steel = PlayerData.metals[4],
            Aluminium = PlayerData.metals[5],
            Duralumin = PlayerData.metals[6],
            Nickel = PlayerData.metals[7],
            Invar = PlayerData.metals[8],
            Magnesium = PlayerData.metals[9],
            Hydronalium = PlayerData.metals[10],
            Zinc = PlayerData.metals[11],
            Brass = PlayerData.metals[12],
            Zamakium = PlayerData.metals[13],
            Lead = PlayerData.metals[14],
            WhiteMetal = PlayerData.metals[15],
            DamascusSteel = PlayerData.metals[16],
            Silver = PlayerData.metals[17],
            Gold = PlayerData.metals[18],
            RoseGold = PlayerData.metals[19],
            Elinvar = PlayerData.metals[20],
            Electrum = PlayerData.metals[21],
            CorinthianBronze = PlayerData.metals[22],
            Platinum = PlayerData.metals[23],
            RefinedObsidian = PlayerData.metals[24],
            Darksteel = PlayerData.metals[25],
            RefinedMeteorite = PlayerData.metals[26],
            MeteoricIron = PlayerData.metals[27],
            Shadowsteel = PlayerData.metals[28],
            MeteoricSteel = PlayerData.metals[29],
            Mithril = PlayerData.metals[30],
            MysticalSteel = PlayerData.metals[31],
            Adamanteus = PlayerData.metals[32],
            DivineSteel = PlayerData.metals[33],
            Quicksilver = PlayerData.metals[34],
            CelestialSteel = PlayerData.metals[35],
            Luminium = PlayerData.metals[36],
            Aether = PlayerData.metals[37],
            Etherium = PlayerData.metals[38],
            CosmicSteel = PlayerData.metals[39],
            Crimsonite = PlayerData.metals[40],
            SoulSteel = PlayerData.metals[41],
            Neutronium = PlayerData.metals[42],
            Orichalcum = PlayerData.metals[43],
            Infinitium = PlayerData.metals[44],
            Amber = PlayerData.gems[0],
            Quartz = PlayerData.gems[1],
            Opal = PlayerData.gems[2],
            Jade = PlayerData.gems[3],
            Cinnabar = PlayerData.gems[4],
            Ametrine = PlayerData.gems[5],
            SmokyQuartz = PlayerData.gems[6],
            Garnet = PlayerData.gems[7],
            Onyx = PlayerData.gems[8],
            Pyrite = PlayerData.gems[9],
            Heliodor = PlayerData.gems[10],
            Citrine = PlayerData.gems[11],
            RoseQuartz = PlayerData.gems[12],
            LapisLazuli = PlayerData.gems[13],
            Aquamarine = PlayerData.gems[14],
            Peridot = PlayerData.gems[15],
            Turquoise = PlayerData.gems[16],
            IcyQuartz = PlayerData.gems[17],
            Coralite = PlayerData.gems[18],
            Amethyst = PlayerData.gems[19],
            Prismarium = PlayerData.gems[20],
            Topaz = PlayerData.gems[21],
            Ruby = PlayerData.gems[22],
            Moonstone = PlayerData.gems[23],
            Sapphire = PlayerData.gems[24],
            Sunstone = PlayerData.gems[25],
            Emerald = PlayerData.gems[26],
            Bloodstone = PlayerData.gems[27],
            StarCrystal = PlayerData.gems[28],
            Diamond = PlayerData.gems[29],
            LuckPotion1 = PlayerData.potions[0],
            LuckPotion2 = PlayerData.potions[5],
            LuckPotion3 = PlayerData.potions[10],
            LuckPotion4 = PlayerData.potions[15],
            LuckPotion5 = PlayerData.potions[20],
            LuckPotion6 = PlayerData.potions[25],
            DefencePotion1 = PlayerData.potions[1],
            DefencePotion2 = PlayerData.potions[6],
            DefencePotion3 = PlayerData.potions[11],
            DefencePotion4 = PlayerData.potions[16],
            DefencePotion5 = PlayerData.potions[21],
            DefencePotion6 = PlayerData.potions[26],
            HealthPotion1 = PlayerData.potions[2],
            HealthPotion2 = PlayerData.potions[7],
            HealthPotion3 = PlayerData.potions[12],
            HealthPotion4 = PlayerData.potions[17],
            HealthPotion5 = PlayerData.potions[22],
            HealthPotion6 = PlayerData.potions[27],
            AttackPotion1 = PlayerData.potions[3],
            AttackPotion2 = PlayerData.potions[8],
            AttackPotion3 = PlayerData.potions[13],
            AttackPotion4 = PlayerData.potions[18],
            AttackPotion5 = PlayerData.potions[23],
            AttackPotion6 = PlayerData.potions[28],
            MagicPotion1 = PlayerData.potions[4],
            MagicPotion2 = PlayerData.potions[9],
            MagicPotion3 = PlayerData.potions[14],
            MagicPotion4 = PlayerData.potions[19],
            MagicPotion5 = PlayerData.potions[24],
            MagicPotion6 = PlayerData.potions[29],
            MarvelousPotion = PlayerData.potions[30],
            Clover = PlayerData.herbs[0],
            DaisyPetal = PlayerData.herbs[1],
            Holly = PlayerData.herbs[2],
            RoseThorn = PlayerData.herbs[3],
            IvySprig = PlayerData.herbs[4],
            Windrush = PlayerData.herbs[5],
            WillowTwig = PlayerData.herbs[6],
            Goosegrass = PlayerData.herbs[7],
            Firegrass = PlayerData.herbs[8],
            Moly = PlayerData.herbs[9],
            Starthistle = PlayerData.herbs[10],
            Knotweed = PlayerData.herbs[11],
            Bitterroot = PlayerData.herbs[12],
            Baneberry = PlayerData.herbs[13],
            MandrakeRoot = PlayerData.herbs[14],
            TawnymothWeed = PlayerData.herbs[15],
            Spleenwort = PlayerData.herbs[16],
            HelleboreSyrup = PlayerData.herbs[17],
            ValerianRoot = PlayerData.herbs[18],
            DragonIvy = PlayerData.herbs[19],
            Asphodel = PlayerData.herbs[20],
            Wormwood = PlayerData.herbs[21],
            Silverweed = PlayerData.herbs[22],
            Wolfsbane = PlayerData.herbs[23],
            Moondew = PlayerData.herbs[24],
            Fluxweed = PlayerData.herbs[25],
            Tormentil = PlayerData.herbs[26],
            Belladonna = PlayerData.herbs[27],
            Nightshade = PlayerData.herbs[28],
            Bloodroot = PlayerData.herbs[29],
            RubyApple = PlayerData.fruits[0],
            BloodOrange = PlayerData.fruits[1],
            CinderBanana = PlayerData.fruits[2],
            DewLemon = PlayerData.fruits[3],
            GoldenMango = PlayerData.fruits[4],
            WildNectarine = PlayerData.fruits[5]
        };
        string dataJSON = JsonUtility.ToJson(playerDataJSON);
        File.WriteAllText(dataFilePath, dataJSON);
        //Debug.Log("Data Written");
    }

    public void ResetData()
    {
        PlayerData.coins = 0;
        for (int i = 0; i < numArmour; i++)
        {
            PlayerData.armourTier[i] = 0;
        }
        for (int i = 0; i < numOres; i++)
        {
            PlayerData.ores[i] = 0;
        }
        for (int i = 0; i < numMetals; i++)
        {
            PlayerData.metals[i] = 0;
        }
        for (int i = 0; i < numGems; i++)
        {
            PlayerData.gems[i] = 0;
        }
        for (int i = 0; i < numPotions; i++)
        {
            PlayerData.potions[i] = 0;
        }
        for (int i = 0; i < numHerbs; i++)
        {
            PlayerData.herbs[i] = 0;
        }
        for (int i = 0; i < numFruits; i++)
        {
            PlayerData.fruits[i] = 0;
        }
        PlayerDataJSON playerDataJSON = new PlayerDataJSON()
        {
            Coins = PlayerData.coins,
            HelmTier = PlayerData.armourTier[0],
            ChestplateTier = PlayerData.armourTier[1],
            GauntletsTier = PlayerData.armourTier[2],
            LeggingsTier = PlayerData.armourTier[3],
            BootsTier = PlayerData.armourTier[4],
            ShieldTier = PlayerData.armourTier[5],
            WeaponTier = PlayerData.armourTier[6],
            PickaxeTier = PlayerData.armourTier[7],
            CopperOre = PlayerData.ores[0],
            TinOre = PlayerData.ores[1],
            IronOre = PlayerData.ores[2],
            CoalOre = PlayerData.ores[3],
            AluminiumOre = PlayerData.ores[4],
            NickelOre = PlayerData.ores[5],
            MagnesiumOre = PlayerData.ores[6],
            ZincOre = PlayerData.ores[7],
            LeadOre = PlayerData.ores[8],
            SilverOre = PlayerData.ores[9],
            GoldOre = PlayerData.ores[10],
            PlatinumOre = PlayerData.ores[11],
            ObsidianOre = PlayerData.ores[12],
            MeteoriteOre = PlayerData.ores[13],
            MithrilOre = PlayerData.ores[14],
            AdamanteusOre = PlayerData.ores[15],
            QuicksilverOre = PlayerData.ores[16],
            AetherOre = PlayerData.ores[17],
            CrimsoniteOre = PlayerData.ores[18],
            Copper = PlayerData.metals[0],
            Tin = PlayerData.metals[1],
            Bronze = PlayerData.metals[2],
            Iron = PlayerData.metals[3],
            Steel = PlayerData.metals[4],
            Aluminium = PlayerData.metals[5],
            Duralumin = PlayerData.metals[6],
            Nickel = PlayerData.metals[7],
            Invar = PlayerData.metals[8],
            Magnesium = PlayerData.metals[9],
            Hydronalium = PlayerData.metals[10],
            Zinc = PlayerData.metals[11],
            Brass = PlayerData.metals[12],
            Zamakium = PlayerData.metals[13],
            Lead = PlayerData.metals[14],
            WhiteMetal = PlayerData.metals[15],
            DamascusSteel = PlayerData.metals[16],
            Silver = PlayerData.metals[17],
            Gold = PlayerData.metals[18],
            RoseGold = PlayerData.metals[19],
            Elinvar = PlayerData.metals[20],
            Electrum = PlayerData.metals[21],
            CorinthianBronze = PlayerData.metals[22],
            Platinum = PlayerData.metals[23],
            RefinedObsidian = PlayerData.metals[24],
            Darksteel = PlayerData.metals[25],
            RefinedMeteorite = PlayerData.metals[26],
            MeteoricIron = PlayerData.metals[27],
            Shadowsteel = PlayerData.metals[28],
            MeteoricSteel = PlayerData.metals[29],
            Mithril = PlayerData.metals[30],
            MysticalSteel = PlayerData.metals[31],
            Adamanteus = PlayerData.metals[32],
            DivineSteel = PlayerData.metals[33],
            Quicksilver = PlayerData.metals[34],
            CelestialSteel = PlayerData.metals[35],
            Luminium = PlayerData.metals[36],
            Aether = PlayerData.metals[37],
            Etherium = PlayerData.metals[38],
            CosmicSteel = PlayerData.metals[39],
            Crimsonite = PlayerData.metals[40],
            SoulSteel = PlayerData.metals[41],
            Neutronium = PlayerData.metals[42],
            Orichalcum = PlayerData.metals[43],
            Infinitium = PlayerData.metals[44],
            Amber = PlayerData.gems[0],
            Quartz = PlayerData.gems[1],
            Opal = PlayerData.gems[2],
            Jade = PlayerData.gems[3],
            Cinnabar = PlayerData.gems[4],
            Ametrine = PlayerData.gems[5],
            SmokyQuartz = PlayerData.gems[6],
            Garnet = PlayerData.gems[7],
            Onyx = PlayerData.gems[8],
            Pyrite = PlayerData.gems[9],
            Heliodor = PlayerData.gems[10],
            Citrine = PlayerData.gems[11],
            RoseQuartz = PlayerData.gems[12],
            LapisLazuli = PlayerData.gems[13],
            Aquamarine = PlayerData.gems[14],
            Peridot = PlayerData.gems[15],
            Turquoise = PlayerData.gems[16],
            IcyQuartz = PlayerData.gems[17],
            Coralite = PlayerData.gems[18],
            Amethyst = PlayerData.gems[19],
            Prismarium = PlayerData.gems[20],
            Topaz = PlayerData.gems[21],
            Ruby = PlayerData.gems[22],
            Moonstone = PlayerData.gems[23],
            Sapphire = PlayerData.gems[24],
            Sunstone = PlayerData.gems[25],
            Emerald = PlayerData.gems[26],
            Bloodstone = PlayerData.gems[27],
            StarCrystal = PlayerData.gems[28],
            Diamond = PlayerData.gems[29],
            LuckPotion1 = PlayerData.potions[0],
            LuckPotion2 = PlayerData.potions[5],
            LuckPotion3 = PlayerData.potions[10],
            LuckPotion4 = PlayerData.potions[15],
            LuckPotion5 = PlayerData.potions[20],
            LuckPotion6 = PlayerData.potions[25],
            DefencePotion1 = PlayerData.potions[1],
            DefencePotion2 = PlayerData.potions[6],
            DefencePotion3 = PlayerData.potions[11],
            DefencePotion4 = PlayerData.potions[16],
            DefencePotion5 = PlayerData.potions[21],
            DefencePotion6 = PlayerData.potions[26],
            HealthPotion1 = PlayerData.potions[2],
            HealthPotion2 = PlayerData.potions[7],
            HealthPotion3 = PlayerData.potions[12],
            HealthPotion4 = PlayerData.potions[17],
            HealthPotion5 = PlayerData.potions[22],
            HealthPotion6 = PlayerData.potions[27],
            AttackPotion1 = PlayerData.potions[3],
            AttackPotion2 = PlayerData.potions[8],
            AttackPotion3 = PlayerData.potions[13],
            AttackPotion4 = PlayerData.potions[18],
            AttackPotion5 = PlayerData.potions[23],
            AttackPotion6 = PlayerData.potions[28],
            MagicPotion1 = PlayerData.potions[4],
            MagicPotion2 = PlayerData.potions[9],
            MagicPotion3 = PlayerData.potions[14],
            MagicPotion4 = PlayerData.potions[19],
            MagicPotion5 = PlayerData.potions[24],
            MagicPotion6 = PlayerData.potions[29],
            MarvelousPotion = PlayerData.potions[30],
            Clover = PlayerData.herbs[0],
            DaisyPetal = PlayerData.herbs[1],
            Holly = PlayerData.herbs[2],
            RoseThorn = PlayerData.herbs[3],
            IvySprig = PlayerData.herbs[4],
            Windrush = PlayerData.herbs[5],
            WillowTwig = PlayerData.herbs[6],
            Goosegrass = PlayerData.herbs[7],
            Firegrass = PlayerData.herbs[8],
            Moly = PlayerData.herbs[9],
            Starthistle = PlayerData.herbs[10],
            Knotweed = PlayerData.herbs[11],
            Bitterroot = PlayerData.herbs[12],
            Baneberry = PlayerData.herbs[13],
            MandrakeRoot = PlayerData.herbs[14],
            TawnymothWeed = PlayerData.herbs[15],
            Spleenwort = PlayerData.herbs[16],
            HelleboreSyrup = PlayerData.herbs[17],
            ValerianRoot = PlayerData.herbs[18],
            DragonIvy = PlayerData.herbs[19],
            Asphodel = PlayerData.herbs[20],
            Wormwood = PlayerData.herbs[21],
            Silverweed = PlayerData.herbs[22],
            Wolfsbane = PlayerData.herbs[23],
            Moondew = PlayerData.herbs[24],
            Fluxweed = PlayerData.herbs[25],
            Tormentil = PlayerData.herbs[26],
            Belladonna = PlayerData.herbs[27],
            Nightshade = PlayerData.herbs[28],
            Bloodroot = PlayerData.herbs[29],
            RubyApple = PlayerData.fruits[0],
            BloodOrange = PlayerData.fruits[1],
            CinderBanana = PlayerData.fruits[2],
            DewLemon = PlayerData.fruits[3],
            GoldenMango = PlayerData.fruits[4],
            WildNectarine = PlayerData.fruits[5]
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
            PlayerData.ores[i]++;
        }
        for (int i = 0; i < numMetals; i++)
        {
            PlayerData.metals[i]++;
        }
        for (int i = 0; i < numGems; i++)
        {
            PlayerData.gems[i]++;
        }
        for (int i = 0; i < numArmour; i++)
        {
            PlayerData.armourTier[i]++;
        }
        for (int i = 0; i < numPotions; i++)
        {
            PlayerData.potions[i]++;
        }
        for (int i = 0; i < numHerbs; i++)
        {
            PlayerData.herbs[i]++;
        }
        for (int i = 0; i < numFruits; i++)
        {
            PlayerData.fruits[i]++;
        }
        PlayerDataJSON playerDataJSON = new PlayerDataJSON()
        {
            Coins = PlayerData.coins,
            HelmTier = PlayerData.armourTier[0],
            ChestplateTier = PlayerData.armourTier[1],
            GauntletsTier = PlayerData.armourTier[2],
            LeggingsTier = PlayerData.armourTier[3],
            BootsTier = PlayerData.armourTier[4],
            ShieldTier = PlayerData.armourTier[5],
            WeaponTier = PlayerData.armourTier[6],
            PickaxeTier = PlayerData.armourTier[7],
            CopperOre = PlayerData.ores[0],
            TinOre = PlayerData.ores[1],
            IronOre = PlayerData.ores[2],
            CoalOre = PlayerData.ores[3],
            AluminiumOre = PlayerData.ores[4],
            NickelOre = PlayerData.ores[5],
            MagnesiumOre = PlayerData.ores[6],
            ZincOre = PlayerData.ores[7],
            LeadOre = PlayerData.ores[8],
            SilverOre = PlayerData.ores[9],
            GoldOre = PlayerData.ores[10],
            PlatinumOre = PlayerData.ores[11],
            ObsidianOre = PlayerData.ores[12],
            MeteoriteOre = PlayerData.ores[13],
            MithrilOre = PlayerData.ores[14],
            AdamanteusOre = PlayerData.ores[15],
            QuicksilverOre = PlayerData.ores[16],
            AetherOre = PlayerData.ores[17],
            CrimsoniteOre = PlayerData.ores[18],
            Copper = PlayerData.metals[0],
            Tin = PlayerData.metals[1],
            Bronze = PlayerData.metals[2],
            Iron = PlayerData.metals[3],
            Steel = PlayerData.metals[4],
            Aluminium = PlayerData.metals[5],
            Duralumin = PlayerData.metals[6],
            Nickel = PlayerData.metals[7],
            Invar = PlayerData.metals[8],
            Magnesium = PlayerData.metals[9],
            Hydronalium = PlayerData.metals[10],
            Zinc = PlayerData.metals[11],
            Brass = PlayerData.metals[12],
            Zamakium = PlayerData.metals[13],
            Lead = PlayerData.metals[14],
            WhiteMetal = PlayerData.metals[15],
            DamascusSteel = PlayerData.metals[16],
            Silver = PlayerData.metals[17],
            Gold = PlayerData.metals[18],
            RoseGold = PlayerData.metals[19],
            Elinvar = PlayerData.metals[20],
            Electrum = PlayerData.metals[21],
            CorinthianBronze = PlayerData.metals[22],
            Platinum = PlayerData.metals[23],
            RefinedObsidian = PlayerData.metals[24],
            Darksteel = PlayerData.metals[25],
            RefinedMeteorite = PlayerData.metals[26],
            MeteoricIron = PlayerData.metals[27],
            Shadowsteel = PlayerData.metals[28],
            MeteoricSteel = PlayerData.metals[29],
            Mithril = PlayerData.metals[30],
            MysticalSteel = PlayerData.metals[31],
            Adamanteus = PlayerData.metals[32],
            DivineSteel = PlayerData.metals[33],
            Quicksilver = PlayerData.metals[34],
            CelestialSteel = PlayerData.metals[35],
            Luminium = PlayerData.metals[36],
            Aether = PlayerData.metals[37],
            Etherium = PlayerData.metals[38],
            CosmicSteel = PlayerData.metals[39],
            Crimsonite = PlayerData.metals[40],
            SoulSteel = PlayerData.metals[41],
            Neutronium = PlayerData.metals[42],
            Orichalcum = PlayerData.metals[43],
            Infinitium = PlayerData.metals[44],
            Amber = PlayerData.gems[0],
            Quartz = PlayerData.gems[1],
            Opal = PlayerData.gems[2],
            Jade = PlayerData.gems[3],
            Cinnabar = PlayerData.gems[4],
            Ametrine = PlayerData.gems[5],
            SmokyQuartz = PlayerData.gems[6],
            Garnet = PlayerData.gems[7],
            Onyx = PlayerData.gems[8],
            Pyrite = PlayerData.gems[9],
            Heliodor = PlayerData.gems[10],
            Citrine = PlayerData.gems[11],
            RoseQuartz = PlayerData.gems[12],
            LapisLazuli = PlayerData.gems[13],
            Aquamarine = PlayerData.gems[14],
            Peridot = PlayerData.gems[15],
            Turquoise = PlayerData.gems[16],
            IcyQuartz = PlayerData.gems[17],
            Coralite = PlayerData.gems[18],
            Amethyst = PlayerData.gems[19],
            Prismarium = PlayerData.gems[20],
            Topaz = PlayerData.gems[21],
            Ruby = PlayerData.gems[22],
            Moonstone = PlayerData.gems[23],
            Sapphire = PlayerData.gems[24],
            Sunstone = PlayerData.gems[25],
            Emerald = PlayerData.gems[26],
            Bloodstone = PlayerData.gems[27],
            StarCrystal = PlayerData.gems[28],
            Diamond = PlayerData.gems[29],
            LuckPotion1 = PlayerData.potions[0],
            LuckPotion2 = PlayerData.potions[5],
            LuckPotion3 = PlayerData.potions[10],
            LuckPotion4 = PlayerData.potions[15],
            LuckPotion5 = PlayerData.potions[20],
            LuckPotion6 = PlayerData.potions[25],
            DefencePotion1 = PlayerData.potions[1],
            DefencePotion2 = PlayerData.potions[6],
            DefencePotion3 = PlayerData.potions[11],
            DefencePotion4 = PlayerData.potions[16],
            DefencePotion5 = PlayerData.potions[21],
            DefencePotion6 = PlayerData.potions[26],
            HealthPotion1 = PlayerData.potions[2],
            HealthPotion2 = PlayerData.potions[7],
            HealthPotion3 = PlayerData.potions[12],
            HealthPotion4 = PlayerData.potions[17],
            HealthPotion5 = PlayerData.potions[22],
            HealthPotion6 = PlayerData.potions[27],
            AttackPotion1 = PlayerData.potions[3],
            AttackPotion2 = PlayerData.potions[8],
            AttackPotion3 = PlayerData.potions[13],
            AttackPotion4 = PlayerData.potions[18],
            AttackPotion5 = PlayerData.potions[23],
            AttackPotion6 = PlayerData.potions[28],
            MagicPotion1 = PlayerData.potions[4],
            MagicPotion2 = PlayerData.potions[9],
            MagicPotion3 = PlayerData.potions[14],
            MagicPotion4 = PlayerData.potions[19],
            MagicPotion5 = PlayerData.potions[24],
            MagicPotion6 = PlayerData.potions[29],
            MarvelousPotion = PlayerData.potions[30],
            Clover = PlayerData.herbs[0],
            DaisyPetal = PlayerData.herbs[1],
            Holly = PlayerData.herbs[2],
            RoseThorn = PlayerData.herbs[3],
            IvySprig = PlayerData.herbs[4],
            Windrush = PlayerData.herbs[5],
            WillowTwig = PlayerData.herbs[6],
            Goosegrass = PlayerData.herbs[7],
            Firegrass = PlayerData.herbs[8],
            Moly = PlayerData.herbs[9],
            Starthistle = PlayerData.herbs[10],
            Knotweed = PlayerData.herbs[11],
            Bitterroot = PlayerData.herbs[12],
            Baneberry = PlayerData.herbs[13],
            MandrakeRoot = PlayerData.herbs[14],
            TawnymothWeed = PlayerData.herbs[15],
            Spleenwort = PlayerData.herbs[16],
            HelleboreSyrup = PlayerData.herbs[17],
            ValerianRoot = PlayerData.herbs[18],
            DragonIvy = PlayerData.herbs[19],
            Asphodel = PlayerData.herbs[20],
            Wormwood = PlayerData.herbs[21],
            Silverweed = PlayerData.herbs[22],
            Wolfsbane = PlayerData.herbs[23],
            Moondew = PlayerData.herbs[24],
            Fluxweed = PlayerData.herbs[25],
            Tormentil = PlayerData.herbs[26],
            Belladonna = PlayerData.herbs[27],
            Nightshade = PlayerData.herbs[28],
            Bloodroot = PlayerData.herbs[29],
            RubyApple = PlayerData.fruits[0],
            BloodOrange = PlayerData.fruits[1],
            CinderBanana = PlayerData.fruits[2],
            DewLemon = PlayerData.fruits[3],
            GoldenMango = PlayerData.fruits[4],
            WildNectarine = PlayerData.fruits[5]
        };
        string dataJSON = JsonUtility.ToJson(playerDataJSON);
        File.WriteAllText(dataFilePath, dataJSON);
    }
}