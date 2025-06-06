---
external help file:
Module Name: Az.Cdn
online version: https://learn.microsoft.com/powershell/module/az.cdn/clear-azcdnendpointcontent
schema: 2.0.0
---

# Clear-AzCdnEndpointContent

## SYNOPSIS
Removes a content from CDN.

## SYNTAX

### PurgeExpanded (Default)
```
Clear-AzCdnEndpointContent -EndpointName <String> -ProfileName <String> -ResourceGroupName <String>
 -ContentPath <String[]> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait]
 [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### Purge
```
Clear-AzCdnEndpointContent -EndpointName <String> -ProfileName <String> -ResourceGroupName <String>
 -ContentFilePath <IPurgeParameters> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-AsJob]
 [-NoWait] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PurgeViaIdentity
```
Clear-AzCdnEndpointContent -InputObject <ICdnIdentity> -ContentFilePath <IPurgeParameters>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PurgeViaIdentityExpanded
```
Clear-AzCdnEndpointContent -InputObject <ICdnIdentity> -ContentPath <String[]> [-DefaultProfile <PSObject>]
 [-AsJob] [-NoWait] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PurgeViaIdentityProfile
```
Clear-AzCdnEndpointContent -EndpointName <String> -ProfileInputObject <ICdnIdentity>
 -ContentFilePath <IPurgeParameters> [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-PassThru] [-Confirm]
 [-WhatIf] [<CommonParameters>]
```

### PurgeViaIdentityProfileExpanded
```
Clear-AzCdnEndpointContent -EndpointName <String> -ProfileInputObject <ICdnIdentity> -ContentPath <String[]>
 [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PurgeViaJsonFilePath
```
Clear-AzCdnEndpointContent -EndpointName <String> -ProfileName <String> -ResourceGroupName <String>
 -JsonFilePath <String> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

### PurgeViaJsonString
```
Clear-AzCdnEndpointContent -EndpointName <String> -ProfileName <String> -ResourceGroupName <String>
 -JsonString <String> [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-AsJob] [-NoWait] [-PassThru]
 [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
Removes a content from CDN.

## EXAMPLES

### Example 1: Removes a content from CDN endpoint using Parameter "ContentPath"
```powershell
Clear-AzCdnEndpointContent -ResourceGroupName testps-rg-da16jm -ProfileName cdn001 -EndpointName endptest001 -ContentPath @("/movies/*","/pictures/pic1.jpg") 
```

Removes a content from CDN endpoint using Parameter "ContentPath"

### Example 2: Removes a content from CDN endpoint using Parameter "ContentFilePath"
```powershell
$contentPath = @("/movies/amazing.mp4","/pictures/pic1.jpg")
$contentFilePath = New-AzCdnPurgeParametersObject -ContentPath $contentPath
Clear-AzCdnEndpointContent -ResourceGroupName testps-rg-da16jm -ProfileName cdn001 -EndpointName endptest001 -ContentFilePath $contentFilePath
```

Removes a content from CDN endpoint using Parameter "ContentFilePath"

## PARAMETERS

### -AsJob
Run the command as a job

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ContentFilePath
Parameters required for content purge.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IPurgeParameters
Parameter Sets: Purge, PurgeViaIdentity, PurgeViaIdentityProfile
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ContentPath
The path to the content to be purged.
Can describe a file path or a wild card directory.

```yaml
Type: System.String[]
Parameter Sets: PurgeExpanded, PurgeViaIdentityExpanded, PurgeViaIdentityProfileExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The DefaultProfile parameter is not functional.
Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -EndpointName
Name of the endpoint under the profile which is unique globally.

```yaml
Type: System.String
Parameter Sets: Purge, PurgeExpanded, PurgeViaIdentityProfile, PurgeViaIdentityProfileExpanded, PurgeViaJsonFilePath, PurgeViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -InputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICdnIdentity
Parameter Sets: PurgeViaIdentity, PurgeViaIdentityExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -JsonFilePath
Path of Json file supplied to the Purge operation

```yaml
Type: System.String
Parameter Sets: PurgeViaJsonFilePath
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -JsonString
Json string supplied to the Purge operation

```yaml
Type: System.String
Parameter Sets: PurgeViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -NoWait
Run the command asynchronously

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProfileInputObject
Identity Parameter

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICdnIdentity
Parameter Sets: PurgeViaIdentityProfile, PurgeViaIdentityProfileExpanded
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -ProfileName
Name of the CDN profile which is unique within the resource group.

```yaml
Type: System.String
Parameter Sets: Purge, PurgeExpanded, PurgeViaJsonFilePath, PurgeViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
Name of the Resource group within the Azure subscription.

```yaml
Type: System.String
Parameter Sets: Purge, PurgeExpanded, PurgeViaJsonFilePath, PurgeViaJsonString
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
Azure Subscription ID.

```yaml
Type: System.String
Parameter Sets: Purge, PurgeExpanded, PurgeViaJsonFilePath, PurgeViaJsonString
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.ICdnIdentity

### Microsoft.Azure.PowerShell.Cmdlets.Cdn.Models.IPurgeParameters

## OUTPUTS

### System.Boolean

## NOTES

## RELATED LINKS

