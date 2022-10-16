using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    static class Empusa
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/empusa.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Empusa",
                "Empusa",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Do not give me that look. I can assure you, there is more to this card than meets the eye.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Cute.ability, Allure.ability },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { },
                specialAbilities: new List<SpecialTriggeredAbility>() { OpposedShifter.ability }
                );
        }
    }
}