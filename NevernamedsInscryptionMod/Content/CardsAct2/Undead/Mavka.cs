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
    static class Mavka
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Mavka",
                "Mavka",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "The poor girl... she died a tragic, lonely death. It brings me some small solace to give her new companionship as a card.",
                bloodCost: 0,
                bonesCost: 7,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { TripleStrike.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/mavka.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/mavka_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/mavka_pixel.png")
                );
        }
    }
}