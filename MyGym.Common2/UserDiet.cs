﻿using MyGym.Common2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGym.Common2
{
    public class UserDiet
    {
        public int DietID { get; set; }
        public List<TiempoComida> MealTime { get; set; }

        public int RecomendationID { get; set; }
        public string Name { get; set; }

        public string ImageURL { get; set; }
    }
}
