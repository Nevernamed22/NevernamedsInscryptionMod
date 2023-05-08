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
    static class Lemur
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Lemur",
                "Lemur",
                1,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The ringtailed lemur. It's tail is adorned with magnificent stripes.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/lemur.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/lemur_emission.png"),
                abilities: new List<Ability>() { SinisterStrike.ability },
                tribes: new List<Tribe>() { }
                );
        }
    }
}
