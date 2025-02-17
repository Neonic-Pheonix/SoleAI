﻿namespace SoleAI.Losses
{
    // Binary Crossentropy / Log Loss (use with sigmoid)
    public class BCELoss : ILoss
    {
        public float Calc(float[][] predictions, float[][] actualValues)
        {
            return 0;
        }

        public ValueRange GetValueRange()
        {
            return ValueRange.ZeroToOne;
        }
    }
}