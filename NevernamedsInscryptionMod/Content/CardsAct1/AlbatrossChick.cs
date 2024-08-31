using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class AlbatrossChick
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed AlbatrossChick",
                "Albatross Chick",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Nature,
                description: "The young of the immense albatross, it seems almost lost inside of it's own down.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/albatrosschick.png"),
                abilities: new List<Ability>() { Ability.Evolve, },
                tribes: new List<Tribe>() { Tribe.Bird },
                  pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/albatrosschick_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/albatrosschick_emission.png"),
                defaultEvolutionCard: "BeastNevernamed Albatross"
                );
        }
    }
}
