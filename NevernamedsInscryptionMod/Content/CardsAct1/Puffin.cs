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
    static class Puffin
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Puffin",
                "Puffin",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The headstrong puffin. It does not relent, despite it's fragile nature.",
                bonesCost: 4,
                //energyCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/puffin.png"),
                abilities: new List<Ability>() {  Ability.Flying },
                tribes: new List<Tribe>() { Tribe.Bird },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/puffin_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/puffin_emission.png")
                );
        }
    }
}