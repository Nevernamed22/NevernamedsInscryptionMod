using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class VelvetWorm
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.ChoiceNode,
                CardMetaCategory.TraderOffer,
                CardMetaCategory.GBCPack,
                CardMetaCategory.GBCPlayable,
            };



            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/velvetworm.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed VelvetWorm",
                "Velvet Worm",
                1,
                1,
                metaCategories,
                CardTemple.Nature,
                description: "The velvet worm... do not let it's soft facade fool you. It spits with terrifying precision.",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.Sniper, },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/velvetworm_emission.png"),
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/velvetworm_pixel.png"),
                tribes: new List<Tribe>() {  }
                );
        }
    }
}