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
    static class Terrashot
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Terrashot",
                "Terrashot",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "A peculiar specimen... it heats up in the sun- with fatal consequences.",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/terrashot.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/terrashot_emission.png"),
                abilities: new List<Ability>() { Ability.Strafe, Ability.ExplodeOnDeath },
                tribes: new List<Tribe>() { Tribe.Hooved }
                );
        }
    }
}
