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
    static class Neocarus
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Neocarus",
                "Neocarus",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "This little mite used to haunt all manner of caves...",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/neocarus.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/neocarus_emission.png"),
                abilities: new List<Ability>() { TransformerCustom.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                transformerForm: "BeastNevernamed NeocarusTwo"
                );

            CardSetupUtility.NewCard("Nevernamed NeocarusTwo",
                "Neocarus",
                2,
                2,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "This little mite used to haunt all manner of caves...",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/neocarus.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/neocarus_emission.png"),
                abilities: new List<Ability>() { TransformerCustom.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                transformerForm: "BeastNevernamed NeocarusThree"
                );

            CardSetupUtility.NewCard("Nevernamed NeocarusThree",
                "Neocarus",
                3,
                3,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "This little mite used to haunt all manner of caves...",
                bloodCost: 0,
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/neocarus.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/neocarus_emission.png"),
                abilities: new List<Ability>() { TransformerCustom.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                transformerForm: "BeastNevernamed Neocarus"
                );
        }
    }
}