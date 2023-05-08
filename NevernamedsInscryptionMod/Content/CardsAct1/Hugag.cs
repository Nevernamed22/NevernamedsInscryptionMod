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
    static class Hugag
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed FallenHugag",
                "Fallen Hugag",
                0,
                7,
                new List<CardMetaCategory> {  },
                CardTemple.Nature,
                description: "A rather pathetic specimen. It stumbles about on kneeless legs.",
                bloodCost: 3,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/fallenhugag.png"),
                abilities: new List<Ability>() {  },
                tribes: new List<Tribe>() { Tribe.Hooved }
                );

            CardSetupUtility.NewCard("Nevernamed Hugag",
                "Hugag",
                5,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "A rather pathetic specimen. It stumbles about on kneeless legs.",
                bloodCost: 3,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hugag.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/hugag_emission.png"),
                abilities: new List<Ability>() { Ability.StrafePush, Frail.ability, GraveyardShift.ability },
                tribes: new List<Tribe>() { Tribe.Hooved },
                defaultFrozenCard: "BeastNevernamed FallenHugag"
                );
        }
    }
}
