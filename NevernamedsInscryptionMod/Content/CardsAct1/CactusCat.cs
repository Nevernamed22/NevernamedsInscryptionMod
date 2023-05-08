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
    static class CactusCat
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed CactusCat",
                "Cactus Cat",
                1,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The splifficated Cactus Cat, it roams the desert drinking the fermented juice of it's lookalike plant...",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Erratic.ability, SurgingQuills.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cactuscat.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/cactuscat_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { }

                );
        }
    }
}