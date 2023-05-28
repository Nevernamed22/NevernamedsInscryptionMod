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
    static class Earthworm
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.ChoiceNode,
                CardMetaCategory.TraderOffer
            };



            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/earthworm.png");

            // Add the card
            CardSetupUtility.NewCard("Earthworm",
                "Earthworm",
                0,
                1,
                metaCategories,
                CardTemple.Nature,
                description: "A miserable worm. Useless.",
                bloodCost: 0,
                bonesCost: 1,
                defaultTex: tex,
                abilities: new List<Ability>() { Harbinger.ability, Ability.CorpseEater },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/earthworm_emission.png"),
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/earthworm_pixel.png"),
                tribes: new List<Tribe>() {  },
                defaultEvolutionCard: "BeastNevernamed GiantEarthworm"
                );
        }
    }
}