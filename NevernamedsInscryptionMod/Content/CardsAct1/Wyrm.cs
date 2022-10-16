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
    static class Wyrm
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Wyrm",
                "Wyrm",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The mighty wyrm, is upends the soil- sending everything within it flying.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.BoneDigger, Ability.BoneDigger  },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wyrm.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wyrm_emission.png")
                );
        }
    }
}