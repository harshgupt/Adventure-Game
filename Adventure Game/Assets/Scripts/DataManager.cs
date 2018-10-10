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
    public const int numOres = 9;
    public const int numMetals = 14;
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
    public int LeadOre;
    public int MithrilOre;
    public int AdamantineOre;
    public int QuicksilverOre;
    public int MeteoriteOre;
    public int Copper;
    public int Tin;
    public int Bronze;
    public int Iron;
    public int Lead;
    public int Steel;
    public int WhiteMetal;
    public int BlackMetal;
    public int Mithril;
    public int Adamantine;
    public int Quicksilver;
    public int Meteorite;
    public int MysticalMetal;
    public int InfinitiumMetal;

    //Potions
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
    public int DefencePotion1;
    public int DefencePotion2;
    public int DefencePotion3;
    public int DefencePotion4;
    public int DefencePotion5;
    public int DefencePotion6;
    public int MagicPotion1;
    public int MagicPotion2;
    public int MagicPotion3;
    public int MagicPotion4;
    public int MagicPotion5;
    public int MagicPotion6;
    public int LuckPotion1;
    public int LuckPotion2;
    public int LuckPotion3;
    public int LuckPotion4;
    public int LuckPotion5;
    public int LuckPotion6;
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
        CopperOre = PlayerData.ores[0];
        TinOre = PlayerData.ores[1];
        IronOre = PlayerData.ores[2];
        LeadOre = PlayerData.ores[3];
        CoalOre = PlayerData.ores[4];
        MithrilOre = PlayerData.ores[5];
        AdamantineOre = PlayerData.ores[6];
        QuicksilverOre = PlayerData.ores[7];
        MeteoriteOre = PlayerData.ores[8];
        Copper = PlayerData.metals[0];
        Tin = PlayerData.metals[1];
        Bronze = PlayerData.metals[2];
        Iron = PlayerData.metals[3];
        Lead = PlayerData.metals[4];
        Steel = PlayerData.metals[5];
        WhiteMetal = PlayerData.metals[6];
        BlackMetal = PlayerData.metals[7];
        Mithril = PlayerData.metals[8];
        Adamantine = PlayerData.metals[9];
        Quicksilver = PlayerData.metals[10];
        Meteorite = PlayerData.metals[11];
        MysticalMetal = PlayerData.metals[12];
        InfinitiumMetal = PlayerData.metals[13];
        HelmTier = PlayerData.armourTier[0];
        ChestplateTier = PlayerData.armourTier[1];
        GauntletsTier = PlayerData.armourTier[2];
        LeggingsTier = PlayerData.armourTier[3];
        BootsTier = PlayerData.armourTier[4];
        ShieldTier = PlayerData.armourTier[5];
        WeaponTier = PlayerData.armourTier[6];
        PickaxeTier = PlayerData.armourTier[7];
        HealthPotion1 = PlayerData.potions[0];
        HealthPotion2 = PlayerData.potions[1];
        HealthPotion3 = PlayerData.potions[2];
        HealthPotion4 = PlayerData.potions[3];
        HealthPotion5 = PlayerData.potions[4];
        HealthPotion6 = PlayerData.potions[5];
        AttackPotion1 = PlayerData.potions[6];
        AttackPotion2 = PlayerData.potions[7];
        AttackPotion3 = PlayerData.potions[8];
        AttackPotion4 = PlayerData.potions[9];
        AttackPotion5 = PlayerData.potions[10];
        AttackPotion6 = PlayerData.potions[11];
        DefencePotion1 = PlayerData.potions[12];
        DefencePotion2 = PlayerData.potions[13];
        DefencePotion3 = PlayerData.potions[14];
        DefencePotion4 = PlayerData.potions[15];
        DefencePotion5 = PlayerData.potions[16];
        DefencePotion6 = PlayerData.potions[17];
        MagicPotion1 = PlayerData.potions[18];
        MagicPotion2 = PlayerData.potions[19];
        MagicPotion3 = PlayerData.potions[20];
        MagicPotion4 = PlayerData.potions[21];
        MagicPotion5 = PlayerData.potions[22];
        MagicPotion6 = PlayerData.potions[23];
        LuckPotion1 = PlayerData.potions[24];
        LuckPotion2 = PlayerData.potions[25];
        LuckPotion3 = PlayerData.potions[26];
        LuckPotion4 = PlayerData.potions[27];
        LuckPotion5 = PlayerData.potions[28];
        LuckPotion6 = PlayerData.potions[29];
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
            PlayerData.ores[0] = loadedData.CopperOre;
            PlayerData.ores[1] = loadedData.TinOre;
            PlayerData.ores[2] = loadedData.IronOre;
            PlayerData.ores[3] = loadedData.LeadOre;
            PlayerData.ores[4] = loadedData.CoalOre;
            PlayerData.ores[5] = loadedData.MithrilOre;
            PlayerData.ores[6] = loadedData.AdamantineOre;
            PlayerData.ores[7] = loadedData.QuicksilverOre;
            PlayerData.ores[8] = loadedData.MeteoriteOre;
            PlayerData.metals[0] = loadedData.Copper;
            PlayerData.metals[1] = loadedData.Tin;
            PlayerData.metals[2] = loadedData.Bronze;
            PlayerData.metals[3] = loadedData.Iron;
            PlayerData.metals[4] = loadedData.Lead;
            PlayerData.metals[5] = loadedData.Steel;
            PlayerData.metals[6] = loadedData.WhiteMetal;
            PlayerData.metals[7] = loadedData.BlackMetal;
            PlayerData.metals[8] = loadedData.Mithril;
            PlayerData.metals[9] = loadedData.Adamantine;
            PlayerData.metals[10] = loadedData.Quicksilver;
            PlayerData.metals[11] = loadedData.Meteorite;
            PlayerData.metals[12] = loadedData.MysticalMetal;
            PlayerData.metals[13] = loadedData.InfinitiumMetal;
            PlayerData.armourTier[0] = loadedData.HelmTier;
            PlayerData.armourTier[1] = loadedData.ChestplateTier;
            PlayerData.armourTier[2] = loadedData.GauntletsTier;
            PlayerData.armourTier[3] = loadedData.LeggingsTier;
            PlayerData.armourTier[4] = loadedData.BootsTier;
            PlayerData.armourTier[5] = loadedData.ShieldTier;
            PlayerData.armourTier[6] = loadedData.WeaponTier;
            PlayerData.armourTier[7] = loadedData.PickaxeTier;
            PlayerData.potions[0] = loadedData.HealthPotion1;
            PlayerData.potions[1] = loadedData.HealthPotion2;
            PlayerData.potions[2] = loadedData.HealthPotion3;
            PlayerData.potions[3] = loadedData.HealthPotion4;
            PlayerData.potions[4] = loadedData.HealthPotion5;
            PlayerData.potions[5] = loadedData.HealthPotion6;
            PlayerData.potions[6] = loadedData.AttackPotion1;
            PlayerData.potions[7] = loadedData.AttackPotion2;
            PlayerData.potions[8] = loadedData.AttackPotion3;
            PlayerData.potions[9] = loadedData.AttackPotion4;
            PlayerData.potions[10] = loadedData.AttackPotion5;
            PlayerData.potions[11] = loadedData.AttackPotion6;
            PlayerData.potions[12] = loadedData.DefencePotion1;
            PlayerData.potions[13] = loadedData.DefencePotion2;
            PlayerData.potions[14] = loadedData.DefencePotion3;
            PlayerData.potions[15] = loadedData.DefencePotion4;
            PlayerData.potions[16] = loadedData.DefencePotion5;
            PlayerData.potions[17] = loadedData.DefencePotion6;
            PlayerData.potions[18] = loadedData.MagicPotion1;
            PlayerData.potions[19] = loadedData.MagicPotion2;
            PlayerData.potions[20] = loadedData.MagicPotion3;
            PlayerData.potions[21] = loadedData.MagicPotion4;
            PlayerData.potions[22] = loadedData.MagicPotion5;
            PlayerData.potions[23] = loadedData.MagicPotion6;
            PlayerData.potions[24] = loadedData.LuckPotion1;
            PlayerData.potions[25] = loadedData.LuckPotion2;
            PlayerData.potions[26] = loadedData.LuckPotion3;
            PlayerData.potions[27] = loadedData.LuckPotion4;
            PlayerData.potions[28] = loadedData.LuckPotion5;
            PlayerData.potions[29] = loadedData.LuckPotion6;
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
            CopperOre = PlayerData.ores[0],
            TinOre = PlayerData.ores[1],
            IronOre = PlayerData.ores[2],
            LeadOre = PlayerData.ores[3],
            CoalOre = PlayerData.ores[4],
            MithrilOre = PlayerData.ores[5],
            AdamantineOre = PlayerData.ores[6],
            QuicksilverOre = PlayerData.ores[7],
            MeteoriteOre = PlayerData.ores[8],
            Copper = PlayerData.metals[0],
            Tin = PlayerData.metals[1],
            Bronze = PlayerData.metals[2],
            Iron = PlayerData.metals[3],
            Lead = PlayerData.metals[4],
            Steel = PlayerData.metals[5],
            WhiteMetal = PlayerData.metals[6],
            BlackMetal = PlayerData.metals[7],
            Mithril = PlayerData.metals[8],
            Adamantine = PlayerData.metals[9],
            Quicksilver = PlayerData.metals[10],
            Meteorite = PlayerData.metals[11],
            MysticalMetal = PlayerData.metals[12],
            InfinitiumMetal = PlayerData.metals[13],
            HelmTier = PlayerData.armourTier[0],
            ChestplateTier = PlayerData.armourTier[1],
            GauntletsTier = PlayerData.armourTier[2],
            LeggingsTier = PlayerData.armourTier[3],
            BootsTier = PlayerData.armourTier[4],
            ShieldTier = PlayerData.armourTier[5],
            WeaponTier = PlayerData.armourTier[6],
            PickaxeTier = PlayerData.armourTier[7],
            HealthPotion1 = PlayerData.potions[0],
            HealthPotion2 = PlayerData.potions[1],
            HealthPotion3 = PlayerData.potions[2],
            HealthPotion4 = PlayerData.potions[3],
            HealthPotion5 = PlayerData.potions[4],
            HealthPotion6 = PlayerData.potions[5],
            AttackPotion1 = PlayerData.potions[6],
            AttackPotion2 = PlayerData.potions[7],
            AttackPotion3 = PlayerData.potions[8],
            AttackPotion4 = PlayerData.potions[9],
            AttackPotion5 = PlayerData.potions[10],
            AttackPotion6 = PlayerData.potions[11],
            DefencePotion1 = PlayerData.potions[12],
            DefencePotion2 = PlayerData.potions[13],
            DefencePotion3 = PlayerData.potions[14],
            DefencePotion4 = PlayerData.potions[15],
            DefencePotion5 = PlayerData.potions[16],
            DefencePotion6 = PlayerData.potions[17],
            MagicPotion1 = PlayerData.potions[18],
            MagicPotion2 = PlayerData.potions[19],
            MagicPotion3 = PlayerData.potions[20],
            MagicPotion4 = PlayerData.potions[21],
            MagicPotion5 = PlayerData.potions[22],
            MagicPotion6 = PlayerData.potions[23],
            LuckPotion1 = PlayerData.potions[24],
            LuckPotion2 = PlayerData.potions[25],
            LuckPotion3 = PlayerData.potions[26],
            LuckPotion4 = PlayerData.potions[27],
            LuckPotion5 = PlayerData.potions[28],
            LuckPotion6 = PlayerData.potions[29],
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
            CopperOre = PlayerData.ores[0],
            TinOre = PlayerData.ores[1],
            IronOre = PlayerData.ores[2],
            LeadOre = PlayerData.ores[3],
            CoalOre = PlayerData.ores[4],
            MithrilOre = PlayerData.ores[5],
            AdamantineOre = PlayerData.ores[6],
            QuicksilverOre = PlayerData.ores[7],
            MeteoriteOre = PlayerData.ores[8],
            Copper = PlayerData.metals[0],
            Tin = PlayerData.metals[1],
            Bronze = PlayerData.metals[2],
            Iron = PlayerData.metals[3],
            Lead = PlayerData.metals[4],
            Steel = PlayerData.metals[5],
            WhiteMetal = PlayerData.metals[6],
            BlackMetal = PlayerData.metals[7],
            Mithril = PlayerData.metals[8],
            Adamantine = PlayerData.metals[9],
            Quicksilver = PlayerData.metals[10],
            Meteorite = PlayerData.metals[11],
            MysticalMetal = PlayerData.metals[12],
            InfinitiumMetal = PlayerData.metals[13],
            HelmTier = PlayerData.armourTier[0],
            ChestplateTier = PlayerData.armourTier[1],
            GauntletsTier = PlayerData.armourTier[2],
            LeggingsTier = PlayerData.armourTier[3],
            BootsTier = PlayerData.armourTier[4],
            ShieldTier = PlayerData.armourTier[5],
            WeaponTier = PlayerData.armourTier[6],
            PickaxeTier = PlayerData.armourTier[7],
            HealthPotion1 = PlayerData.potions[0],
            HealthPotion2 = PlayerData.potions[1],
            HealthPotion3 = PlayerData.potions[2],
            HealthPotion4 = PlayerData.potions[3],
            HealthPotion5 = PlayerData.potions[4],
            HealthPotion6 = PlayerData.potions[5],
            AttackPotion1 = PlayerData.potions[6],
            AttackPotion2 = PlayerData.potions[7],
            AttackPotion3 = PlayerData.potions[8],
            AttackPotion4 = PlayerData.potions[9],
            AttackPotion5 = PlayerData.potions[10],
            AttackPotion6 = PlayerData.potions[11],
            DefencePotion1 = PlayerData.potions[12],
            DefencePotion2 = PlayerData.potions[13],
            DefencePotion3 = PlayerData.potions[14],
            DefencePotion4 = PlayerData.potions[15],
            DefencePotion5 = PlayerData.potions[16],
            DefencePotion6 = PlayerData.potions[17],
            MagicPotion1 = PlayerData.potions[18],
            MagicPotion2 = PlayerData.potions[19],
            MagicPotion3 = PlayerData.potions[20],
            MagicPotion4 = PlayerData.potions[21],
            MagicPotion5 = PlayerData.potions[22],
            MagicPotion6 = PlayerData.potions[23],
            LuckPotion1 = PlayerData.potions[24],
            LuckPotion2 = PlayerData.potions[25],
            LuckPotion3 = PlayerData.potions[26],
            LuckPotion4 = PlayerData.potions[27],
            LuckPotion5 = PlayerData.potions[28],
            LuckPotion6 = PlayerData.potions[29],
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
            CopperOre = PlayerData.ores[0],
            TinOre = PlayerData.ores[1],
            IronOre = PlayerData.ores[2],
            LeadOre = PlayerData.ores[3],
            CoalOre = PlayerData.ores[4],
            MithrilOre = PlayerData.ores[5],
            AdamantineOre = PlayerData.ores[6],
            QuicksilverOre = PlayerData.ores[7],
            MeteoriteOre = PlayerData.ores[8],
            Copper = PlayerData.metals[0],
            Tin = PlayerData.metals[1],
            Bronze = PlayerData.metals[2],
            Iron = PlayerData.metals[3],
            Lead = PlayerData.metals[4],
            Steel = PlayerData.metals[5],
            WhiteMetal = PlayerData.metals[6],
            BlackMetal = PlayerData.metals[7],
            Mithril = PlayerData.metals[8],
            Adamantine = PlayerData.metals[9],
            Quicksilver = PlayerData.metals[10],
            Meteorite = PlayerData.metals[11],
            MysticalMetal = PlayerData.metals[12],
            InfinitiumMetal = PlayerData.metals[13],
            HelmTier = PlayerData.armourTier[0],
            ChestplateTier = PlayerData.armourTier[1],
            GauntletsTier = PlayerData.armourTier[2],
            LeggingsTier = PlayerData.armourTier[3],
            BootsTier = PlayerData.armourTier[4],
            ShieldTier = PlayerData.armourTier[5],
            WeaponTier = PlayerData.armourTier[6],
            PickaxeTier = PlayerData.armourTier[7],
            HealthPotion1 = PlayerData.potions[0],
            HealthPotion2 = PlayerData.potions[1],
            HealthPotion3 = PlayerData.potions[2],
            HealthPotion4 = PlayerData.potions[3],
            HealthPotion5 = PlayerData.potions[4],
            HealthPotion6 = PlayerData.potions[5],
            AttackPotion1 = PlayerData.potions[6],
            AttackPotion2 = PlayerData.potions[7],
            AttackPotion3 = PlayerData.potions[8],
            AttackPotion4 = PlayerData.potions[9],
            AttackPotion5 = PlayerData.potions[10],
            AttackPotion6 = PlayerData.potions[11],
            DefencePotion1 = PlayerData.potions[12],
            DefencePotion2 = PlayerData.potions[13],
            DefencePotion3 = PlayerData.potions[14],
            DefencePotion4 = PlayerData.potions[15],
            DefencePotion5 = PlayerData.potions[16],
            DefencePotion6 = PlayerData.potions[17],
            MagicPotion1 = PlayerData.potions[18],
            MagicPotion2 = PlayerData.potions[19],
            MagicPotion3 = PlayerData.potions[20],
            MagicPotion4 = PlayerData.potions[21],
            MagicPotion5 = PlayerData.potions[22],
            MagicPotion6 = PlayerData.potions[23],
            LuckPotion1 = PlayerData.potions[24],
            LuckPotion2 = PlayerData.potions[25],
            LuckPotion3 = PlayerData.potions[26],
            LuckPotion4 = PlayerData.potions[27],
            LuckPotion5 = PlayerData.potions[28],
            LuckPotion6 = PlayerData.potions[29],
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