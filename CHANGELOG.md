<!--
    Please leave this section at the top of the change log.

    Changes for the upcoming release should go under the section titled "Upcoming Release", and should adhere to the following format:

    ## Upcoming Release
    * Overview of change #1
        - Additional information about change #1
    * Overview of change #2
        - Additional information about change #2
        - Additional information about change #2
    * Overview of change #3
    * Overview of change #4
        - Additional information about change #4

    ## YYYY.MM.DD - Version X.Y.Z (Previous Release)
    * Overview of change #1
        - Additional information about change #1
-->

# Change Log

## 1.15.6

* Agreements
  * Addressed issue [#262](https://github.com/microsoft/Partner-Center-PowerShell/issues/262) that was preventing [Get-PartnerAgreementDocument](https://docs.microsoft.com/powershell/module/partnercenter/Get-PartnerAgreementDocument) from being invoked when the `Language` parameter was specified
* Qualifications
  * Addressed issue [#258](https://github.com/microsoft/Partner-Center-PowerShell/issues/258) with the [Set-PartnerCustomerQualification](https://docs.microsoft.com/powershell/module/partnercenter/Set-PartnerCustomerQualification) command that was preventing API exception information from being parsed as excepted

## 1.15.5

* Core
  * Adding the ability to create an instance of the partner operations with a request context

## 1.15.4

* Product Upgrades
  * Addressed an issue with starting the upgrade process for an Azure Plan

## 1.15.3

* Compliance
  * Added the ability to check if a partner has accepted the Microsoft Partner Agreement
* Diagnostic
  * Implemented service client tracing to provide additional debug and error information
* Invoice
  * Addressed an issue where the *AdditionalInfo* and *Tags* properties for the [DailyRatedUsageLineItem](https://github.com/isaiahwilliams/partner-center-dotnet/blob/master/src/PartnerCenter/Models/Invoices/DailyRatedUsageLineItem.cs) resource were not deserializing as excepted
* Subscriptions
  * Addressed an issue where the request for subscriptions by partner was causing an `InvalidCastException` to be thrown  

## 1.15.2

* Users
  * Corrected the URI used by the customer user query operation (Thanks [@erickbp](https://github.com/erickbp))
