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
    static class PupilOfGun
    {
        public static void Init()
        {
            CardSetupUtility.NewCard("Nevernamed PupilOfGun",
                "Pupil Of Gun",
                0,
                1,
                new List<CardMetaCategory> { CardMetaCategory.GBCPack, CardMetaCategory.GBCPlayable },
                CardTemple.Wizard,
                description: "",
                gemsCost: new List<GemType>() { GemType.Green },
                abilities: new List<Ability>() { Marcescent.ability, Ability.Sentry },
                pixelTex: Tools.LoadTex("NevernamedsInscryptionMod/Resources/PixelCards/pupilofgun_pixel.png")
                );
        }
    }
}