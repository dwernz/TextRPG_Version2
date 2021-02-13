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
        }
    }
}
