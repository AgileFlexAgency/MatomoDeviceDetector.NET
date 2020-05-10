// --------------------------------------------------------------------------------------------------------------------------
// <copyright file="PimParser.cs" company="Agile Flex Agency">
// Copyright © 2000-2020 by Agile Flex Agency. All rights reserved. Website: https://agile-flex.com
// </copyright>
// --------------------------------------------------------------------------------------------------------------------------

namespace MatomoDeviceDetectorNET.Services.Parser.Client
{
    using System.Collections.Generic;
    using MatomoDeviceDetectorNET.Services.Client;
    using MatomoDeviceDetectorNET.Services.Results.Client;

    /// <summary>
    /// PimParser.
    /// </summary>
    public class PimParser : ClientParserAbstract<List<Pim>, ClientMatchResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PimParser"/> class.
        /// </summary>
        public PimParser()
        {
            this.FixtureFile = "regexes/client/pim.yml";
            this.ParserName = "pim";
            this.RegexList = this.GetRegexes();
        }
    }
}