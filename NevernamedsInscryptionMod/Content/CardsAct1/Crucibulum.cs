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
    static class Crucibulum
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Crucibulum",
                "Crucibulum",
                1,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "A peculiar little snail, forever growing it's conical shell.",
                bloodCost: 0,
                bonesCost: 3,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/crucibulum.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/crucibulum_emission.png"),
                abilities: new List<Ability>() { Healshield.ability },
                tribes: new List<Tribe>() {  }
                );
        }
    }
}
