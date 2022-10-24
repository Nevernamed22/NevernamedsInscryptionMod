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
    static class ParrotFish
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ParrotFish",
                "Parrot Fish",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The clumsy Parrot Fish. It uses it's sharp beak to chew away at it's environment- shifting the seabed.",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/parrotfish.png"),
                abilities: new List<Ability>() { Ability.Submerge, Landscaper.ability },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/parrotfish_emission.png")
                );
        }
    }
}
