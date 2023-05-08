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
    static class BeastOfExmoor
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BeastOfExmoor",
                "Beast Of Exmoor",
                3,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The illusory exmoor cat... hard to catch, harder to kill.",
                bloodCost: 0,
                bonesCost: 7,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/beastofexmoor.png"),
                abilities: new List<Ability>() { Immaterial.ability, Harbinger.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/beastofexmoor_emission.png")
                );
        }
    }
}
