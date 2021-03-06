﻿// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Ads.GoogleAds.Examples.V5;
using NUnit.Framework;

namespace Google.Ads.GoogleAds.Tests.Examples.V5
{
    /// <summary>
    /// Tests the UpdateCampaignCriterionBidModifier code example.
    /// </summary>
    [TestFixture]
    [Category("CodeExamples")]
    internal class UpdateCampaignCriterionBidModifierTest : ExampleTestsBase
    {
        /// <summary>
        /// The campaign ID for test purposes.
        /// </summary>
        private long campaignId;

        /// <summary>
        /// The mobile device criterion ID for testing purposes.
        /// </summary>
        private const long MOBILE_DEVICE_CRITERION_ID = 30001;

        /// <summary>
        /// The test bid modifier.
        /// </summary>
        private const float TEST_BID_MODIFIER = 1.2f;

        /// <summary>
        /// Inits this instance.
        /// </summary>
        [SetUp]
        public void Init()
        {
            string budgetResourceName = ExampleTestsUtils.CreateBudget(client);
            string campaignResourceName = ExampleTestsUtils.CreateCampaign(client,
                budgetResourceName);
            campaignId = ExampleTestsUtils.GetCampaign(client, campaignResourceName);
        }

        /// <summary>
        /// Tests the Run method.
        /// </summary>
        [Test]
        public void TestRun()
        {
            RunExample(delegate ()
            {
                new UpdateCampaignCriterionBidModifier().Run(client, config.ClientCustomerId,
                    campaignId, MOBILE_DEVICE_CRITERION_ID, TEST_BID_MODIFIER);
            });
        }
    }
}
