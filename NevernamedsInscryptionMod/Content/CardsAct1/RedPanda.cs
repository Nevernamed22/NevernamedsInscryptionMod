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
    static class RedPanda
    {
        public static void Init()
        {

            Texture2D tex = Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/redpanda.png");
            // Add the card
            CardSetupUtility.NewCard("Nevernamed RedPanda",
                "Red Panda",
                2,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The sleepy red panda, it takes every second turn to rest.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: tex,
                abilities: new List<Ability>() { TransformerCustom.ability, },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/redpanda_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );

            // Add the card
            CardSetupUtility.NewCard("Nevernamed RedPandaSleeping",
                "Red Panda",
                0,
                3,
                new List<CardMetaCategory> { },
                CardTemple.Nature,
                description: "",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/redpandasleeping.png"),
                abilities: new List<Ability>() { TransformerCustom.ability, Abstain.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/redpandasleeping_emission.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { }
                );
        }
    }
}
