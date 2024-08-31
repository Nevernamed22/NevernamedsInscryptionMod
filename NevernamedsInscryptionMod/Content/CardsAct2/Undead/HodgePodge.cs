using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using NevernamedsSigils;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class HodgePodge
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed HodgePodge",
                "Hodge Podge",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "Such fun to rearrange! Although to be struck by it is most infuriating...",
                bloodCost: 0,
                bonesCost: 2,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Motivator.ability, UnfocusedStrike.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/hodgepodge.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/hodgepodge_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/hodgepodge_pixel.png")
                );
        }
    }
}