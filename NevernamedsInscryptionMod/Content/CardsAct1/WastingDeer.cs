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
    static class WastingDeer
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed WastingDeer",
                "Wasting Deer",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "Such a miserable way for a life to end. The flesh hangs off this deers poor, aching bones...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wastingdeer.png"),
                abilities: new List<Ability>() { Ability.DebuffEnemy, Erratic.ability },
                tribes: new List<Tribe>() { },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/wastingdeer_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/wastingdeer_emission.png")
                );
        }
    }
}
