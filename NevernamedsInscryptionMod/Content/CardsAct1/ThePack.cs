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
    static class ThePack
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ThePack",
                "The Pack",
                3,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "A pack of hungry dogs. They hunt together, but break away when in danger.",
                bloodCost: 2,
                bonesCost: 0,
                energyCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/thepack.png"),
                abilities: new List<Ability>() { KinBearer.ability },
                tribes: new List<Tribe>() { Tribe.Canine },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/thepack_emission.png")
                );
        }
    }
}
