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
    static class Megaladaptis
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Megaladaptis",
                "Megaladaptis",
                1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "This creature is unpleasant. It looks... shifty.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/megaladaptis.png"),
                abilities: new List<Ability>() {DivisibilityStrike.ability, },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/megaladaptis_emission.png")
                );
        }
    }
}
