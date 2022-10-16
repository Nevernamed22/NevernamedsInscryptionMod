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
    static class CrabSpider
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/crabspider.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed CrabSpider",
                "Crab Spider",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The hardy crab spider, it clings relentlessly to any source of food or warmth.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Ability.MoveBeside },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/crabspider_emission.png"),

                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
