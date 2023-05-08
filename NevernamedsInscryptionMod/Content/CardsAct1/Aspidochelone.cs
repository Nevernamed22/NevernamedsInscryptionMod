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
    static class Aspidochelone
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Aspidochelone",
                "Aspidochelone",
                3,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "That ruthless spiny turtle... it shares it's spines with it's comrades..",
                bloodCost: 3,
                bonesCost: 0,
                abilities: new List<Ability>() { PointNemo.ability, SubaquaticSpines.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/aspidochelone.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { Tribe.Reptile },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/aspidochelone_emission.png")
                );
        }
    }
}