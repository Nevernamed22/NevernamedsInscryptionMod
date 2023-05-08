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
    static class SeaNettle
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed SeaNettle",
                "Sea Nettle",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "It's deadly sting is hard to remove...",
                bonesCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/seanettle.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/seanettle_emission.png"),
                abilities: new List<Ability>() { Ability.Deathtouch, Ability.MoveBeside },
                tribes: new List<Tribe>() { }
                );
        }
    }
}