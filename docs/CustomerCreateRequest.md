# # CustomerCreateRequest


## Properties 


Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TenantId**| **string** |   | [optional]
**Em**| [**CustomerEMFields**](CustomerEMFields.md) |   | [optional]
**Name**| **string** |   | [optional]
**Surname**| **string** |   | [optional]
**Email**| **string** |   | [optional]
**Birthdate**| **DateTime** |   | [optional]
**Gender**| **string** |   | [optional]
**Enabled**| **bool** |   | [optional]
**Source**| **string** |   | [optional]
**Addresses**| [**List<CustomerAddressEntity>**](CustomerAddressEntity.md) |   | [optional]
**PhoneNumber**| **string** |   | [optional]
**Nationality**| **string** |   | [optional]
**Groups**| **List<string>** |   | [optional]
**Deleted**| **bool** |   | [optional]
**Newsletters**| [**List<CustomerNewsletterRequest>**](CustomerNewsletterRequest.md) |   | [optional]
**DoNotNotify**| **bool** |   | [optional]
**Attributes**| [**Dictionary<string, ProtobufAny>**](ProtobufAny.md) |   | [optional]
**MigratedPassword**| [**CustomerPassword**](CustomerPassword.md) |   | [optional]
**Market**| **string** |   | [optional]
**PreferredLocale**| **string** |   | [optional]
**TaxCode**| **string** |   | [optional]
**CertifiedEmail**| **string** |   | [optional]
**SdiCode**| **string** |   | [optional]
**FiscalCode**| **string** |   | [optional]
**CompanyName**| **string** |   | [optional]
**AdditionalInfo**| **Object** |   | [optional]
**ExternalIds**| **Dictionary<string, string>** |   | [optional]
**Consent**| [**CustomerCreateConsentRequest**](CustomerCreateConsentRequest.md) |   | [optional]
**AggregationId**| **string** |   | [optional]


[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)

