using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CharacterSheet.Models
{
    public class CharacterGenerator
    {
        private static Random ran = new Random();
        private static CharacterTraits character = new CharacterTraits();
        private static string[] names = { "Chad", "Brad", "Daisy", "Regina", "Pat", "Reggie", "Winona", "Mister", "Ma'am", "Sam", "Alex", "Garth" };
        private static string[] classes = { "Cleric", "Bard", "Barbarian", "Fighter", "Druid", "Rogue", "Monk", "Paladin", "Ranger", "Sorcerer", "Wizard" };
        private static string[] alignments = { "LG", "NG", "CG", "LN", "N", "CN", "LE", "NE", "CE" };
        private static string[] races = { "Dwarf", "Elf", "Gnome", "Half-elf", "Half-orc", "Halfling", "Human" };
        private static string[] gender = { "M", "F" };
        private static int[] abilityScores;

        public static int[] AbilityScores()
        {
            abilityScores = new int[6];
            for (int i = 0; i < abilityScores.Length; i++)
            {
                abilityScores[i] = ran.Next(3, 18);
            }
            Array.Sort(abilityScores);
            return abilityScores;
        }

        public static string GetRace()
        {
            // select random race, change stats based on result
            character.Race = races[ran.Next(0, races.Length)];
            switch (character.Race)
            {
                case "Dwarf":
                    character.Size = "Medium";
                    character.Speed = "20ft";
                    character.Constitution += 2;
                    character.Wisdom += 2;
                    character.Charisma += -2;
                    break;
                case "Elf":
                    character.Size = "Medium";
                    character.Speed = "30ft";
                    character.Dexterity += 2;
                    character.Intelligence += 2;
                    character.Constitution += -2;
                    break;
                case "Gnome":
                    character.Size = "Small";
                    character.Speed = "20ft";
                    character.Constitution += 2;
                    character.Charisma += 2;
                    character.Strength += -2;
                    break;
                case "Half-elf":
                    character.Size = "Medium";
                    character.Speed = "30ft";
                    character.Charisma += 2;
                    break;
                case "Half-orc":
                    character.Size = "Medium";
                    character.Speed = "30ft";
                    character.Strength += 2;
                    break;
                case "Halfling":
                    character.Size = "Small";
                    character.Speed = "20ft";
                    character.Dexterity += 2;
                    character.Charisma += 2;
                    character.Strength += -2;
                    break;
                case "Human":
                    character.Size = "Medium";
                    character.Speed = "30ft";
                    character.Constitution += 2;
                    break;
            }
            return character.Race;
        }

        public static string GetClass()
        {
            // select random class, set stats based on result
            character.Class = classes[ran.Next(0, classes.Length)];
            switch (character.Class)
            {
                case "Cleric":
                    character.HitPoints = 8;
                    character.Diplomacy = true;
                    character.Heal = true;
                    // preferred abilities prioritized
                    character.Wisdom += abilityScores[5];
                    character.Charisma += abilityScores[4];
                    character.Strength += abilityScores[3];
                    character.Dexterity += abilityScores[2];
                    character.Constitution += abilityScores[1];
                    character.Intelligence += abilityScores[0];
                    break;
                case "Bard":
                    character.HitPoints = 8;
                    character.Bluff = true;
                    character.Perception = true;

                    character.Charisma += abilityScores[5];
                    character.Dexterity += abilityScores[4];
                    character.Constitution += abilityScores[3];
                    character.Intelligence += abilityScores[2];
                    character.Wisdom += abilityScores[1];
                    character.Strength += abilityScores[0];
                    break;
                case "Barbarian":
                    character.HitPoints = 12;
                    character.Climb = true;
                    character.Intimidate = true;

                    character.Strength += abilityScores[5];
                    character.Constitution += abilityScores[4];
                    character.Dexterity += abilityScores[3];
                    character.Wisdom += abilityScores[2];
                    character.Charisma += abilityScores[1];
                    character.Intelligence += abilityScores[0];
                    break;
                case "Fighter":
                    character.HitPoints = 10;
                    character.Acrobatics = true;
                    character.Intimidate = true;

                    character.Strength += abilityScores[5];
                    character.Constitution += abilityScores[4];
                    character.Dexterity += abilityScores[3];
                    character.Wisdom += abilityScores[2];
                    character.Charisma += abilityScores[1];
                    character.Intelligence += abilityScores[0];
                    break;
                case "Druid":
                    character.HitPoints = 8;
                    character.Fly = true;
                    character.Heal = true;

                    character.Wisdom += abilityScores[5];
                    character.Dexterity += abilityScores[4];
                    character.Constitution += abilityScores[3];
                    character.Intelligence += abilityScores[2];
                    character.Strength += abilityScores[1];
                    character.Charisma += abilityScores[0];
                    break;
                case "Rogue":
                    character.HitPoints = 8;
                    character.Bluff = true;
                    character.Stealth = true;

                    character.Dexterity += abilityScores[5];
                    character.Constitution += abilityScores[4];
                    character.Wisdom += abilityScores[3];
                    character.Charisma += abilityScores[2];
                    character.Intelligence += abilityScores[1];
                    character.Strength += abilityScores[0];
                    break;
                case "Monk":
                    character.HitPoints = 8;
                    character.Acrobatics = true;
                    character.Climb = true;

                    character.Strength += abilityScores[5];
                    character.Wisdom += abilityScores[4];
                    character.Dexterity += abilityScores[3];
                    character.Constitution += abilityScores[2];
                    character.Intelligence += abilityScores[1];
                    character.Charisma += abilityScores[0];
                    break;
                case "Paladin":
                    character.HitPoints = 10;
                    character.Intimidate = true;
                    character.Heal = true;

                    character.Strength += abilityScores[5];
                    character.Charisma += abilityScores[4];
                    character.Constitution += abilityScores[3];
                    character.Wisdom += abilityScores[2];
                    character.Dexterity += abilityScores[1];
                    character.Intelligence += abilityScores[0];
                    break;
                case "Ranger":
                    character.HitPoints = 10;
                    character.Perception = true;
                    character.Stealth = true;

                    character.Dexterity += abilityScores[5];
                    character.Strength += abilityScores[4];
                    character.Wisdom += abilityScores[3];
                    character.Intelligence += abilityScores[2];
                    character.Constitution += abilityScores[1];
                    character.Charisma += abilityScores[0];
                    break;
                case "Sorcerer":
                    character.HitPoints = 6;
                    character.Fly = true;
                    character.Intimidate = true;

                    character.Charisma += abilityScores[5];
                    character.Dexterity += abilityScores[4];
                    character.Constitution += abilityScores[3];
                    character.Intelligence += abilityScores[2];
                    character.Wisdom += abilityScores[1];
                    character.Strength += abilityScores[0];
                    break;
                case "Wizard":
                    character.HitPoints = 6;
                    character.Fly = true;
                    character.Intimidate = true;

                    character.Intelligence += abilityScores[5];
                    character.Dexterity += abilityScores[4];
                    character.Constitution += abilityScores[3];
                    character.Wisdom += abilityScores[2];
                    character.Charisma += abilityScores[1];
                    character.Strength += abilityScores[0];
                    break;
            }
            return character.Class;
        }

        public static string GetName()
        {
            // select random name
            return character.Name = names[ran.Next(0, names.Length)];
        }

        public static string GetAlignment()
        {
            // select random alignment
            return character.Alignment = alignments[ran.Next(0, alignments.Length)];
        }

        public static string GetSize()
        {
            var result = character.Size;
            return result;
        }

        public static string GetGender()
        {
            // select random gender
            return character.Gender = gender[ran.Next(0, gender.Length)];
        }

        public static string GetHitPoints()
        {
            var result = character.HitPoints;
            return result.ToString();
        }

        public static string GetSpeed()
        {
            var result = character.Speed;
            return result;
        }

        public static string GetStrength()
        {
            var result = character.Strength;
            return result.ToString();
        }

        public static string GetDexterity()
        {
            var result = character.Dexterity;
            return result.ToString();
        }

        public static string GetConstitution()
        {
            var result = character.Constitution;
            return result.ToString();
        }

        public static string GetIntelligence()
        {
            var result = character.Intelligence;
            return result.ToString();
        }

        public static string GetWisdom()
        {
            var result = character.Wisdom;
            return result.ToString();
        }

        public static string GetCharisma()
        {
            var result = character.Charisma;
            return result.ToString();
        }

        public static bool GetAcrobatcis()
        {
            var result = character.Acrobatics;
            return result;
        }

        public static bool GetBluff()
        {
            var result = character.Bluff;
            return result;
        }

        public static bool GetClimb()
        {
            var result = character.Climb;
            return result;
        }

        public static bool GetDiplomacy()
        {
            var result = character.Diplomacy;
            return result;
        }

        public static bool GetFly()
        {
            var result = character.Fly;
            return result;
        }

        public static bool GetHeal()
        {
            var result = character.Heal;
            return result;
        }

        public static bool GetIntimidate()
        {
            var result = character.Intimidate;
            return result;
        }

        public static bool GetPerception()
        {
            var result = character.Perception;
            return result;
        }

        public static bool GetStealth()
        {
            var result = character.Stealth;
            return result;
        }

        public static void ResetCharacter()
        {
            character.Name = "";
            character.Alignment = "";
            character.Race = "";
            character.Size = "";
            character.Class = "";
            character.Gender = "";
            character.HitPoints = 0;
            character.Speed = "";

            character.Strength = 0;
            character.Dexterity = 0;
            character.Constitution = 0;
            character.Intelligence = 0;
            character.Wisdom = 0;
            character.Charisma = 0;

            character.Acrobatics = false;
            character.Bluff = false;
            character.Climb = false;
            character.Diplomacy = false;
            character.Fly = false;
            character.Heal = false;
            character.Intimidate = false;
            character.Perception = false;
            character.Stealth = false;
        }
    }
}
