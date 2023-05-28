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
    static class BlueWhale
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed BlueWhale",
                 "Blue Whale",
                 0,
                 7,
                 new List<CardMetaCategory>{CardMetaCategory.ChoiceNode,CardMetaCategory.TraderOffer},
                 CardTemple.Nature,
                 description: "The greatest mortal beast ever to roam the seas... but not the greatest immortal one.",
                 bloodCost: 3,
                 bonesCost: 0,
                 defaultTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bluewhale.png"),
                 emissionTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/Cards/bluewhale_emission.png"),
                 abilities: new List<Ability>() { Ability.TripleBlood, Disembowel.ability, },
                 defaultEvolutionCard: "BeastNevernamed WhiteWhale"
                 );
        }
    }
}