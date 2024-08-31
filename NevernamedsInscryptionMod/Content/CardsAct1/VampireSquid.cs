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
    static class VampireSquid
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed VampireSquid",
                "Vampire Squid",
                2,
                1,
                new List<CardMetaCategory> { CardMetaCategory.ChoiceNode, CardMetaCategory.TraderOffer },
                CardTemple.Nature,
                description: "Lurks in the deepest dark, blacker than the blackest black...  times infinity",
                bloodCost: 2,
                bonesCost: 0,
                defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/vampiresquid.png"),
                abilities: new List<Ability>() { BloodGusher.ability, Ability.Submerge },
                tribes: new List<Tribe>() { },
                emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/vampiresquid_emission.png")
                );
        }
    }
}