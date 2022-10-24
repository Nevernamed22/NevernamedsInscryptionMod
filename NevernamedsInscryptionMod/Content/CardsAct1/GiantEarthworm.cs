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
    static class GiantEarthworm
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed EarthwormSegment",
                "Earthworm Segment",
                0,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/earthwormsegment.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground }
                );

            // Add the card
            CardSetupUtility.NewCard("Nevernamed GiantEarthworm",
                "Giant Earthworm",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "A rare giant earthworm. It leaves it's long body behind it as it moves to find food.",
                bloodCost: 1,
                bonesCost: 0,
                abilities: new List<Ability>() { Harbinger.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/giantearthworm.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/giantearthworm_emission.png"),
                decals: new List<Texture>() { Plugin.raresignaturetex },
                harbingerLeaveBehind: "BeastNevernamed EarthwormSegment"
                );
        }
    }
}