﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreationandDevelopment
{
    public interface IMoodBehaviour
    {
        void SetMoodEffectsandModifiers();
        void RemoveMoodEffectsandModifiers();
        //Image moodImage { get; set; }
    }
}
