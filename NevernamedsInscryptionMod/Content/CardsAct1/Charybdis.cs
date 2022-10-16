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
    static class Charybdis
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Charybdis",
                "Charybdis",
                1,
                3,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Charybdis, the infernal vortex. Sucks all around it into it's collossal maw.",
                bloodCost: 2,
                bonesCost: 0,
                abilities: new List<Ability>() { Ability.Sentry, Allure.ability, Ability.Submerge },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/charybdis.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/charybdis_emission.png")
                );
        }
    }
}