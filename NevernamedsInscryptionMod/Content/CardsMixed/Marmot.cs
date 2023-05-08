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
    static class Marmot
    {
        public static void Init()
        {
            // metaCategories determine the card pools
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.ChoiceNode,
                CardMetaCategory.TraderOffer,
            };

            // Load the image into a Texture2D object
            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/marmot.png");

            // Add the card
            CardSetupUtility.NewCard("Marmot",
                "Marmot",
                0,
                2,
                metaCategories,
                CardTemple.Nature,
                description: "The stoic Marmot. It fights for it's fellow squirrels...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/marmot_emission.png"),
                tribes: new List<Tribe>() { Tribe.Squirrel, NevernamedsTribes.Rodent  },
                specialAbilities: new List<SpecialTriggeredAbility>() { OneHalfSquirrels.ability },
                variableStat : OneHalfSquirrels.specialStatIcon
                );
        }
    }
}
