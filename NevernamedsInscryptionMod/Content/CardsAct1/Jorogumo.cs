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
    static class Jorogumo
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Jorogumo",
                "Jorogumo",
                3,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "The sultry spider maiden, slowly drawing you in on a silken thread. Before you even know it, you're caught in her snare.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { SpidersWeb.ability },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/jorogumo.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() { NevernamedsTribes.Arachnid },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/jorogumo_emission.png")
                );
        }
    }
}