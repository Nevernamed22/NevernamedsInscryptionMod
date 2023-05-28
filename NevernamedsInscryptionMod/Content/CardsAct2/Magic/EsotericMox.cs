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
    static class EsotericMox
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed EsotericMox",
                "Esoteric Mox",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, CardMetaCategory.Rare },
                CardTemple.Wizard,
                description: "",
                bloodCost: 0,
                gemsCost: new List<GemType>() { },
                bonesCost: 0,
                tribes: new List<Tribe>() { },
                traits: new List<Trait>() { Trait.Terrain, Trait.Gem },
                abilities: new List<Ability>() { Ability.GainGemTriple, UnstableGems.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/esotericmox_pixel.png")
                );
        }
    }
}