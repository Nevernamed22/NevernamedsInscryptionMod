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
    static class BoneClutter
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BoneClutter",
                "Bone Clutter",
                0,
                1,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/boneclutter.png"),
                abilities: new List<Ability>() { Ability.QuadrupleBones },
                tribes: new List<Tribe>() {  },
                traits: new List<Trait>() { Trait.Terrain},
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.TerrainBackground },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/boneclutter_pixel.png")
                );

            CardSetupUtility.NewCard("Nevernamed BoneClutterGrimora",
                "Bone Clutter",
                0,
                1,
                new List<CardMetaCategory> { },
                CardTemple.Undead,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/bonecluttergrimora.png"),
                abilities: new List<Ability>() { Ability.QuadrupleBones },
                tribes: new List<Tribe>() { },
                traits: new List<Trait>() { Trait.Terrain },
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.TerrainBackground }
                );
        }
    }
}