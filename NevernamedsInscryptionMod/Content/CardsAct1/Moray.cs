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
    static class Moray
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Moray",
                "Moray",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "The fierce moray, even the deepest waters cannot protect from its keen hunters sense.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/moray.png"),
                abilities: new List<Ability>() { Ability.Submerge, Diver.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/moray_emission.png")
                );
        }
    }
}