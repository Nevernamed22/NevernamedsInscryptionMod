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
    static class Deepstaria
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Deepstaria",
                "Deepstaria",
                0,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The gelatinous Deepstaria... little more than a bag of tissue- right down to the surprise inside.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/deepstaria.png"),
                abilities: new List<Ability>() { GraveyardShift.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/deepstaria_emission.png"),
                defaultFrozenCard: "BeastNevernamed Isopod"
                );
        }
    }
}
