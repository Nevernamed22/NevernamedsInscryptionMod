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
    static class BeachedWhale
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
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/beachedwhale.png");

            // Add the card
           CardSetupUtility.NewCard("BeachedWhale",
                "Beached Whale",
                0,
                4,
                metaCategories,
                CardTemple.Nature,
                description: "The poor thing, completely out of it's element... it bursts upon death.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/beachedwhale_pixel.png"),
                abilities: new List<Ability>() { ExplodingCorpseCustom.ability, },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/beachedwhale_emission.png"),
                defaultEvolutionCard: "BeastNevernamed BlueWhale"
                );
        }
    }
}