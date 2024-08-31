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
    static class KingCrab
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed KingCrab",
                "King Crab",
                2,
                4,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "Its shell is ever-sharp as its claws.",
                bloodCost: 3,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/kingcrab.png"),
                abilities: new List<Ability>() { Ability.SplitStrike, Snip.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Crustacean },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/kingcrab_emission.png")
                );
        }
    }
}