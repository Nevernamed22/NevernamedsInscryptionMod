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
    static class BombardierBeetle
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BombardierBeetle",
                "Bombardier Beetle",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPlayable, CardMetaCategory.GBCPack },
                CardTemple.Nature,
                description: "The incandescant bombardier beetle. It's boiling hot secretions scald it's prey.",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bombardierbeetle.png"),
                abilities: new List<Ability>() { Ignition.ability },
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/bombardierbeetle_pixel.png"),
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bombardierbeetle_emission.png")
                );
        }
    }
}
