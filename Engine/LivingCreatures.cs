﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class LivingCreatures
    {
        public int CurrentHitPoints { get; set; }
        public int MaximumHitPoints { get; set; }

        public LivingCreatures(int currentHitPoints, int maximumHitPoints) 
        {
            CurrentHitPoints= currentHitPoints;
            MaximumHitPoints= maximumHitPoints;
        }    
    }
}
