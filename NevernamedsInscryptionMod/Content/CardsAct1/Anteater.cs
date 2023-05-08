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
    static class Anteater
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Anteater",
                "Anteater",
                1,
               3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The slothly anteater only attacks with vigour when presented with a meal.",
                bloodCost: 0,
                bonesCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/anteater.png"),
                abilities: new List<Ability>() { Insectivore.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/anteater_emission.png")
                );
        }
    }
}
