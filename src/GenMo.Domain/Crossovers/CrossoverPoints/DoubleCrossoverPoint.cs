﻿using GenMo.Domain.Common.Interfaces.Crossovers;
using GenMo.Domain.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenMo.Domain.Crossovers.CrossoverPoints
{
    public static class DoubleCrossoverPoint
    {
        public static (int, int) GetCrossoverPoints(int chromosomeLength)
        {
            int valueA;
            int valueB;

            while (true)
            {
                (valueA, valueB) = (RandomUtil.Random(0, chromosomeLength), RandomUtil.Random(0, chromosomeLength));

                if (valueA != valueB)
                {
                    return valueA < valueB
                        ? (valueA, valueB)
                        : (valueB, valueA);
                }
            }
        }
    }
}
