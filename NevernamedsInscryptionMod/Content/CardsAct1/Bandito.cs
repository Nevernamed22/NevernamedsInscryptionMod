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
    static class Bandito
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Bandito",
                "Bandito",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer},
                CardTemple.Nature,
                description: "A peculiar deathcard- no matter how many times I tear it to pieces, I always find it back in my deck...",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bandito.png"),
                abilities: new List<Ability>() { Enraged.ability, Cheater.ability },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bandito_emission.png")
                );
        }
    }
}
