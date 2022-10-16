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
    static class Tick
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/tick.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed Tick",
                "Tick",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A bloated tick. It becomes sturdier as it feeds.",
                bloodCost: 0,
                bonesCost: 5,
                defaultTex: tex,
                abilities: new List<Ability>() { Vampiric.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/tick_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
