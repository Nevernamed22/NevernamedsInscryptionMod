using DiskCardGame;
using InscryptionAPI.Ascension;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
   public class StarterDecks
    {
        public static void Init()
        {
            StarterDeckInfo fireDeck = ScriptableObject.CreateInstance<StarterDeckInfo>();
            fireDeck.title = "FireStarters";
            fireDeck.iconSprite = Tools.GenerateAct2Portrait( Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/firedeck.png"));
            fireDeck.cards = new List<CardInfo>() { CardLoader.GetCardByName("BeastNevernamed Salamander"), CardLoader.GetCardByName("BeastNevernamed BombardierBeetle"), CardLoader.GetCardByName("BeastNevernamed HotDog") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", fireDeck, unlockLevel: 3);




            StarterDeckInfo deathcardDeck = ScriptableObject.CreateInstance<StarterDeckInfo>();
            deathcardDeck.title = "DeathcardStarters";
            deathcardDeck.iconSprite = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/deathcarddeck.png"));
            deathcardDeck.cards = new List<CardInfo>() { CardLoader.GetCardByName("BeastNevernamed FauxKaycee"), CardLoader.GetCardByName("BeastNevernamed FauxKaminski"), CardLoader.GetCardByName("BeastNevernamed FauxReginald"), CardLoader.GetCardByName("BeastNevernamed FauxLouis") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", deathcardDeck, unlockLevel: 5);



            StarterDeckInfo LatchStarters = ScriptableObject.CreateInstance<StarterDeckInfo>();
            LatchStarters.title = "LatchStarters";
            LatchStarters.iconSprite = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/latchdeck.png"));
            LatchStarters.cards = new List<CardInfo>() { CardLoader.GetCardByName("BeastNevernamed DiseasedCur"), CardLoader.GetCardByName("BeastNevernamed BlastTermite"), CardLoader.GetCardByName("BeastNevernamed ScaleTick") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", LatchStarters, unlockLevel: 4);


            StarterDeckInfo GlitchStarters = ScriptableObject.CreateInstance<StarterDeckInfo>();
            GlitchStarters.title = "GlitchStarters";
            GlitchStarters.iconSprite = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/glitchdeck.png"));
            GlitchStarters.cards = new List<CardInfo>() { CardLoader.GetCardByName("!STATIC!GLITCH"), CardLoader.GetCardByName("!STATIC!GLITCH"), CardLoader.GetCardByName("!STATIC!GLITCH") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", GlitchStarters, unlockLevel: 2);

            StarterDeckInfo CrabStarters = ScriptableObject.CreateInstance<StarterDeckInfo>();
            CrabStarters.title = "CrabStarters";
            CrabStarters.iconSprite = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/crabdeck.png"));
            CrabStarters.cards = new List<CardInfo>() { CardLoader.GetCardByName("BeastNevernamed PeaCrab"), CardLoader.GetCardByName("BeastNevernamed Crab"), CardLoader.GetCardByName("BeastNevernamed Karkinos") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", CrabStarters, unlockLevel: 6);

            StarterDeckInfo TermiteStarters = ScriptableObject.CreateInstance<StarterDeckInfo>();
            TermiteStarters.title = "TermiteStarters";
            TermiteStarters.iconSprite = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/termitedeck.png"));
            TermiteStarters.cards = new List<CardInfo>() { CardLoader.GetCardByName("SigilNevernamed Termite"), CardLoader.GetCardByName("BeastNevernamed TermiteKing"), CardLoader.GetCardByName("BeastNevernamed TermiteQueen") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", TermiteStarters, unlockLevel: 7);

            StarterDeckInfo RNGStarters = ScriptableObject.CreateInstance<StarterDeckInfo>();
            RNGStarters.title = "RNGStarters";
            RNGStarters.iconSprite = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/rngdeck.png"));
            RNGStarters.cards = new List<CardInfo>() { CardLoader.GetCardByName("BeastNevernamed SandDollar"), CardLoader.GetCardByName("BeastNevernamed MethuselahMouse"), CardLoader.GetCardByName("BeastNevernamed SnakeEyes") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", RNGStarters, unlockLevel: 2);

            StarterDeckInfo RodentStarters = ScriptableObject.CreateInstance<StarterDeckInfo>();
            RodentStarters.title = "RodentStarters";
            RodentStarters.iconSprite = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/rodentdeck.png"));
            RodentStarters.cards = new List<CardInfo>() { CardLoader.GetCardByName("BeastNevernamed StarvedRat"), CardLoader.GetCardByName("BeastNevernamed DireRat"), CardLoader.GetCardByName("FieldMouse") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", RodentStarters, unlockLevel: 3);

            StarterDeckInfo ShittyStarters = ScriptableObject.CreateInstance<StarterDeckInfo>();
            ShittyStarters.title = "ShittyStarters";
            ShittyStarters.iconSprite = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/shittydeck.png"));
            ShittyStarters.cards = new List<CardInfo>() { CardLoader.GetCardByName("SigilNevernamed Mess"), CardLoader.GetCardByName("BeastNevernamed DyingSpider"), CardLoader.GetCardByName("BeastNevernamed Mistake") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", ShittyStarters, unlockLevel: 1);

            StarterDeckInfo ItemStarters = ScriptableObject.CreateInstance<StarterDeckInfo>();
            ItemStarters.title = "ItemStarters";
            ItemStarters.iconSprite = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/itemdeck.png"));
            ItemStarters.cards = new List<CardInfo>() { CardLoader.GetCardByName("PackRat"), CardLoader.GetCardByName("BeastNevernamed ItemTentacle"), CardLoader.GetCardByName("BeastNevernamed Bluebottle") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", ItemStarters, unlockLevel: 7);

            StarterDeckInfo ChaosCardStarters = ScriptableObject.CreateInstance<StarterDeckInfo>();
            ChaosCardStarters.title = "ChaosCardStarters";
            ChaosCardStarters.iconSprite = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/chaoscarddeck.png"));
            ChaosCardStarters.cards = new List<CardInfo>() { CardLoader.GetCardByName("BeastNevernamed ChaosCard"), CardLoader.GetCardByName("BeastNevernamed ChaosCard"), CardLoader.GetCardByName("BeastNevernamed ChaosCard") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", ChaosCardStarters, unlockLevel: 4);

            /*    StarterDeckInfo LightStarters = ScriptableObject.CreateInstance<StarterDeckInfo>();
                LightStarters.title = "LightStarters";
                LightStarters.iconSprite = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/lightdeck.png"));
                LightStarters.cards = new List<CardInfo>() { CardLoader.GetCardByName("Nevernamed Fennec"), CardLoader.GetCardByName("Nevernamed WildHare"), CardLoader.GetCardByName("Nevernamed Puffin") };

                StarterDeckManager.Add("nevernamedscustominscryptioncards", LightStarters, unlockLevel: 2);*/
        }
    }
}
