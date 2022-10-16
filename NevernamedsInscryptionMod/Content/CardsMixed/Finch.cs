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
    static class Finch
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.ChoiceNode,
                CardMetaCategory.TraderOffer,
                CardMetaCategory.GBCPack,
                CardMetaCategory.GBCPlayable
            };



            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/finch.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed Finch",
                "Finch",
                1,
                3,
                metaCategories,
                CardTemple.Nature,
                description: "The careless finch. It's flighty nature is likely to put it right in the path of danger...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Flighty.ability, Ability.Flying },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/finch_emission.png"),
                tribes: new List<Tribe>() { Tribe.Bird },
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/finch_pixel.png")
                );
        }
    }
}
