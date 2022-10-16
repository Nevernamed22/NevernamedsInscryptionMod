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
    static class DyingSpider
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dyingspider.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed DyingSpider",
                "Dying Spider",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A poor arachnid, caught in the throws of death. I will allow you to play it for free.",
                bloodCost: 0,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { Doomed.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/dyingspider_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
