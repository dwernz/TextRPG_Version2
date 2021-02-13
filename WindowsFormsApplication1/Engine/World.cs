using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        // Create readonly Lists of Items, Monsters, Quests, Locations, Spells
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();
        public static readonly List<Spell> Spells = new List<Spell>();

        public const int UNSELLABLE_ITEM_PRICE = -1;

        // Item IDs
        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;
        public const int ITEM_ID_IRON_SWORD = 11;
        public const int ITEM_ID_WOLF_PELT = 12;
        public const int ITEM_ID_TORCH = 13;
        public const int ITEM_ID_SPRING_WATER = 14;
        public const int ITEM_ID_BONES = 15;
        public const int ITEM_ID_BAT_WINGS = 16;
        public const int ITEM_ID_ROC_FEATHER = 17;
        public const int ITEM_ID_ROC_BEAK = 18;
        public const int ITEM_ID_STEEL_SWORD = 19;
        public const int ITEM_ID_TROLLS_BLOOD = 20;
        public const int ITEM_ID_ARIADNES_THREAD = 21;
        public const int ITEM_ID_BASILISKS_KEY = 22;
        public const int ITEM_ID_HYDRA_FIRE = 23;
        public const int ITEM_ID_GRAVEYARD_KEY = 24;
        public const int ITEM_ID_CENTAURS_PASS = 25;
        public const int ITEM_ID_DRAGON_KEY = 26;
        public const int ITEM_ID_EXCALIBUR = 27;
        public const int ITEM_ID_MINOTAUR_HORN = 28;
        public const int ITEM_ID_BASILISK_POISON = 29;
        public const int ITEM_ID_HYDRA_HEAD = 30;
        public const int ITEM_ID_LICH_KING_STAFF = 31;
        public const int ITEM_ID_CHARONS_BOAT = 32;
        public const int ITEM_ID_CERBERUSS_COLLAR = 33;
        public const int ITEM_ID_DEMON_LORD_AMULET = 34;
        public const int ITEM_ID_KOBOLD_PICKAXE = 35;
        public const int ITEM_ID_DRAGON_SCALE = 36;
        public const int ITEM_ID_CASTLE_KEY = 37;
        public const int ITEM_ID_DURANDAL = 38;
        public const int ITEM_ID_MYSTIC_ELIXIR = 39;
        public const int ITEM_ID_CARNWENNAN = 40;
        public const int ITEM_ID_BRIONNAC = 41;
        public const int ITEM_ID_TYRFING = 42;
        public const int ITEM_ID_GUNGNIR = 43;
        public const int ITEM_ID_DROP_OF_IMMORTALITY = 44;
        public const int ITEM_ID_VIAL_OF_IMMORTALITY = 45;
        public const int ITEM_ID_DEMONS_SEAL = 46;
        public const int ITEM_ID_WYVERNS_CLAWS = 47;
        public const int ITEM_ID_WORN_HELMET = 48;
        public const int ITEM_ID_WORN_SHIRT = 49;
        public const int ITEM_ID_WORN_PANTS = 50;
        public const int ITEM_ID_WORN_BOOTS = 51;
        public const int ITEM_ID_WORN_GLOVES = 52;
        public const int ITEM_ID_CLOTH_HAT = 53;
        public const int ITEM_ID_CLOTH_SHIRT = 54;
        public const int ITEM_ID_CLOTH_PANTS = 55;
        public const int ITEM_ID_CLOTH_SHOES = 56;
        public const int ITEM_ID_CLOTH_GLOVES = 57;
        public const int ITEM_ID_LEATHER_HAT = 58;
        public const int ITEM_ID_LEATHER_VEST = 59;
        public const int ITEM_ID_LEATHER_PANTS = 60;
        public const int ITEM_ID_LEATHER_BOOTS = 61;
        public const int ITEM_ID_LEATHER_GLOVES = 62;
        public const int ITEM_ID_BRONZE_HELMET = 63;
        public const int ITEM_ID_BRONZE_CHESTPLATE = 64;
        public const int ITEM_ID_BRONZE_LEGGINGS = 65;
        public const int ITEM_ID_BRONZE_BOOTS = 66;
        public const int ITEM_ID_BRONZE_GAUNTLETS = 67;
        public const int ITEM_ID_IRON_HELMET = 68;
        public const int ITEM_ID_IRON_CHESTPLATE = 69;
        public const int ITEM_ID_IRON_LEGGINGS = 70;
        public const int ITEM_ID_IRON_BOOTS = 71;
        public const int ITEM_ID_IRON_GAUNTLETS = 72;
        public const int ITEM_ID_STEEL_HELMET = 73;
        public const int ITEM_ID_STEEL_CHESTPLATE = 74;
        public const int ITEM_ID_STEEL_LEGGINGS = 75;
        public const int ITEM_ID_STEEL_BOOTS = 76;
        public const int ITEM_ID_STEEL_GAUNTLETS = 77;
        public const int ITEM_ID_MITHRIL_HELMET = 78;
        public const int ITEM_ID_MITHRIL_CHESTPLATE = 79;
        public const int ITEM_ID_MITHRIL_LEGGINGS = 80;
        public const int ITEM_ID_MITHRIL_BOOTS = 81;
        public const int ITEM_ID_MITHRIL_GAUNTLETS = 82;
        public const int ITEM_ID_ADAMANTIUM_HELMET = 83;
        public const int ITEM_ID_ADAMANTIUM_CHESTPLATE = 84;
        public const int ITEM_ID_ADAMANTIUM_LEGGINGS = 85;
        public const int ITEM_ID_ADAMANTIUM_BOOTS = 86;
        public const int ITEM_ID_ADAMANTIUM_GAUNTLETS = 87;
        public const int ITEM_ID_PAVRANIUM_HELMET = 88;
        public const int ITEM_ID_PAVRANIUM_CHESTPLATE = 89;
        public const int ITEM_ID_PAVRANIUM_LEGGINS = 90;
        public const int ITEM_ID_PAVRANIUM_BOOTS = 91;
        public const int ITEM_ID_PAVRANIUM_GAUNTLETS = 92;

        // Monster IDs
        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;
        public const int MONSTER_ID_WOLF = 4;
        public const int MONSTER_ID_GOBLIN = 5;
        public const int MONSTER_ID_ROC = 6;
        public const int MONSTER_ID_BAT = 7;
        public const int MONSTER_ID_TROLL = 8;
        public const int MONSTER_ID_UNDEAD = 9;
        public const int MONSTER_ID_WEREWOLF = 10;
        public const int MONSTER_ID_CENTAUR = 11;
        public const int MONSTER_ID_DRAGON = 12;
        public const int MONSTER_ID_KOBOLD = 13;
        public const int MONSTER_ID_BANSHEE = 14;
        public const int MONSTER_ID_LICH_KING = 15;
        public const int MONSTER_ID_BASILISK = 16;
        public const int MONSTER_ID_CERBERUS = 17;
        public const int MONSTER_ID_DEMON = 18;
        public const int MONSTER_ID_DEMON_LORD = 19;
        public const int MONSTER_ID_WYVERN = 20;
        public const int MONSTER_ID_HYDRA = 21;
        public const int MONSTER_ID_MINOTAUR = 22;
        public const int MONSTER_ID_NAGA = 23;

        // Quest IDs
        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
        public const int QUEST_ID_SPIDER_FIELD = 3;
        public const int QUEST_ID_AVENGE_THE_VILLAGERS = 4;
        public const int QUEST_ID_CLEAR_THUNDERING_HEIGHTS = 5;
        public const int QUEST_ID_SLAY_THE_MINOTAUR = 6;
        public const int QUEST_ID_SLAY_THE_HYDRA = 7;
        public const int QUEST_ID_BEAT_CERBERUS = 8;
        public const int QUEST_ID_DEFEAT_THE_DEMON_LORD = 9;
        public const int QUEST_ID_STOP_THE_LICH_KING = 10;
        public const int QUEST_ID_SLAY_BASILISK = 11;
        public const int QUEST_ID_BEAT_THE_DRAGON = 12;
        public const int QUEST_ID_CLEAR_UNDERWORLD = 13;
        public const int QUEST_ID_CLEAR_DRAKE_HIGHLANDS = 14;
        public const int QUEST_ID_CLEAR_KOBOLD_MINE = 15;

        // Location IDs
        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMIST_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;
        public const int LOCATION_ID_DEEP_FOREST = 10;
        public const int LOCATION_ID_THUNDERING_HEIGHTS_BASE = 11;
        public const int LOCATION_ID_THUNDERING_HEIGHTS_SUMMIT = 12;
        public const int LOCATION_ID_THE_RELENTLESS_HOLLOW_ENTRANCE = 13;
        public const int LOCATION_ID_THE_RELENTLESS_HOLLOW = 14;
        public const int LOCATION_ID_THE_RELENTLESS_HOLLOW_SPRING = 15;
        public const int LOCATION_ID_LABYRINTH = 16;
        public const int LOCATION_ID_LABYRINTH_DEEP = 17;
        public const int LOCATION_ID_LABYRINTH_DEAD_END = 18;
        public const int LOCATION_ID_MINOTAURS_LAIR = 19;
        public const int LOCATION_ID_BASILISKS_CHAMBERS = 20;
        public const int LOCATION_ID_MYSTIC_LAKE = 21;
        public const int LOCATION_ID_HYDRA_LAIR = 22;
        public const int LOCATION_ID_CENTAURS_FOREST = 23;
        public const int LOCATION_ID_ETERNAL_NIGHT_FOREST = 24;
        public const int LOCATION_ID_DRAKE_HIGHLANDS_BASE = 25;
        public const int LOCATION_ID_DRAKE_HIGHLANDS = 26;
        public const int LOCATION_ID_KOBOLDS_MINE = 27;
        public const int LOCATION_ID_DRAGONS_LAIR = 28;
        public const int LOCATION_ID_CATACOMBS = 29;
        public const int LOCATION_ID_CRYPT = 30;
        public const int LOCATION_ID_GRAVEYARD = 31;
        public const int LOCATION_ID_GATES_TO_UNDERWORLD = 32;
        public const int LOCATION_ID_UNDERWORLD = 33;
        public const int LOCATION_ID_DEMON_LORDS_CASTLE = 34;
        public const int LOCATION_ID_LABYRINTH_ENTRANCE = 35;

        // Spell IDs
        public const int SPELL_ID_FIREBOLT = 1;
        public const int SPELL_ID_ICEBOLT = 2;
        public const int SPELL_ID_LIGHTNINGBOLT = 3;
        public const int SPELL_ID_ROCK_BULLET = 4;
        public const int SPELL_ID_FIREBALL = 5;
        public const int SPELL_ID_ICE_SPEAR = 6;
        public const int SPELL_ID_THUNDER = 7;
        public const int SPELL_ID_GOLEMS_STRIKE = 8;
        public const int SPELL_ID_METEOR = 9;
        public const int SPELL_ID_HAIL_STORM = 10;
        public const int SPELL_ID_LIGHTNING_ROD = 11;
        public const int SPELL_ID_GRAVITY_CRUSH = 12;

        // Populate the World
        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
            PopulateSpells();
        }

        private static void PopulateItems()
        {
            // Item(id, name, namePlural, price)
            // Weapon(id, name, namePlural, minimumDamage, maximumDamage, price)
            // HealingPotion(id, name, namePlural, pointsToHeal, price)
            // Armor(id, name, namePlural, minimumDefense, maximumDefense, price)
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty Sword", "Rusty Swords", 0, 5, 5));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat Tail", "Rat Tails", 1));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of Fur", "Pieces of Fur", 1));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake Fang", "Snake Fangs", 1));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins", 1));
            Items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 3, 8, 8));
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing Potion", "Healing Potions", 5, 3));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider Fang", "Spider Fangs", 1));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider Silk", "Spider Silks", 1));
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer Pass", "Adventurer Passes", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Weapon(ITEM_ID_IRON_SWORD, "Iron Sword", "Iron Swords", 5, 15, 15));
            Items.Add(new Item(ITEM_ID_WOLF_PELT, "Wolf Pelt", "Wolf Pelts", 5));
            Items.Add(new Item(ITEM_ID_TORCH, "Torch", "Torches", UNSELLABLE_ITEM_PRICE));
            Items.Add(new HealingPotion(ITEM_ID_SPRING_WATER,
                "Spring Water", "Spring Waters", 200, 20));
            Items.Add(new Item(ITEM_ID_BONES, "Bone", "Bones", 5));
            Items.Add(new Item(ITEM_ID_BAT_WINGS, "Bat Wing", "Bat Wings", 3));
            Items.Add(new Item(ITEM_ID_ROC_FEATHER, "Roc Feather", "Roc Feathers", 3));
            Items.Add(new Item(ITEM_ID_ROC_BEAK, "Roc Beak", "Roc Beaks", 3));
            Items.Add(new Weapon(ITEM_ID_STEEL_SWORD, "Steel Sword", "Steel Swords", 10, 25, 30));
            Items.Add(new Item(ITEM_ID_TROLLS_BLOOD, "Troll's Blood", "Troll's Blood", 10));
            Items.Add(new Item(ITEM_ID_ARIADNES_THREAD, "Ariadne's Thread", "Ariadne's Threads", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Item(ITEM_ID_BASILISKS_KEY, "Basilisk's Key", "Basilisk's Keys", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Item(ITEM_ID_HYDRA_FIRE, "Hydra Fire", "Hydra Fires", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Item(ITEM_ID_GRAVEYARD_KEY, "Graveyard Key", "Graveyard Keys", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Item(ITEM_ID_CENTAURS_PASS, "Centaur's Pass", "Centaur's Passes", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Item(ITEM_ID_DRAGON_KEY, "Dragon Key", "Dragon Keys", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Weapon(ITEM_ID_EXCALIBUR, "Excalibur", "Excaliburs", 5000, 5000, UNSELLABLE_ITEM_PRICE));
            Items.Add(new Item(ITEM_ID_MINOTAUR_HORN, "Minotaur Horn", "Minotaur Horns", 25));
            Items.Add(new Item(ITEM_ID_BASILISK_POISON, "Basilisk's Poison", "Basilisk's Poison", 30));
            Items.Add(new Item(ITEM_ID_HYDRA_HEAD, "Hydra Head", "Hydra Heads", 20));
            Items.Add(new Item(ITEM_ID_LICH_KING_STAFF, "Lich King's Staff", "Lich King's Staves", 35));
            Items.Add(new Item(ITEM_ID_CHARONS_BOAT, "Charon's Boat", "Charon's Boats", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Item(ITEM_ID_CERBERUSS_COLLAR, "Cerberus's Collar", "Cerberus's Collars", 40));
            Items.Add(new Item(ITEM_ID_DEMON_LORD_AMULET, "Demon Lord's Amulet", "Demon Lord's Amulets", 50));
            Items.Add(new Item(ITEM_ID_KOBOLD_PICKAXE, "Kobold Pickaxe", "Kobold Pickaxes", 50));
            Items.Add(new Item(ITEM_ID_DRAGON_SCALE, "Dragon Scale", "Dragon Scales", 60));
            Items.Add(new Item(ITEM_ID_CASTLE_KEY, "Castle Key", "Castle Keys", UNSELLABLE_ITEM_PRICE));
            Items.Add(new Weapon(ITEM_ID_DURANDAL, "Durandal", "Durandals", 50, 100, UNSELLABLE_ITEM_PRICE));
            Items.Add(new HealingPotion(ITEM_ID_MYSTIC_ELIXIR,
                "Mystic Elixir", "Mystic Elixirs", 500, 50));
            Items.Add(new Weapon(ITEM_ID_CARNWENNAN, "Carnwennan", "Carnweannans", 100, 200, 100));
            Items.Add(new Weapon(ITEM_ID_BRIONNAC, "Brionnac", "Brionnacs", 400, 800, 1000));
            Items.Add(new Weapon(ITEM_ID_TYRFING, "Tyrfing", "Tyrfings", 200, 400, 500));
            Items.Add(new Weapon(ITEM_ID_GUNGNIR, "Gungnir", "Gungnirs", 600, 900, 2000));
            Items.Add(new HealingPotion(ITEM_ID_DROP_OF_IMMORTALITY, "Drop of Immortality", "Drops of Immortality", 1000, 200));
            Items.Add(new HealingPotion(ITEM_ID_VIAL_OF_IMMORTALITY, "Vial of Immortality", "Vials of Immortality", 5000, 500));
            Items.Add(new Item(ITEM_ID_DEMONS_SEAL, "Demon's Seal", "Demon's Seals", 20));
            Items.Add(new Item(ITEM_ID_WYVERNS_CLAWS, "Wyvern Claw", "Wyvern Claws", 25));
            Items.Add(new Armor(ITEM_ID_WORN_HELMET, "Worn Helmet", "Worn Helmets", 0, 1, "Head", 1));
            Items.Add(new Armor(ITEM_ID_WORN_SHIRT, "Worn Shirt", "Worn Shirts", 0, 1, "Chest", 1));
            Items.Add(new Armor(ITEM_ID_WORN_PANTS, "Worn Pants", "Worn Pants", 0, 1, "Legs", 1));
            Items.Add(new Armor(ITEM_ID_WORN_BOOTS, "Worn Boots", "Worn Boots", 0, 1, "Feet", 1));
            Items.Add(new Armor(ITEM_ID_WORN_GLOVES, "Worn Gloves", "Worn Gloves", 0, 1, "Hands", 1));
            Items.Add(new Armor(ITEM_ID_CLOTH_HAT, "Cloth Hat", "Cloth Hats", 1, 2, "Head", 3));
            Items.Add(new Armor(ITEM_ID_CLOTH_SHIRT, "Cloth Shirt", "Cloth Shirts", 1, 2, "Chest", 3));
            Items.Add(new Armor(ITEM_ID_CLOTH_PANTS, "Cloth Pants", "Cloth Pants", 1, 2, "Legs", 3));
            Items.Add(new Armor(ITEM_ID_CLOTH_SHOES, "Cloth Shoes", "Cloth Shoes", 1, 2, "Feet", 3));
            Items.Add(new Armor(ITEM_ID_CLOTH_GLOVES, "Cloth Gloves", "Cloth Gloves", 1, 2, "Hands", 3));
            Items.Add(new Armor(ITEM_ID_LEATHER_HAT, "Leather Hat", "Leather Hats", 2, 3, "Head", 10));
            Items.Add(new Armor(ITEM_ID_LEATHER_VEST, "Leather Vest", "Leather Vests", 4, 6, "Chest", 10));
            Items.Add(new Armor(ITEM_ID_LEATHER_PANTS, "Leather Pants", "Leather Pants", 3, 5, "Legs", 10));
            Items.Add(new Armor(ITEM_ID_LEATHER_GLOVES, "Leather Gloves", "Leather Gloves", 3, 5, "Hands", 10));
            Items.Add(new Armor(ITEM_ID_LEATHER_BOOTS, "Leather Boots", "Leather Boots", 2, 4, "Feet", 10));
        }

        private static void PopulateMonsters()
        {
            // Monster(id, name, maxDamage, rewardExperiencePoints, rewardGold, currentHitPoints, maximumHitPoints
            // Create rat Monster
            // rat has rat tail and piece of fur drops
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            // Create snake Monster
            // snake has snake fang and snakeskin drops
            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

            // Create giantSpider Monster
            // giantSpider has spider fang and spider silk drops
            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER,
                "Giant Spider", 20, 5, 40, 20
                , 20);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            // Create wolf Monster object and add Wolf Pelt to LootTable
            Monster wolf = new Monster(MONSTER_ID_WOLF,
                "Wolf", 10, 5, 5, 25, 25);
            wolf.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_WOLF_PELT), 50, true));

            // Create goblin Monster and add Spring Water and bones to LootTable
            Monster goblin = new Monster(MONSTER_ID_GOBLIN,
                "Goblin", 20, 5, 10, 50, 50);
            goblin.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_BONES), 50, true));
            goblin.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_SPRING_WATER), 25, false));
            goblin.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_STEEL_SWORD), 5, false));

            // Create bat Monster and add Bat wings to LootTable
            Monster bat = new Monster(MONSTER_ID_BAT,
                "Bat", 5, 3, 5, 30, 30);
            bat.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_BAT_WINGS), 80, true));

            // Create roc Monster and add Roc Feather and Roc Beak to LootTable
            Monster roc = new Monster(MONSTER_ID_ROC,
                "Roc", 10, 5, 5, 50, 50);
            roc.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_ROC_FEATHER), 75, true));
            roc.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_ROC_BEAK), 25, false));

            // Create troll Monster
            Monster troll = new Monster(MONSTER_ID_TROLL,
                "Troll", 50, 20, 20, 200, 200);
            troll.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_TROLLS_BLOOD), 10, true));
            troll.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_CLUB), 5, false));

            // Create undead Monster
            Monster undead = new Monster(MONSTER_ID_UNDEAD,
                "Undead", 80, 10, 10, 300, 300);

            // Create Werewolf
            Monster werewolf = new Monster(MONSTER_ID_WEREWOLF,
                "Werewolf", 180, 8, 3, 500, 500);
            werewolf.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_VIAL_OF_IMMORTALITY), 25, false));

            // Create Centaur
            Monster centaur = new Monster(MONSTER_ID_CENTAUR,
                "Centaur", 175, 8, 5, 500, 500);

            // Create Dragon
            Monster dragon = new Monster(MONSTER_ID_DRAGON,
                "Dragon", 500, 25, 50, 2000, 2000);
            dragon.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_DRAGON_SCALE), 50, true));

            // Create kobold Monster
            Monster kobold = new Monster(MONSTER_ID_KOBOLD,
                "Kobold", 200, 10, 5, 600, 600);
            kobold.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_KOBOLD_PICKAXE), 50, true));

            // Create banshee Monster
            Monster banshee = new Monster(MONSTER_ID_BANSHEE,
                "Banshee", 100, 10, 10, 350, 350);
            banshee.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_DROP_OF_IMMORTALITY), 50, false));

            // Create lichKing Monster
            Monster lichKing = new Monster(MONSTER_ID_LICH_KING,
                "Lich King", 150, 20, 15, 350, 350);
            lichKing.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_LICH_KING_STAFF), 50, true));

            // Create Basilisk Monster
            Monster basilisk = new Monster(MONSTER_ID_BASILISK,
                "Basilisk", 80, 20, 15, 350, 350);
            basilisk.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_BASILISK_POISON), 50, true));

            // Create cerberus Monster
            Monster cerberus = new Monster(MONSTER_ID_CERBERUS,
                "Cerberus", 175, 10, 20, 550, 550);
            cerberus.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_CERBERUSS_COLLAR), 50, true));

            // Create demon Monster
            Monster demon = new Monster(MONSTER_ID_DEMON,
                "Demon", 150, 10, 15, 500, 500);
            demon.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_DEMONS_SEAL), 75, true));

            // Create demonLord Monster
            Monster demonLord = new Monster(MONSTER_ID_DEMON_LORD,
                "Demon Lord", 200, 20, 30, 600, 600);
            demonLord.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_DEMON_LORD_AMULET), 50, false));

            // Create Wyvern Monster
            Monster wyvern = new Monster(MONSTER_ID_WYVERN,
                "Wyvern", 200, 10, 15, 600, 600);
            wyvern.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_WYVERNS_CLAWS), 50, true));

            // Create Hydra Monster
            Monster hydra = new Monster(MONSTER_ID_HYDRA,
                "Hydra", 100, 20, 20, 400, 400);
            hydra.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_HYDRA_HEAD), 50, true));


            // Create minotaur Monster
            Monster minotaur = new Monster(MONSTER_ID_MINOTAUR,
                "Minotaur", 75, 20, 20, 300, 300);
            minotaur.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_MINOTAUR_HORN), 50, true));

            // Create naga Monster
            Monster naga = new Monster(MONSTER_ID_NAGA,
                "Naga", 75, 10, 20, 300, 300);
            naga.LootTable.Add(new LootItem(
                ItemByID(ITEM_ID_MYSTIC_ELIXIR), 50, false));

            // Add Monsters to static list
            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantSpider);
            Monsters.Add(wolf);
            Monsters.Add(goblin);
            Monsters.Add(bat);
            Monsters.Add(roc);
            Monsters.Add(troll);
            Monsters.Add(undead);
            Monsters.Add(werewolf);
            Monsters.Add(centaur);
            Monsters.Add(dragon);
            Monsters.Add(kobold);
            Monsters.Add(banshee);
            Monsters.Add(lichKing);
            Monsters.Add(basilisk);
            Monsters.Add(cerberus);
            Monsters.Add(demon);
            Monsters.Add(demonLord);
            Monsters.Add(wyvern);
            Monsters.Add(hydra);
            Monsters.Add(minotaur);
            Monsters.Add(naga);
        }

        private static void PopulateQuests()
        {
            // Create clearAlchemistGarden quest
            Quest clearAlchemistGarden = new Quest(QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                "Clear the Alchemist's Garden",
                "Kill rats in the Alchemist's Garden and bring back 3 rat tails. You will receive a healing potion and 10 gold pieces.", 20, 10);

            // clearAlchemistGarden QuestCompletionItems
            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(
                ItemByID(ITEM_ID_RAT_TAIL), 3));

            // clearAlchemistGarden RewardItems
            clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            // Create clearFarmersField Quest
            Quest clearFarmersField = new Quest(QUEST_ID_CLEAR_FARMERS_FIELD,
                "Clear the Farmer's Field",
                "Kill snakes in the farmer's field and bring back 3 snake fangs. You will receive an adventurer pass and 20 gold pieces.", 20, 20);

            // clearFarmersField QuestCompletionItems
            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(
                ItemByID(ITEM_ID_SNAKE_FANG), 3));

            // clearFarmersField RewardItems
            clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

            // create clearForest quest object
            Quest clearForest = new Quest(QUEST_ID_SPIDER_FIELD,
                "Clear the Forest of Spiders",
                "Kill Giant Spiders in the Forest and bring back 3 Spider Silks. You will receive a Iron Sword and 50 gold pieces.", 100, 50);

            // clearForest CompletionItems
            clearForest.QuestCompletionItems.Add(new QuestCompletionItem(
                ItemByID(ITEM_ID_SPIDER_SILK), 3));

            // clearForest RewardItem
            clearForest.RewardItem = ItemByID(ITEM_ID_IRON_SWORD);

            // create avengeVillagers quest object
            Quest avengeVillagers = new Quest(QUEST_ID_AVENGE_THE_VILLAGERS,
                "Avenge the Villagers",
                "Kill Goblins in the depths of The Relentless Hollow and bring back 10 bones. You will receive a Labyrinth Key and 100 gold pieces,", 100, 100);

            // avengeVillagers CompletionItems
            avengeVillagers.QuestCompletionItems.Add(new QuestCompletionItem(
                ItemByID(ITEM_ID_BONES), 10));

            // avengeVillagers RewardItem
            avengeVillagers.RewardItem = ItemByID(ITEM_ID_ARIADNES_THREAD);

            // create slayRocs quest object
            Quest slayRocs = new Quest(QUEST_ID_CLEAR_THUNDERING_HEIGHTS,
                "Clear the Thundering Heights",
                "The Roc population is growing, the villagers are worried they will be attacked. Slay the Rocs and bring back 5 Roc Beaks. You will receive a torch and 50 gold pieces.", 50, 50);

            // slayRoc CompletionItems
            slayRocs.QuestCompletionItems.Add(new QuestCompletionItem(
                ItemByID(ITEM_ID_ROC_BEAK), 5));

            // slayRoc RewardItem
            slayRocs.RewardItem = ItemByID(ITEM_ID_TORCH);

            // Create slayMinotaur quest object
            Quest slayMinotaur = new Quest(QUEST_ID_SLAY_THE_MINOTAUR,
                "Slay the legendary Minotaur", "The Minotaur of legend resides within the Labyrinth. Slay it and collect 3 horns. Rewards Key to the Basilisk's Chambers.", 50, 50);

            // slayMinotaur CompletionItems
            slayMinotaur.QuestCompletionItems.Add(new QuestCompletionItem(
                ItemByID(ITEM_ID_MINOTAUR_HORN), 3));

            // slayMinotaur RewardItem
            // Key to Basilisk's Chambers
            slayMinotaur.RewardItem = ItemByID(ITEM_ID_BASILISKS_KEY);

            // create slayBasilisk quest object
            Quest slayBasilisk = new Quest(QUEST_ID_SLAY_BASILISK,
                "Stop the Basilisk", "This large snake slithers in the Basilisk's Chambers, it's able to swallow a person whole with no effort. Villagers are terrified if it breaks free. Stop it before it does. Bring 3 Basilisk Poisons back and you'll be rewarded with a special flame to stop the Hydra.", 50, 50);

            // slayBasilisk CompletionItems
            slayBasilisk.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_BASILISK_POISON), 3));

            // slayBasilisk RewardItem
            // Key to Hydra
            slayBasilisk.RewardItem = ItemByID(ITEM_ID_HYDRA_FIRE);

            // create slayHydra quest object
            Quest slayHydra = new Quest(QUEST_ID_SLAY_THE_HYDRA,
                "Behead the Hydra", "The multiheaded Seperant must be defeated, with the Hydra's Fire, cauterize the wounds to prevent the heads from regrowing. Bring back 3 Hydra heads and receive the key to the graveyard.", 50, 50);

            // slayHydra CompletionItems
            slayHydra.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_HYDRA_HEAD), 3));

            // slayHydra RewardItem
            // Key to graveyard
            slayHydra.RewardItem = ItemByID(ITEM_ID_GRAVEYARD_KEY);

            // create slayLichKing quest object
            Quest slayLichKing = new Quest(QUEST_ID_STOP_THE_LICH_KING,
                "Stop the Lich King", "The Lich King commands the dead, put a stop to him before he raises an army of immortal warriors. Bring back 3 of his staves and you'll be rewarded with The Dark Sword, Durandal", 50, 50);

            // slayLichKing CompletionItems
            slayLichKing.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_LICH_KING_STAFF), 3));

            // slayLichKing RewardItem
            // Key to Cerberus
            slayLichKing.RewardItem = ItemByID(ITEM_ID_DURANDAL);

            // create slayCerberus quest object
            Quest slayCerberus = new Quest(QUEST_ID_BEAT_CERBERUS,
                "Beat Cerberus", "Cerberus guards the Gate to the Underworld, defeat him to pass.", 50, 50);

            // slayCerberus CompletionItems
            slayCerberus.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_CERBERUSS_COLLAR), 3));

            // slayCerberus RewardItem
            // Key to the Underworld
            slayCerberus.RewardItem = ItemByID(ITEM_ID_CHARONS_BOAT);

            // clearUnderworld Quest
            Quest clearUnderworld = new Quest(QUEST_ID_CLEAR_UNDERWORLD,
                "Clear the Underworld", "Demons are gathering, defeat 10 demons and bring 10 demon' s seals back. You'll proven yourself to take on the Demon Lord.", 25, 25);

            clearUnderworld.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_DEMONS_SEAL), 10));

            clearUnderworld.RewardItem = ItemByID(ITEM_ID_CASTLE_KEY);

            // create slayDemonLord quest object
            Quest slayDemonLord = new Quest(QUEST_ID_DEFEAT_THE_DEMON_LORD,
                "Defeat the Demon Lord", "The Demon Lord is creating an army of terrifying demons to take over the world. Stop him and bring the Demon Lord's Amulets as proof. You'll be rewarded with the pass to the Centaur's forest.", 50, 50);

            // slayDemonLord CompletionItems
            slayDemonLord.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_DEMON_LORD_AMULET), 3));

            // slayDemonLord RewardItems
            // Item to get to Drake Highlands
            slayDemonLord.RewardItem = ItemByID(ITEM_ID_CENTAURS_PASS);

            // clearDrakeHighlands quest
            Quest clearDrakeHighlands = new Quest(QUEST_ID_CLEAR_DRAKE_HIGHLANDS,
                "Clear the Drake Highlands", "Wyverns have been attacking the villagers' livestock, They fear they are feeding a much stronger monster. Bring back 10 Wyvern claws and you'll be rewarded with Gungnir, Odin's Spear.", 25, 25);

            clearDrakeHighlands.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_WYVERNS_CLAWS), 10));

            clearDrakeHighlands.RewardItem = ItemByID(ITEM_ID_GUNGNIR);

            // clear the Kobold Mine
            Quest clearKoboldMine = new Quest(QUEST_ID_CLEAR_KOBOLD_MINE,
                "Clear the Kobold Mine", "Kobolds are blocking the way to the Dragon's Lair. Bring back 10 Kobold Pickaxes to get the key.", 25, 25);

            clearKoboldMine.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_KOBOLD_PICKAXE), 10));

            clearKoboldMine.RewardItem = ItemByID(ITEM_ID_DRAGON_KEY);

            // create slayDragon quest object
            Quest slayDragon = new Quest(QUEST_ID_BEAT_THE_DRAGON,
                "Slay the Dragon", "The Legendary Beast, the dragon, it paralyzes those who hear it's mighty roar in fear. Slay it and you'll be gifted Excalibur, the legendary sword.", 100, 100);

            // slayDragon CompletionItems
            slayDragon.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_DRAGON_SCALE), 5));

            // slayDragon RewardItem
            // Excaliber
            slayDragon.RewardItem = ItemByID(ITEM_ID_EXCALIBUR);

            // Add Quests to static list
            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
            Quests.Add(clearForest);
            Quests.Add(avengeVillagers);
            Quests.Add(slayRocs);
            Quests.Add(slayBasilisk);
            Quests.Add(slayMinotaur);
            Quests.Add(slayHydra);
            Quests.Add(slayLichKing);
            Quests.Add(slayCerberus);
            Quests.Add(clearUnderworld);
            Quests.Add(slayDemonLord);
            Quests.Add(clearDrakeHighlands);
            Quests.Add(clearKoboldMine);
            Quests.Add(slayDragon);
        }

        private static void PopulateLocations()
        {
            // Create home Location
            Location home = new Location(LOCATION_ID_HOME,
                "Home", "Your house. You really need clean up the place.");

            // Create townSquare Location
            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE,
                "Town Square", "You see a fountain.");
            townSquare.QuestAvailableHere = QuestByID(QUEST_ID_BEAT_THE_DRAGON);

            Vendor AlanTheNPCMerchant = new Vendor("Alan The NPC Merchant");

            townSquare.VendorWorkingHere = AlanTheNPCMerchant;

            // Create alchemistHut Location
            // clearAlchemistGarden quest available
            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT,
                "Alchemist's Hut", "There are many strange plants on the shelves.");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            // Create alchemistsGarden Location
            // rats live here
            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMIST_GARDEN,
                "Alchemist's Garden", "Many plants are growing here.");
            alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

            // Create farmhouse Location
            // clearFarmersField quest available
            Location farmHouse = new Location(LOCATION_ID_FARMHOUSE,
                "Farmhouse", "There is a small farmhouse, with a farmer in front.");
            farmHouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            // Create farmersField Location
            // snakes live here
            Location farmersField = new Location(LOCATION_ID_FARM_FIELD,
                "Farmer's Field", "You see rows of vegetables growing here.");
            farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            // Create guardPost Location
            // Requires Adeventurer Pass to enter
            Location guardPost = new Location(LOCATION_ID_GUARD_POST,
                "Guard Post", "There is a large, tough-looking guard here.",
                ItemByID(ITEM_ID_ADVENTURER_PASS));
            guardPost.QuestAvailableHere = QuestByID(QUEST_ID_SPIDER_FIELD);

            // Create bridge Location
            Location bridge = new Location(LOCATION_ID_BRIDGE,
                "Bridge", "A stone bridge crosses a wide river. Strong Trolls lives under the bridge. Beware!");
            bridge.MonsterLivingHere = MonsterByID(MONSTER_ID_TROLL);

            // Create spiderField Location
            // giantSpider lives here
            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD,
                "Forest", "You see spider webs covering the trees in this forest.");
            spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);

            // create deepForest Location
            // wolf Monster lives here
            Location deepForest = new Location(LOCATION_ID_DEEP_FOREST,
                "Deep Forest", "The forestation is thick, light has trouble getting through.");
            deepForest.MonsterLivingHere = MonsterByID(MONSTER_ID_WOLF);

            // create mountainBase Location
            // slayRocs quest here
            Location mountainBase = new Location(LOCATION_ID_THUNDERING_HEIGHTS_BASE,
                "Base of Thundering Heights", "The top of the mountain is hidden by the clouds.");
            mountainBase.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_THUNDERING_HEIGHTS);

            // create mountainSummit Location
            // Rocs live here
            Location mountainSummit = new Location(LOCATION_ID_THUNDERING_HEIGHTS_SUMMIT,
                "Summit of Thundering Heights", "After a long climb, you finally reached the top.");
            mountainSummit.MonsterLivingHere = MonsterByID(MONSTER_ID_ROC);

            // create caveEntrance Location
            // avengerVillagers quest here
            // require a torch.
            Location caveEntrance = new Location(LOCATION_ID_THE_RELENTLESS_HOLLOW_ENTRANCE,
                "Entrance to The Relentless Hollow", "The Relentless Hollow's darkness engulfs the light",
                ItemByID(ITEM_ID_TORCH));
            caveEntrance.QuestAvailableHere = QuestByID(QUEST_ID_AVENGE_THE_VILLAGERS);

            // Create cave Location
            // have bats spawn here TO-DO
            Location cave = new Location(LOCATION_ID_THE_RELENTLESS_HOLLOW,
                "The Relentless Hollow", "Darkness extends in all directions.");
            cave.MonsterLivingHere = MonsterByID(MONSTER_ID_BAT);

            // create caveSpring Location
            // Spawn goblin
            Location caveSpring = new Location(LOCATION_ID_THE_RELENTLESS_HOLLOW_SPRING,
                "The Relentless Hollow Spring", "The water here is crystal clear");
            caveSpring.MonsterLivingHere = MonsterByID(MONSTER_ID_GOBLIN);

            // Create graveyard Location and undead live here
            // Create must have object from hydra quest to enter TO-DO
            // Lich King quest that reward's the guardian's key object TO-DO
            Location graveyard = new Location(LOCATION_ID_GRAVEYARD,
                "The Town's Graveyard", "The townspeople are laid to rest here.",
                ItemByID(ITEM_ID_GRAVEYARD_KEY));
            graveyard.MonsterLivingHere = MonsterByID(MONSTER_ID_UNDEAD);

            // Create crypt Location and banshee live here
            Location crypt = new Location(LOCATION_ID_CRYPT,
                "The Old Crypt", "Dust fills the air of the crypts of the dead");
            crypt.MonsterLivingHere = MonsterByID(MONSTER_ID_BANSHEE);
            crypt.QuestAvailableHere = QuestByID(QUEST_ID_STOP_THE_LICH_KING);

            // Create catacombs Location lich king lives here
            Location catacombs = new Location(LOCATION_ID_CATACOMBS,
                "The Catacombs", "Few dare to enter the catacombs, some say there is a powerful necromancer deep within.");
            catacombs.MonsterLivingHere = MonsterByID(MONSTER_ID_LICH_KING);
            catacombs.QuestAvailableHere = QuestByID(QUEST_ID_BEAT_CERBERUS);

            // Create gatesToUnderworld Location and Cerberus lives here
            // Requires guardian's key to get into
            Location gatesToUnderworld = new Location(LOCATION_ID_GATES_TO_UNDERWORLD,
                "The Gates to the Underworld", "Hade's guardian dog, Cerberus is blocking the Underworld",
                ItemByID(ITEM_ID_DURANDAL));
            gatesToUnderworld.MonsterLivingHere = MonsterByID(MONSTER_ID_CERBERUS);
            gatesToUnderworld.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_UNDERWORLD);

            // Create underworld Location and demons live here
            // Get Slay Demon Lord quest here
            Location underworld = new Location(LOCATION_ID_UNDERWORLD,
                "The Underworld", "The dead and demons fill this world. The Underworld's reach goes on forever.",
                ItemByID(ITEM_ID_CHARONS_BOAT));
            underworld.MonsterLivingHere = MonsterByID(MONSTER_ID_DEMON);
            underworld.QuestAvailableHere = QuestByID(QUEST_ID_DEFEAT_THE_DEMON_LORD);

            // Create demonLordsCastle Location and demon lord lives here
            Location demonLordsCastle = new Location(LOCATION_ID_DEMON_LORDS_CASTLE,
                "The Demon Lord's Castle", "The strongest demon resides in this castle, you feel an immense evil pressure piercing your skin.",
                ItemByID(ITEM_ID_CASTLE_KEY));
            demonLordsCastle.MonsterLivingHere = MonsterByID(MONSTER_ID_DEMON_LORD);

            // Create labyrinthEntrance Location
            // Get slay the minotaur Quest
            // Reward item to go to basilisk's lair
            Location labyrinthEntrance = new Location(LOCATION_ID_LABYRINTH_ENTRANCE,
                "Labyrinth's Entrance",
                "The Labyrinth from the legends. You can hear the mighty minotaur's roar from deep within.",
                ItemByID(ITEM_ID_ARIADNES_THREAD));
            labyrinthEntrance.QuestAvailableHere = QuestByID(QUEST_ID_SLAY_THE_MINOTAUR);

            // Create labyrinth Location
            Location labyrinth = new Location(LOCATION_ID_LABYRINTH,
                "Labyrinth", "Twists and turns everywhere, too bad there's not a map of the labyrinth.");

            // Create deepInTheLabyrinth Location
            Location deepInTheLabyrinth = new Location(LOCATION_ID_LABYRINTH_DEEP,
                "Deep in the Labyrinth", "You've been wandering for what seems like days, dead end after dead end, in search for the end.");

            // Create labyrinthDeadend Location
            Location labyrinthDeadend = new Location(LOCATION_ID_LABYRINTH_DEAD_END,
                "Dead End", "Another dead end in this labyrinth, it's truly frustrating.");
            labyrinthDeadend.QuestAvailableHere = QuestByID(QUEST_ID_SLAY_BASILISK);

            // Create minotaursLair Location and minotaur lives here
            Location minotaursLair = new Location(LOCATION_ID_MINOTAURS_LAIR,
                "Minotaur's Lair", "The legendary minotaur stands tall. It's roar strikes fear into any who hears it.");
            minotaursLair.MonsterLivingHere = MonsterByID(MONSTER_ID_MINOTAUR);

            // Create basilisksLair Location and basilisk lives here
            // Get the Slay the Hydra quest here
            // Require item received from minotaur quest
            Location basilisksChambers = new Location(LOCATION_ID_BASILISKS_CHAMBERS,
                "Basilisk's Chambers", "The Basilisk circles its prey, hungry for an adventure that decided to walk into this dark, musky chamber.",
                ItemByID(ITEM_ID_BASILISKS_KEY));
            basilisksChambers.MonsterLivingHere = MonsterByID(MONSTER_ID_BASILISK);

            // Create mysticLake Location and naga lives here
            Location mysticLake = new Location(LOCATION_ID_MYSTIC_LAKE,
                "Mystic Lake", "The water glows a bright blue. This is the source of the Relentless Hollow's spring. It's effects are much greater");
            mysticLake.MonsterLivingHere = MonsterByID(MONSTER_ID_NAGA);
            mysticLake.QuestAvailableHere = QuestByID(QUEST_ID_SLAY_THE_HYDRA);

            // Create hydrasLair Location and hydra lives here
            // Reward the item for the graveyard
            Location hydrasLair = new Location(LOCATION_ID_HYDRA_LAIR,
                "Hydra's Lair", "The Beast of Legends, each time you cut one of it's many heads off, it grows two more.",
                ItemByID(ITEM_ID_HYDRA_FIRE));
            hydrasLair.MonsterLivingHere = MonsterByID(MONSTER_ID_HYDRA);

            // Create centaursForest Location and centaurs live here
            Location centaursForest = new Location(LOCATION_ID_CENTAURS_FOREST,
                "Centaurs Forest", "Mighty warrior centaurs gather in this part of the forest.",
                ItemByID(ITEM_ID_CENTAURS_PASS));
            centaursForest.MonsterLivingHere = MonsterByID(MONSTER_ID_CENTAUR);

            // Create theEternalNightForest Location and werewolves live here
            Location theEternalNightForest = new Location(LOCATION_ID_ETERNAL_NIGHT_FOREST,
                "The Eternal Night Forest", "The darkness engulfs this forest filled with nocturnal creatures.");
            theEternalNightForest.MonsterLivingHere = MonsterByID(MONSTER_ID_WEREWOLF);

            // Create baseDrakeHighlands Location
            // Require item from demon lord quest
            // Give slay the dragon quest
            Location baseDrakeHighlands = new Location(LOCATION_ID_DRAKE_HIGHLANDS_BASE,
                "Base of the Drake Highlands", "Proceed with caution, it is known that Wyverns and Dragons live here.");
            baseDrakeHighlands.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_DRAKE_HIGHLANDS);

            // Create drakeHighlands Location and wyverns live here
            Location drakeHighlands = new Location(LOCATION_ID_DRAKE_HIGHLANDS,
                "Drake Highlands", "Wyverns fill the sky, you see a cave boarded up that warns of danger.");
            drakeHighlands.MonsterLivingHere = MonsterByID(MONSTER_ID_WYVERN);
            drakeHighlands.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_KOBOLD_MINE);

            // Create koboldMine Location and kobolds live here
            Location koboldMine = new Location(LOCATION_ID_KOBOLDS_MINE,
                "The Kobold Mine", "Kobolds have lived in the darkness for years, you hear a loud snore from the depths of the mine.");
            koboldMine.MonsterLivingHere = MonsterByID(MONSTER_ID_KOBOLD);

            // Create dragonsLair Location and dragons live here
            Location dragonsLair = new Location(LOCATION_ID_DRAGONS_LAIR,
                "The Dragon's Lair", "You awoken the sleeping dragon, it is furious. Prepare to fight.",
                ItemByID(ITEM_ID_DRAGON_KEY));
            dragonsLair.MonsterLivingHere = MonsterByID(MONSTER_ID_DRAGON);

            // Link the locations together
            home.LocationToNorth = townSquare;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToSouth = home;
            townSquare.LocationToWest = farmHouse;

            farmHouse.LocationToEast = townSquare;
            farmHouse.LocationToWest = farmersField;

            farmersField.LocationToEast = farmHouse;

            alchemistHut.LocationToNorth = alchemistsGarden;
            alchemistHut.LocationToSouth = townSquare;

            alchemistsGarden.LocationToSouth = alchemistHut;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;
            guardPost.LocationToSouth = graveyard;

            bridge.LocationToEast = spiderField;
            bridge.LocationToWest = guardPost;

            spiderField.LocationToWest = bridge;
            spiderField.LocationToNorth = deepForest;
            spiderField.LocationToEast = centaursForest;

            deepForest.LocationToSouth = spiderField;
            deepForest.LocationToNorth = mountainBase;
            deepForest.LocationToWest = caveEntrance;

            mountainBase.LocationToSouth = deepForest;
            mountainBase.LocationToNorth = mountainSummit;

            mountainSummit.LocationToSouth = mountainBase;

            caveEntrance.LocationToEast = deepForest;
            caveEntrance.LocationToWest = cave;

            cave.LocationToEast = caveEntrance;
            cave.LocationToNorth = caveSpring;

            caveSpring.LocationToSouth = cave;
            caveSpring.LocationToNorth = labyrinthEntrance;

            graveyard.LocationToNorth = guardPost;
            graveyard.LocationToSouth = crypt;

            crypt.LocationToNorth = graveyard;
            crypt.LocationToSouth = catacombs;

            catacombs.LocationToNorth = crypt;
            catacombs.LocationToSouth = gatesToUnderworld;

            gatesToUnderworld.LocationToNorth = catacombs;
            gatesToUnderworld.LocationToSouth = underworld;

            underworld.LocationToNorth = gatesToUnderworld;
            underworld.LocationToSouth = demonLordsCastle;

            demonLordsCastle.LocationToNorth = underworld;

            labyrinthEntrance.LocationToNorth = labyrinth;
            labyrinthEntrance.LocationToSouth = caveSpring;

            labyrinth.LocationToNorth = labyrinthDeadend;
            labyrinth.LocationToEast = basilisksChambers;
            labyrinth.LocationToSouth = labyrinthEntrance;
            labyrinth.LocationToWest = deepInTheLabyrinth;

            labyrinthDeadend.LocationToSouth = labyrinth;

            deepInTheLabyrinth.LocationToNorth = minotaursLair;
            deepInTheLabyrinth.LocationToEast = labyrinth;

            minotaursLair.LocationToSouth = deepInTheLabyrinth;

            basilisksChambers.LocationToWest = labyrinth;
            basilisksChambers.LocationToNorth = mysticLake;

            mysticLake.LocationToSouth = basilisksChambers;
            mysticLake.LocationToNorth = hydrasLair;

            hydrasLair.LocationToSouth = mysticLake;

            centaursForest.LocationToWest = spiderField;
            centaursForest.LocationToNorth = theEternalNightForest;
            centaursForest.LocationToEast = baseDrakeHighlands;

            theEternalNightForest.LocationToSouth = centaursForest;

            baseDrakeHighlands.LocationToWest = centaursForest;
            baseDrakeHighlands.LocationToNorth = drakeHighlands;

            drakeHighlands.LocationToSouth = baseDrakeHighlands;
            drakeHighlands.LocationToEast = koboldMine;

            koboldMine.LocationToWest = drakeHighlands;
            koboldMine.LocationToEast = dragonsLair;

            dragonsLair.LocationToWest = koboldMine;

            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmHouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);
            Locations.Add(deepForest);
            Locations.Add(mountainBase);
            Locations.Add(mountainSummit);
            Locations.Add(caveEntrance);
            Locations.Add(cave);
            Locations.Add(caveSpring);
            Locations.Add(graveyard);
            Locations.Add(crypt);
            Locations.Add(catacombs);
            Locations.Add(gatesToUnderworld);
            Locations.Add(underworld);
            Locations.Add(demonLordsCastle);
            Locations.Add(labyrinth);
            Locations.Add(deepInTheLabyrinth);
            Locations.Add(labyrinthDeadend);
            Locations.Add(labyrinthEntrance);
            Locations.Add(minotaursLair);
            Locations.Add(basilisksChambers);
            Locations.Add(mysticLake);
            Locations.Add(hydrasLair);
            Locations.Add(centaursForest);
            Locations.Add(theEternalNightForest);
            Locations.Add(baseDrakeHighlands);
            Locations.Add(drakeHighlands);
            Locations.Add(koboldMine);
            Locations.Add(dragonsLair);
        } // End PopulateLocations function

        // PopulateSpells function
        private static void PopulateSpells()
        {
            Spell firebolt = new Spell(SPELL_ID_FIREBOLT, "Firebolt", 5, 10, "Fire");
            Spell icebolt = new Spell(SPELL_ID_ICEBOLT, "Icebolt", 5, 10, "Ice");
            Spell lightningbolt = new Spell(SPELL_ID_LIGHTNINGBOLT, "Lightningbolt", 5, 10, "Lightning");
            Spell rockBullet = new Spell(SPELL_ID_ROCK_BULLET, "Rock Bullet", 5, 10, "Earth");
            Spell fireball = new Spell(SPELL_ID_FIREBALL, "Fireball", 100, 500, "Fire");
            Spell iceSpear = new Spell(SPELL_ID_ICE_SPEAR, "Ice Spear", 100, 500, "Ice");
            Spell thunder = new Spell(SPELL_ID_THUNDER, "Thunder", 100, 500, "Lightning");
            Spell golemsStrike = new Spell(SPELL_ID_GOLEMS_STRIKE, "Golem's Strike", 100, 500, "Earth");
            Spell meteor = new Spell(SPELL_ID_METEOR, "Meteor", 1000, 2000, "Fire");
            Spell hailStorm = new Spell(SPELL_ID_HAIL_STORM, "Hail Storm", 1000, 2000, "Ice");
            Spell lightningRod = new Spell(SPELL_ID_LIGHTNING_ROD, "Lightning Rod", 1000, 2000, "Lightning");
            Spell gravityCrush = new Spell(SPELL_ID_GRAVITY_CRUSH, "Gravity Crush", 1000, 2000, "Earth");

            Spells.Add(firebolt);
            Spells.Add(icebolt);
            Spells.Add(lightningbolt);
            Spells.Add(rockBullet);
            Spells.Add(fireball);
            Spells.Add(iceSpear);
            Spells.Add(thunder);
            Spells.Add(golemsStrike);
            Spells.Add(meteor);
            Spells.Add(hailStorm);
            Spells.Add(lightningRod);
            Spells.Add(gravityCrush);
        }

        // ItemByID function
        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }
            return null;
        } // End ItemByID function

        // MonsterByID function
        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        } // End MonsterByID function

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        } // End QuestByID function

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        } // End LocationByID function

        public static Spell SpellByID(int id)
        {
            foreach (Spell spell in Spells)
            {
                if(spell.ID == id)
                {
                    return spell;
                }
            }

            return null;
        }
    }
}
