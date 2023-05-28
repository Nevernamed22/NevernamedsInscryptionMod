using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class Wishpoosh
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed GreaterDam",
    "Greater Dam",
    0,
    4,
    new List<CardMetaCategory> { },
    CardTemple.Nature,
    description: "",
    bloodCost: 0,
    bonesCost: 0,
    defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/greaterdam.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/greaterdam_pixel.png"),
    emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/greaterdam_emission.png"),
    abilities: new List<Ability>() { },
    appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance>() { CardAppearanceBehaviour.Appearance.TerrainBackground, CardAppearanceBehaviour.Appearance.TerrainLayout },
    traits: new List<Trait>() { Trait.Terrain },
    tribes: new List<Tribe>() { },
    defaultEvolutionName: "Godder Dam!"
    );


            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wishpoosh.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Wishpoosh",
                "Wishpoosh",
                2,
                5,
                new List<CardMetaCategory> { CardMetaCategory.Rare, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "The dreadful Wishpoosh, master of the rivers, both earth and water tremble at his name.",
                bloodCost: 3,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.CreateDams, Ability.BuffNeighbours },
                defaultTex: tex,
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { NevernamedsTribes.Rodent },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wishpoosh_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/wishpoosh_pixel.png"),
                overrideDamID: "BeastNevernamed GreaterDam"
                );
        }
    }
}