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
    static class Camazotz
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed Camazotz",
                "Camazotz",
                2,
                2,
                new List<CardMetaCategory> { CardMetaCategory.Rare },
                CardTemple.Nature,
                description: "Camazotz, the bat god. He flies low amongst his enemies, slashing them with his bloodstained claws.",
                bloodCost: 2,
                bonesCost: 3,
                abilities: new List<Ability>() { SwoopingStrike.ability, Ability.Deathtouch },
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/camazotz.png"),
                appearanceBehaviour: new List<CardAppearanceBehaviour.Appearance> { CardAppearanceBehaviour.Appearance.RareCardBackground, },
                tribes: new List<Tribe>() {  },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/camazotz_emission.png")
                );
        }
    }
}