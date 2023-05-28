using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using InscryptionAPI.Card;
using NevernamedsSigils;

namespace NevernamedsInscryptionMod
{
    static class Catron
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed CatronSwapped",
                "Catron",
                1,
                1,
                new List<CardMetaCategory> {  },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { BloodBorn.ability, Ability.Sniper },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/catronswapped_pixel.png")
                ).SetExtendedProperty("BloodBornTransformation", "TechNevernamed Catron");

            CardSetupUtility.NewCard("Nevernamed Catron",
                "Catron",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Tech,
                description: "",
                bloodCost: 0,
                bonesCost: 0,
                energyCost: 4,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { BloodBorn.ability },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/catron_pixel.png")
                ).SetExtendedProperty("BloodBornTransformation", "TechNevernamed CatronSwapped");
        }
    }
}