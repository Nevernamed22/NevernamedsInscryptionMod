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
    static class Reptilicus
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Reptilicus",
                "Reptilicus",
                3,
                4,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The acid saliva of this beast has impressive range...",
                bloodCost: 3,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/reptilicus.png"),
                abilities: new List<Ability>() { Ability.Deathtouch, SplashDamage.ability },
                 appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.RareCardBackground },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/reptilicus_emission.png")
                );
        }
    }
}