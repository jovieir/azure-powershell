---
external help file: Az.ApplicationInsights-help.xml
Module Name: Az.Applicationinsights
online version: https://learn.microsoft.com/powershell/module/az.applicationinsights/get-azapplicationinsightsworkbookrevision
schema: 2.0.0
---

# Get-AzApplicationInsightsWorkbookRevision

## SYNOPSIS
Get a single workbook revision defined by its revisionId.

## SYNTAX

### List (Default)
```
Get-AzApplicationInsightsWorkbookRevision -Name <String> -ResourceGroupName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzApplicationInsightsWorkbookRevision -Name <String> -ResourceGroupName <String> -RevisionId <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzApplicationInsightsWorkbookRevision -InputObject <IApplicationInsightsIdentity>
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Get a single workbook revision defined by its revisionId.

## EXAMPLES

### Example 1: List all workbook revisions
```powershell
Get-AzApplicationInsightsWorkbookRevision -ResourceGroupName appinsights-hkrs2v-test -Name f7d7151e-7907-4f46-8a5e-6bf4a4cfedec | fl
```

```output
ResourceGroupName       Name                                 DisplayName                                  Location Kind   Category
-----------------       ----                                 -----------                                  -------- ----   --------
appinsights-hkrs2v-test f7d7151e-7907-4f46-8a5e-6bf4a4cfedec f7d7151e-7907-4f46-8a5e-6bf4a4cfedec-display westus2  shared workbook
```

This command lists all workbook revisions.

### Example 2: Get a single workbook revision defined by its revisionId
```powershell
Get-AzApplicationInsightsWorkbookRevision -ResourceGroupName appinsights-hkrs2v-test -Name f7d7151e-7907-4f46-8a5e-6bf4a4cfedec -RevisionId "91788fbfb8384ea5998ac73b9fa3e6eb"
```

```output
ResourceGroupName       Name                                 DisplayName                                  Location Kind   Category
-----------------       ----                                 -----------                                  -------- ----   --------
appinsights-hkrs2v-test f7d7151e-7907-4f46-8a5e-6bf4a4cfedec f7d7151e-7907-4f46-8a5e-6bf4a4cfedec-display westus2  shared workbook
```

This command gets a single workbook revision defined by its revisionId.

### Example 3: Get a single workbook revision defined by resource id
```powershell
Get-AzApplicationInsightsWorkbookRevision -InputObject "/subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx/resourcegroups/appinsights-hkrs2v-test/providers/microsoft.insights/workbooks/f7d7151e-7907-4f46-8a5e-6bf4a4cfedec/revisions/91788fbfb8384ea5998ac73b9fa3e6eb"
```

```output
ResourceGroupName       Name                                 DisplayName                                  Location Kind   Category
-----------------       ----                                 -----------                                  -------- ----   --------
appinsights-hkrs2v-test f7d7151e-7907-4f46-8a5e-6bf4a4cfedec f7d7151e-7907-4f46-8a5e-6bf4a4cfedec-display westus2  shared workbook
```

This command gets a single workbook revision defined by resource id.

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

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

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.IApplicationInsightsIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
```

### -Name
The name of the resource.

```yaml
Type: System.String
Parameter Sets: List, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: List, Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -RevisionId
The id of the workbook's revision.

```yaml
Type: System.String
Parameter Sets: Get
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String[]
Parameter Sets: List, Get
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.IApplicationInsightsIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbook

## NOTES

ALIASES

COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.


`INPUTOBJECT <IApplicationInsightsIdentity>`: Identity Parameter
  - `[AnnotationId <String>]`: The unique annotation ID. This is unique within a Application Insights component.
  - `[ComponentName <String>]`: The name of the Application Insights component resource.
  - `[ExportId <String>]`: The Continuous Export configuration ID. This is unique within a Application Insights component.
  - `[Id <String>]`: Resource identity path
  - `[KeyId <String>]`: The API Key ID. This is unique within a Application Insights component.
  - `[PurgeId <String>]`: In a purge status request, this is the Id of the operation the status of which is returned.
  - `[ResourceGroupName <String>]`: The name of the resource group. The name is case insensitive.
  - `[ResourceName <String>]`: The name of the Application Insights component resource.
  - `[RevisionId <String>]`: The id of the workbook's revision.
  - `[StorageType <StorageType?>]`: The type of the Application Insights component data source for the linked storage account.
  - `[SubscriptionId <String>]`: The ID of the target subscription.
  - `[WebTestName <String>]`: The name of the Application Insights WebTest resource.

## RELATED LINKS
