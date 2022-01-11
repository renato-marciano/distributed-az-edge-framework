// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------
targetScope = 'subscription'

@description('The common name for this application')
param applicationName string

@description('Location of resources')
@allowed([
  'westeurope'
  'northeurope'
  'westus'
  'swedencentral'
])
param location string = 'westeurope'

var applicationNameWithoutDashes = '${replace(applicationName,'-','')}'
var resourceGroupName = 'rg-${applicationNameWithoutDashes}'
var aksName = '${take('aks-${applicationNameWithoutDashes}',20)}'
var acrName = 'acr${applicationNameWithoutDashes}'

resource rg 'Microsoft.Resources/resourceGroups@2020-10-01' = {
  name: resourceGroupName
  location: location
}

module aks 'modules/aks.bicep' = {
  name: 'aksDeployment'
  scope: resourceGroup(rg.name)
  params: {
    aksName: aksName
  }
}

module acr 'modules/acr.bicep' = {
  scope: resourceGroup(rg.name)
  name: 'acrDeployment'
  params: {
    acrName: acrName
    aksPrincipalId: aks.outputs.clusterPrincipalID
  }

  dependsOn: [
    aks
  ]
}

output acrName string = acrName
output aksName string = aks.outputs.aksName
output resourceGroupName string = resourceGroupName
