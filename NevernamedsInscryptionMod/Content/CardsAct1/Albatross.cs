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
    static class Albatross
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Albatross",
                "Albatross",
                3,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack },
                CardTemple.Nature,
                description: "The noble albatross. It's vast wingspan creates an impressive downdraft.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/albatross.png"),
                abilities: new List<Ability>() { Ability.Flying, Downdraft.ability },
                tribes: new List<Tribe>() { Tribe.Bird },
                  pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/albatross_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/albatross_emission.png")
                );
        }
    }
}
