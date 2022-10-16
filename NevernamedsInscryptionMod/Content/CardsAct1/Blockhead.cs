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
    static class Blockhead
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Blockhead",
                "Blockhead",
                0,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A comically frontheavy insect.",
                bloodCost: 0,
                bonesCost: 2,
                //energyCost: 2,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blockhead.png"),
                abilities: new List<Ability>() { Ability.Reach },
                tribes: new List<Tribe>() { Tribe.Insect },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/blockhead_emission.png")
                );
        }
    }
}
