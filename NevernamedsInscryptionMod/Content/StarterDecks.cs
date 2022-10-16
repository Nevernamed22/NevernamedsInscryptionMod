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
            fireDeck.cards = new List<CardInfo>() { CardLoader.GetCardByName("Nevernamed Salamander"), CardLoader.GetCardByName("Nevernamed BombardierBeetle"), CardLoader.GetCardByName("Nevernamed HotDog") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", fireDeck, unlockLevel: 3);




            StarterDeckInfo deathcardDeck = ScriptableObject.CreateInstance<StarterDeckInfo>();
            deathcardDeck.title = "DeathcardStarters";
            deathcardDeck.iconSprite = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/deathcarddeck.png"));
            deathcardDeck.cards = new List<CardInfo>() { CardLoader.GetCardByName("Nevernamed FauxKaycee"), CardLoader.GetCardByName("Nevernamed FauxKaminski"), CardLoader.GetCardByName("Nevernamed FauxReginald"), CardLoader.GetCardByName("Nevernamed FauxLouis") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", deathcardDeck, unlockLevel: 5);



            StarterDeckInfo LatchStarters = ScriptableObject.CreateInstance<StarterDeckInfo>();
            LatchStarters.title = "LatchStarters";
            LatchStarters.iconSprite = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/latchdeck.png"));
            LatchStarters.cards = new List<CardInfo>() { CardLoader.GetCardByName("Nevernamed DiseasedCur"), CardLoader.GetCardByName("Nevernamed BlastTermite"), CardLoader.GetCardByName("Nevernamed ScaleTick") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", LatchStarters, unlockLevel: 4);

        /*    StarterDeckInfo LightStarters = ScriptableObject.CreateInstance<StarterDeckInfo>();
            LightStarters.title = "LightStarters";
            LightStarters.iconSprite = Tools.GenerateAct2Portrait(Tools.LoadTex("NevernamedsInscryptionMod/Resources/StarterDecks/lightdeck.png"));
            LightStarters.cards = new List<CardInfo>() { CardLoader.GetCardByName("Nevernamed Fennec"), CardLoader.GetCardByName("Nevernamed WildHare"), CardLoader.GetCardByName("Nevernamed Puffin") };

            StarterDeckManager.Add("nevernamedscustominscryptioncards", LightStarters, unlockLevel: 2);*/
        }
    }
}
