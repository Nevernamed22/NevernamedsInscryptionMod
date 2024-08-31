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
    static class CrookedMouse
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed CrookedMouse",
                "Crooked Mouse",
                1,
                2,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "It was never the same after a run in with a crooked cat...",
                bloodCost: 1,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/crookedmouse.png"),
                abilities: new List<Ability>() { Phantasmic.ability },
                tribes: new List<Tribe>() { NevernamedsTribes.Rodent },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/crookedmouse_emission.png")
                );
        }
    }
}