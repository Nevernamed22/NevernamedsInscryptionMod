using APIPlugin;
using DiskCardGame;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using NevernamedsSigils;
using InscryptionAPI.Card;

namespace NevernamedsInscryptionMod
{
    static class GastricBrooder
    {
        public static void Init()
        {
          CardInfo inf =  CardSetupUtility.NewCard("Nevernamed GastricBrooder",
                "Gastric Brooder",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The bloated Gastric Brooding Frog... it raises its young within its own stomach.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gastricbrooder.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/gastricbrooder_emission.png"),
                abilities: new List<Ability>() { Expulsion.ability },
                tribes: new List<Tribe>() { Tribe.Reptile }
                );
            inf.SetExtendedProperty("ExpulsionOverride", "Tadpole");
        }
    }
}
