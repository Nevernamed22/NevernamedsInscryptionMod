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
    static class AngelShark
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed AngelShark",
                "Angel Shark",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Despite the name, it is far from divine.",
                bloodCost: 0,
                bonesCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/angelshark.png"),
                abilities: new List<Ability>() { EvenStrike.ability, Ability.Submerge },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/angelshark_emission.png")
                );
        }
    }
}