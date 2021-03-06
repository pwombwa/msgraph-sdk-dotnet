// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum RecurrencePatternType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum RecurrencePatternType
    {
    
        /// <summary>
        /// Daily
        /// </summary>
        Daily = 0,
	
        /// <summary>
        /// Weekly
        /// </summary>
        Weekly = 1,
	
        /// <summary>
        /// Absolute Monthly
        /// </summary>
        AbsoluteMonthly = 2,
	
        /// <summary>
        /// Relative Monthly
        /// </summary>
        RelativeMonthly = 3,
	
        /// <summary>
        /// Absolute Yearly
        /// </summary>
        AbsoluteYearly = 4,
	
        /// <summary>
        /// Relative Yearly
        /// </summary>
        RelativeYearly = 5,
	
    }
}
