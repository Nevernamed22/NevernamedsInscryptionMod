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
    static class Balaur
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Balaur",
                "Balaur",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The three-headed Balaur dragon. It lashes out with each of it's maws when threatened.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Sentriple.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/balaur.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/balaur_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Reptile }
                
                );
        }
    }
}