using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Guid;

namespace NevernamedsInscryptionMod
{
    static class JumpingSpider
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.ChoiceNode,
                CardMetaCategory.TraderOffer,
                CardMetaCategory.GBCPlayable,
                CardMetaCategory.GBCPack
            };



            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/jumpingspider.png");

            // Add the card
            CardSetupUtility.NewCard("Nevernamed JumpingSpider",
                "Jumping Spider",
                1,
                1,
                metaCategories,
                CardTemple.Nature,
                description: "The nimble jumping spider, smallest of it's clan. It's profound leap can snatch prey from the air.",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.Reach, },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/jumpingspider_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/jumpingspider_emission.png"),
                tribes: new List<Tribe>() { GuidManager.GetEnumValue<Tribe>("nevernamed.inscryption.sigils", "Arachnid") }
                );
        }
    }
}

