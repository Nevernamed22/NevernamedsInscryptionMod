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
    static class SpinyApe
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed SpinyApe",
                "Spiny Ape",
                1,
                5,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A rare and perplexing creature, the spiny ape... its form is enough to deter a sane attacker.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/spinyape.png"),
                abilities: new List<Ability>() { Ability.Sharp, Ability.MoveBeside },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/spinyape_emission.png")
                );
        }
    }
}