﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Network.Test.ScenarioTests;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Xunit;

namespace Commands.Network.Test.ScenarioTests
{
    public class NatGatewayTests: NetworkTestRunner
    {
        public NatGatewayTests(Xunit.Abstractions.ITestOutputHelper output)
            : base(output)
        {
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.slbdev)]
        public void TestNatGatewayCRUDMinimalParameters()
        {
            TestRunner.RunTestScript("Test-NatGatewayCRUDMinimalParameters");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.slbdev)]
        public void TestNatGatewayCRUDAllParameters()
        {
            TestRunner.RunTestScript("Test-NatGatewayCRUDAllParameters");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.slbdev)]
        public void TestNatGatewayWithSubnet()
        {
            TestRunner.RunTestScript("Test-NatGatewayWithSubnet");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.slbdev)]
        public void TestNatGatewayWithPIPsAndSourceVnet()
        {
            TestRunner.RunTestScript("Test-NatGatewayWithPIPsAndSourceVnet");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.slbdev)]
        public void TestNatGatewayWithPrefixesAndSourceVnet()
        {
            TestRunner.RunTestScript("Test-NatGatewayWithPrefixesAndSourceVnet");
        }

        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]
        [Trait(Category.Owner, NrpTeamAlias.slbdev)]
        public void TestVirtualNetworkSubnetConfigWithNatGateway()
        {
            TestRunner.RunTestScript("Test-VirtualNetworkSubnetConfigWithNatGateway");
        }
    }
}