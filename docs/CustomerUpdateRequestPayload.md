# # CustomerUpdateRequestPayload


## Properties 


Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Em**| [**CustomerEMFields**](CustomerEMFields.md) |   | [optional]
**Name**| **string** |   | [optional]
**Surname**| **string** |   | [optional]
**Email**| **string** |   | [optional]
**Birthdate**| **DateTime** |   | [optional]
**Gender**| **string** |   | [optional]
**Enabled**| **bool** |   | [optional]
**Source**| **string** |   | [optional]
**Addresses**| [**List<CustomerAddressEntity>**](CustomerAddressEntity.md) |   | [optional]
**DefaultBillingAddressId**| **string** |   | [optional]
**DefaultShippingAddressId**| **string** |   | [optional]
**PhoneNumber**| **string** |   | [optional]
**Nationality**| **string** |   | [optional]
**Groups**| **List<string>** |   | [optional]
**Deleted**| **bool** |   | [optional]
**Newsletters**| [**List<CustomerNewsletterRequest>**](CustomerNewsletterRequest.md) |   | [optional]
**Attributes**| [**Dictionary<string, ProtobufAny>**](ProtobufAny.md) |   | [optional]
**MigratedPassword**| [**CustomerPassword**](CustomerPassword.md) |   | [optional]
**PreferredLocale**| **string** |   | [optional]
**TaxCode**| **string** |   | [optional]
**CertifiedEmail**| **string** |   | [optional]
**SdiCode**| **string** |   | [optional]
**FiscalCode**| **string** |   | [optional]
**CompanyName**| **string** |   | [optional]
**AdditionalInfo**| **Object** |   | [optional]
**Market**| **string** |   | [optional]
**ExternalIds**| **Dictionary<string, string>** |   | [optional]
**Consent**| [**CustomerCreateConsentRequest**](CustomerCreateConsentRequest.md) |   | [optional]


[[Back to Model list]](../../README.md#models) [[Back to API list]](../../README.md#endpoints) [[Back to README]](../../README.md)

