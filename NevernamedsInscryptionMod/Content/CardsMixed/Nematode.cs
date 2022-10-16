using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace NevernamedsInscryptionMod
{
    static class Nematode
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
            Texture2D tex = Tools.LoadTex( "NevernamedsInscryptionMod/Resources/Cards/nematode.png");

            // Add the card
            CardSetupUtility.NewCard("Nematode",
                "Nematode",
                1,
                1,
                metaCategories,
                CardTemple.Nature,
                description: "The smallest of beasts... utterly replaceable.",
                bloodCost: 0,
                bonesCost: 2,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.DrawCopyOnDeath, Ability.Brittle },
                pixelTex : Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/nematode_pixel.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/nematode_emission.png"),
                tribes: new List<Tribe>() {  }
                );
        }
    }
}
