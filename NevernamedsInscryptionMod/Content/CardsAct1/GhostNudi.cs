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
    static class GhostNudi
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed GhostNudi",
                "Ghost Nudi",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "The Ghost Nudi... it's difficult to tell where it begins and ends.",
                bloodCost: 0,
                bonesCost: 5,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/ghostnudi.png"),
                abilities: new List<Ability>() { Gooey.ability, HaunterCustom.ability },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/ghostnudi_emission.png")
                );
        }
    }
}
