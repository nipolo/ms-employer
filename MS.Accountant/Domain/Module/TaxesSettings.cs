﻿using System.Collections.Generic;

namespace MS.Accountant.Domain.Module
{
    public class TaxesSettings
    {
        public const string Key = nameof(TaxesSettings);

        public decimal MaxCharityFreePercent { get; init; }

        public Dictionary<string, TaxSettings> Taxes { get; init; }
    }
}
