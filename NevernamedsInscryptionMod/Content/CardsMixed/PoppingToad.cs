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
    static class PoppingToad
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.ChoiceNode,
                CardMetaCategory.TraderOffer,
                CardMetaCategory.GBCPlayable,
                CardMetaCategory.GBCPack,
            };



            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/poppingtoad.png");

            // Add the card
            CardSetupUtility.NewCard("PoppingToad",
                "Popping Toad",
                1,
                1,
                metaCategories,
                CardTemple.Nature,
                description: "A gruesome spectacle, this toad's guts burst out when it is played...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { GutSpewer.ability, },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/poppingtoad_emission.png"),
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/poppingtoad_pixel.png"),
                tribes: new List<Tribe>() { Tribe.Reptile }
                );
        }
    }
}