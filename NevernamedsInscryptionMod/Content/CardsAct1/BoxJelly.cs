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
    static class BoxJelly
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BoxJelly",
                "Box Jelly",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer, },
                CardTemple.Nature,
                description: "Small, but possessing of a crippling set of stingers.",
                bonesCost: 4,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/boxjelly.png"),
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/boxjelly_emission.png"),
                abilities: new List<Ability>() { SubaquaticSpines.ability, Paralytic.ability },
                tribes: new List<Tribe>() {  }
                );
        }
    }
}