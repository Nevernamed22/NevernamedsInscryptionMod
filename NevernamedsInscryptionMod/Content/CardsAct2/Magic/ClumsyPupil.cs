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
    static class ClumsyPupil
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed ClumsyPupil",
                 "Clumsy Pupil",
                 0,
                 2,
                 new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                 CardTemple.Wizard,
                 description: "",
                 gemsCost: new List<GemType>() {  },
                 abilities: new List<Ability>() { GemShedder.ability, Ability.GemDependant },
                 pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/clumsypupil_pixel.png")
                 );
        }
    }
}