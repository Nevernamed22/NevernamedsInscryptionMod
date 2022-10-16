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
    static class BloodRedDog
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BloodRedDog",
                "Blood Red Dog",
                3,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The infamous blood red dog, nothing can stop it's lust for combat. We'll have tea in hell today...",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Bonestrike.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bloodreddog.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bloodreddog_emission.png")
                );
        }
    }
}