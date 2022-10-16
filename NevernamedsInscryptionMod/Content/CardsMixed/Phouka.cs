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
    static class Phouka
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Phouka",
                "Phouka",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack },
                CardTemple.Nature,
                description: "The shifting phouka... it changes between so many creatures of the woods.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/phouka.png"),
                abilities: new List<Ability>() { Hypermorphic.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/phouka_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/phouka_pixel.png")
                );
        }
    }
}
