using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class FearGorta
    {
        public static void Init()
        {
            // Add the card
            CardSetupUtility.NewCard("Nevernamed FearGorta",
                "Fear Gorta",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable, Plugin.GrimoraChoiceNode },
                CardTemple.Undead,
                description: "Ahh, the Man of Famine. How he stalks those lonely roads for misers to devour.",
                bloodCost: 0,
                bonesCost: 7,
                energyCost: 0,
                tribes: new List<Tribe>() { },
                abilities: new List<Ability>() { Ability.GainAttackOnKill },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/feargorta.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/CardsGrimora/feargorta_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/feargorta_pixel.png")
                );
        }
    }
}