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
    static class Chupacabra
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Chupacabra",
                "Chupacabra",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack, CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "This beast of the night will tear apart any small prey he finds...",
                bloodCost: 0,
                bonesCost: 8,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/chupacabra.png"),
                abilities: new List<Ability>() { Ripper.ability },
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/chupacabra_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground },
                decals: new List<Texture>() { Plugin.raresignaturetex },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/chupacabra_pixel.png")
                );
        }
    }
}
